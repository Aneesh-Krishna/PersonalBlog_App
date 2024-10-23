using System;
using System.ComponentModel.DataAnnotations;
namespace PersonalBlogApp.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }

        public DateTime? DateCreated { get; set; } = DateTime.Now;

        public string AuthorId { get; set; } //Linked to UserId
        public virtual ApplicationUser Author { get; set; }
    }
}
