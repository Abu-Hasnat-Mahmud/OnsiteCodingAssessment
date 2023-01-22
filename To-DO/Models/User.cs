using System.ComponentModel.DataAnnotations;

namespace To_DO.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]       
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
