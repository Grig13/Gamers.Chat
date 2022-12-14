using GamerssChat.Models;

namespace GamerssChat.Repositories.Interfaces
{
    public interface IPostCommentRepository
    {
        public IEnumerable<PostComment> GetAll();
        public void DeleteById(Guid id);
        public PostComment Update(PostComment commentToUpdate);
        public PostComment GetById(Guid id);
    }
}
