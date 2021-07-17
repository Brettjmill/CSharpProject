using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace CSharpProject.Controllers
{
    public class HomeController : Controller
    {
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }
        private CSharpProjectContext db;
        public HomeController(CSharpProjectContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
            {
                return RedirectToAction("Dashboard");
            }

            return View("Index");
        }

        [HttpPost("/register")]
        public IActionResult SubmitRegistration(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(db.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "is taken.");
                }
            }

            if(ModelState.IsValid == false)
            {
                return View("Index");
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("Name", newUser.Name);

            return RedirectToAction("Dashboard");
        }

        [HttpPost("/login")]
        public IActionResult Login(LoginUser loginUser)
        {
            if(ModelState.IsValid == false)
            {
                return View("Index");
            }

            User dbUser = db.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);

            if(dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", "Invalid email/password.");
                return View("Index");
            }

            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();

            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);

            if(pwCompareResult == 0)
            {
                ModelState.AddModelError("LoginEmail", "Invalid email/password.");
                return View("Index");
            }

            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            HttpContext.Session.SetString("Name", dbUser.Name);

            return RedirectToAction("Dashboard");
        }

        [HttpPost("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }

            return View("Dashboard");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
