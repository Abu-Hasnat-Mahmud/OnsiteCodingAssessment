using To_DO.Models;

namespace To_DO.BLL
{
    public interface ITaskBLL
    {
        Task Add(ToDoTask task);
        Task<ToDoTask> Update(ToDoTask task);
        Task<ToDoItem> Update(ToDoItem task);
        Task<ToDoItem> ToDoItemsAsDone(ToDoItem task);
        Task<List<ToDoTask>> UserTask(int userId);
        Task<List<ToDoTask>> FilterTask(int userId, bool complete);
    }
}