using To_DO.Models;

namespace To_DO.Repository
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task Update(User user);
        Task<User> Get(int userId);
        Task<bool> IsUserExist(User user);
    }
}