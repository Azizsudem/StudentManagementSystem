using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystemApp.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
