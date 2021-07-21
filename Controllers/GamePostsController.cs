using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CSharpProject.Controllers
{
    public class GamePostsController : Controller
    {
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }

        private CSharpProjectContext db;

        public GamePostsController(CSharpProjectContext context)
        {
            db = context;
        }

        [HttpGet("/posts")]
        public IActionResult All()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            List<GamePost> allGamePosts = db.GamePosts
                .Include(post => post.Author)
                // .Include(post => post.Likes)
                .ToList();

            return View("All", allGamePosts);
        }

        [HttpGet("/posts/new")]
        public IActionResult New()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("New");
        }

        [HttpPost("/posts/create")]
        public IActionResult Create(GamePost newGamePost)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid == false)
            {
                // Send back to the page with the form to show errors.
                return View("New");
            }
            // ModelState IS valid...
            newGamePost.UserId = (int)uid;
            db.GamePosts.Add(newGamePost);
            db.SaveChanges();
            return RedirectToAction("All");
        }

        [HttpGet("/posts/{postId}")]
        public IActionResult Details(int postId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            GamePost post = db.GamePosts
            .Include(post => post.Author)
            .Include(post => post.Comments)
            .ThenInclude(comment => comment.CommentAuthor)
            .FirstOrDefault(p => p.GamePostId == postId);

            if (post == null)
            {
                return RedirectToAction("All");
            }

            return View("Details", post);
        }

        [HttpPost("/posts/{postId}")]
        public IActionResult Delete(int postId)
        {
            GamePost post = db.GamePosts.FirstOrDefault(p => p.GamePostId == postId);

            // If post doesn't exist or not author, redirect away.
            if (post == null || post.UserId != uid)
            {
                return RedirectToAction("All");
            }

            db.GamePosts.Remove(post);
            db.SaveChanges();

            return RedirectToAction("All");
        }

        [HttpGet("/posts/{postId}/edit")]
        public IActionResult Edit(int postId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            GamePost post = db.GamePosts.FirstOrDefault(p => p.GamePostId == postId);

            // If post doesn't exist or not author, redirect away.
            if (post == null || post.UserId != uid)
            {
                return RedirectToAction("All");
            }

            return View("Edit", post);
        }

        [HttpPost("/posts/{postId}/update")]
        public IActionResult Update(int postId, GamePost editedPost)
        {
            if (ModelState.IsValid == false)
            {
                editedPost.GamePostId = postId;
                return View("Edit", editedPost);
            }

            GamePost dbPost = db.GamePosts.FirstOrDefault(p => p.GamePostId == postId);

            if (dbPost == null)
            {
                return RedirectToAction("All");
            }

            dbPost.Title = editedPost.Title;
            dbPost.Description = editedPost.Description;
            dbPost.ImgUrl = editedPost.ImgUrl;
            dbPost.UpdatedAt = DateTime.Now;

            db.GamePosts.Update(dbPost);
            db.SaveChanges();

            // Dict matches Details params     new { paramName = paramValue }
            return RedirectToAction("Details", new { postId = dbPost.GamePostId });
        }

        [HttpPost("/{postId}/comments/create")]
        public IActionResult CreateComment(int postId, Comment newComment)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            GamePost post = db.GamePosts.FirstOrDefault(p => p.GamePostId == postId);

            if (ModelState.IsValid == false)
            {
                // Send back to the page with the form to show errors.
                return RedirectToAction("Details", post);
            }
            // ModelState IS valid...
            newComment.UserId = (int)uid;
            newComment.GamePostId = (int)post.GamePostId;
            db.Comments.Add(newComment);
            db.SaveChanges();
            return RedirectToAction("Details", post);
        }

        [HttpPost("/{postId}/comments/delete")]
        public IActionResult CommentDelete(int commentId)
        {
            Comment comment = db.Comments.FirstOrDefault(c => c.CommentId == commentId);

            GamePost post = db.GamePosts.FirstOrDefault(p => p.GamePostId == comment.GamePostId);

            db.Comments.Remove(comment);
            db.SaveChanges();

            return RedirectToAction("Details", post);
        }
    }
}