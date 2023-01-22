using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace To_DO.Models
{
    public class ToDoItem
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public string Name { get; set; }      

       
        public int TaskId { get; set; }
        [ForeignKey("TaskId")]
        public ToDoTask ToDoTask { get; set; }        

        public bool IsDone { get; set; }      
    }
}
