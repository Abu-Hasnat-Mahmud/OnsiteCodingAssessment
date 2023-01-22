using To_DO.Models;
using To_DO.Repository;

namespace To_DO.BLL
{
    public class UserBLL
    {
        private readonly IUserRepository _userRepository;

        public UserBLL(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Add(User user)
        {
            if (! await _userRepository.IsUserExist(user))
            {
                bool checkSpace = ! user.UserName.Contains(' ');
                bool checkLength = user.UserName.Length > 4;
                bool age18 = Years(user.DateOfBirth , DateTime.UtcNow) >= 18;

                if (checkSpace && checkLength && age18)
                {
                    await _userRepository.Add(user);
                }               
            }
            
        }

        public async Task Update(User user)
        {
            var preUser =await _userRepository.Get(user.UserId);

            preUser.FirstName = user.FirstName;
            preUser.LastName = user.LastName;

            await _userRepository.Update(preUser);
        }

        int Years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }
    }
}
