using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class AppUser : IdentityUser
    {   
        // Common user properties
        public string FullName { get; set; } = string.Empty;
        public string? ProfilePictureUrl { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime? LastLogin { get; set; }
        public bool IsDeleted { get; set; } = false;
        
        // User type
        public UserType UserType { get; set; }
        
        // Navigation properties
        public virtual SuperAdmin? SuperAdmin { get; set; }
        public virtual Admin? Admin { get; set; }
        public virtual Driver? Driver { get; set; }
        public virtual Passenger? Passenger { get; set; }
    }
}