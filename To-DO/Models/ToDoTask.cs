using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace To_DO.Models
{
    public class ToDoTask
    {
        [Key]
        public int TaskId { get; set; }

        public string TaskName { get; set; }
        public string Description { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }       
        public User User { get; set; }

        public DateTime TaskDate { get; set; }

        public bool IsDone { get; set; }
    }
}
