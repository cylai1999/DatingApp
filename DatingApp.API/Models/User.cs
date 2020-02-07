using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="You must enter password between 4 to 8")]
        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}