using GamerssChat.Models;
using GamerssChat.Repositories.Interfaces;

namespace GamerssChat.Services
{
    public class PostCommentService
    {
        private readonly IPostCommentRepository pcRepository;

        public PostCommentService(IPostCommentRepository pcRepository)
        {
            this.pcRepository = pcRepository;
        }

        public IEnumerable<PostComment> GetAllComments()
        {
            return this.pcRepository.GetAll();
        }

        public PostComment GetCommentById(Guid postId)
        {
            return this.pcRepository.GetById(postId);
        }

        public PostComment UpdateComment(PostComment commentToUpdate)
        {
            return this.pcRepository.Update(commentToUpdate);
        }

        public void DeleteComment(Guid commentId)
        {
            this.pcRepository.DeleteById(commentId);
        }
    }
}
