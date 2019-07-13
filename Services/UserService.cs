using MovieApi.Repositories.Interfaces;

namespace MovieApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool UserExists(int id)
        {
            return _userRepository.UserExists(id);
        }
    }
}