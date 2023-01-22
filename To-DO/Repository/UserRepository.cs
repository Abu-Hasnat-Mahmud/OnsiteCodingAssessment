using Microsoft.EntityFrameworkCore;
using To_DO.DAL;
using To_DO.Models;

namespace To_DO.Repository
{
    public class UserRepository : IUserRepository, IUserRepository1
    {
        private readonly DBContext _dbContext;

        public UserRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task Add(User user)
        {
            await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Get(int userId)
        {
           await _dbContext.User.FindAsync(userId);           
        }

        public async Task<bool> IsUserExist(User user)
        {
            return await _dbContext.User.AnyAsync(a => a.UserName == user.UserName || a.Email == user.Email);
        }





    }
}
