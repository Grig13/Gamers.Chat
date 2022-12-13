using GamerssChat.Models;

namespace GamerssChat.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();
        public void DeleteById(Guid id);
        public User Update(User userToUpdate);
        public User GetById(Guid id);
    }
}
