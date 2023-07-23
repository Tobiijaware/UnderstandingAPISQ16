using Microsoft.AspNetCore.Identity;

namespace Models
{
    public class User : IdentityUser 
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string Godwin { get; set; }

    }
}