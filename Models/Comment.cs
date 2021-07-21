using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharpProject.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be more than 2 characters.")]
        [MaxLength(100, ErrorMessage = "must be fewer than 100 characters.")]
        public string Body { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* Foreign Keys and Navigation Properties for Relationships */

        // 1 User : Many Post
        public int UserId { get; set; }
        public User CommentAuthor { get; set; }
        public int GamePostId { get; set; }
        public GamePost CommentPost { get; set; }
    }
}