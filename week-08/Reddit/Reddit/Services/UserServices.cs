using Reddit.Repositories;

namespace Reddit.Services
{
    public class UserServices
    {
        private UserRepository userRepository;

        public UserServices(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool UserStatus(string username)
        {
            return userRepository.UserStatus(username);
        }

        public void AddUser(string username)
        {
            userRepository.AddUser(username);
        }
    }
}
