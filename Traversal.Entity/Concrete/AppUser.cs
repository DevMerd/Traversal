using Microsoft.AspNetCore.Identity;

namespace Traversal.Entity.Concrete
{
    public class AppUser : IdentityUser<string>
    {
        public string? ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Gender { get; set; }
    }
}
