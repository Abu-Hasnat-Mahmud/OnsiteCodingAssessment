using System.Threading.Tasks;
using To_DO.Models;

namespace To_DO.Repository
{
    public interface ITaskRepository
    {
        Task Add(ToDoTask Task);
        Task<ToDoTask> Get(int taskId);
        Task Update(ToDoTask Task);
        Task Update(ToDoItem Task);
        Task<List<ToDoTask>> GetUserTask(int userId);
        Task<List<ToDoTask>> FilterToDoItems(int userId, bool complete);
    }
}