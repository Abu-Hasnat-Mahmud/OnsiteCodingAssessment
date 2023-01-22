using To_DO.Models;

namespace To_DO.BLL
{
    public interface IUserBLL
    {
        Task Add(User user);
        Task<User> Update(User user);
    }
}