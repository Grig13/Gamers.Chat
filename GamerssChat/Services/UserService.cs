using GamerssChat.Models;
using GamerssChat.Repositories.Interfaces;

namespace GamerssChat.Services
{
    public class UserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this.userRepository.GetAll();
        }

        public User GetUserById(Guid userId)
        {
            return this.userRepository.GetById(userId);
        }

        public User UserUpdate(User userToUpdate)
        {
            return this.userRepository.Update(userToUpdate);
        }

        public void RemoveUser(Guid userId)
        {
            this.userRepository.DeleteById(userId);
        }
    }
}
