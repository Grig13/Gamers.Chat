using GamerssChat.Models;
using GamerssChat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamerssChat.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly GamersChatDbContext _dbContext;

        public UserRepository(GamersChatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteById(Guid id)
        {
            var user = GetById(id);
            _dbContext.Set<User>().Remove(user);
            _dbContext.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.Set<User>().Include(a => a.Name).Include(b => b.Role).ToList();
        }

        public User GetById(Guid id)
        {
            var user = _dbContext.Set<User>().Where(a => a.Id == id).FirstOrDefault();
            if(user == null)
            {
                throw new KeyNotFoundException("User not found.");
            }
            return user;
        }

        public User Update(User userToUpdate)
        {
            _dbContext.Set<User>().Update(userToUpdate);
            _dbContext.SaveChanges();
            return userToUpdate;
        }
    }
}
