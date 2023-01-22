using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace To_DO.Models
{
    public class ToDoTask
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public string Description { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }       
        public User User { get; set; }

        [Required]
        public DateTime TaskDate { get; set; }

        public virtual List<ToDoItem> ToDoItems { get; set; }

    }
}
