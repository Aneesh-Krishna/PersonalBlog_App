using Microsoft.AspNetCore.Identity;
namespace PersonalBlogApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FullName { get; set; }
        public string? Bio { get; set; }
    }
}
