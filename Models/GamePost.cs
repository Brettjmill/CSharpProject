using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharpProject.Models
{
    public class GamePost
    {
        [Key]
        public int GamePostId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be more than 2 characters.")]
        [MaxLength(45, ErrorMessage = "must be more fewer than 2 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be more than 2 characters.")]
        public string Description { get; set; }

        [Display(Name = "Image Url")]
        public string ImgUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* Foreign Keys and Navigation Properties for Relationships */

        // 1 User : Many Post
        public int UserId { get; set; }
        public User Author { get; set; }

        // Many to Many - 1 Post can be liked by many users.
        // public List<UserPostLike> Likes { get; set; }
    }
}