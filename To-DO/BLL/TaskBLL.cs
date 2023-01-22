using To_DO.Models;
using To_DO.Repository;

namespace To_DO.BLL
{
    public class TaskBLL : ITaskBLL
    {
        private readonly ITaskRepository _taskRepository;

        public TaskBLL(ITaskRepository TaskRepository)
        {
            _taskRepository = TaskRepository;
        }

        public async Task Add(ToDoTask task)
        {
            await _taskRepository.Add(task);
        }

        public async Task<ToDoTask> Update(ToDoTask task)
        {
            var preTask = await _taskRepository.Get(task.TaskId);


            await _taskRepository.Update(preTask);

            return preTask;
        }

        public async Task<ToDoItem> Update(ToDoItem item)
        {
            await _taskRepository.Update(item);

            return item;
        }
        public async Task<ToDoItem> ToDoItemsAsDone(ToDoItem item)
        {
            item.IsDone = true;
            await _taskRepository.Update(item);

            return item;
        }

        public async Task<List<ToDoTask>> UserTask(int userId)
        {
            return await _taskRepository.GetUserTask(userId);
        }

        public async Task<List<ToDoTask>> FilterTask(int userId, bool complete)
        {
            return await _taskRepository.FilterToDoItems(userId, complete);
        }


    }
}
