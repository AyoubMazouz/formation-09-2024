using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Identity.Client;

namespace formation.Models;

    public class User
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }

        public bool IsActive { get; set; }
        public bool PasswordExpired { get; set; }
        public bool IsBlocked { get; set; }

}

    