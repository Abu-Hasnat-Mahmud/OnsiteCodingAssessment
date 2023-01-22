using Microsoft.EntityFrameworkCore;
using To_DO.DAL;
using To_DO.Models;

namespace To_DO.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DBContext _dbContext;

        public TaskRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task Add(ToDoTask task)
        {
            await _dbContext.AddAsync(task);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(ToDoTask task)
        {
            _dbContext.Update(task);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(ToDoItem toDo)
        {
            _dbContext.Update(toDo);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ToDoTask> Get(int taskId)
        {
            return await _dbContext.ToDoTask.Include(a => a.ToDoItems).FirstOrDefaultAsync(a => a.TaskId == taskId);
        }

        public async Task<ToDoItem> GetToDoItem(int itemId)
        {
            return await _dbContext.ToDoItem.FindAsync(itemId);
        }


        public async Task<List<ToDoTask>> GetUserTask(int userId)
        {
            return await _dbContext.ToDoTask.Include(a => a.ToDoItems).Where(a => a.UserId == userId).ToListAsync();
        }

        public async Task<List<ToDoTask>> FilterToDoItems(int userId, bool complete)
        {
            return await _dbContext.ToDoTask.Include(a => a.ToDoItems.Where(o => o.IsDone == complete))
                .Where(a => a.UserId == userId).ToListAsync();
        }

       
    }
}
