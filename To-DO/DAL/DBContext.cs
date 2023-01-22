using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using To_DO.Models;

namespace To_DO.DAL
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<ToDoTask> ToDoTask { get; set; }
        public DbSet<ToDoItem> ToDoItem { get; set; }
       
    }
}
