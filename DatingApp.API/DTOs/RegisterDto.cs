using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}