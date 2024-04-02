using System.ComponentModel.DataAnnotations;

namespace UserDb.Models
{
    public class User
    {   
        public int Userid { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
