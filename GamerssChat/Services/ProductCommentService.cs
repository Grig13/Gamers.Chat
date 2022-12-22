using GamerssChat.Models;
using GamerssChat.Repositories.Interfaces;

namespace GamerssChat.Services
{
    public class ProductCommentService
    {
        private readonly IProductCommentRepository pcRepository;

        public ProductCommentService(IProductCommentRepository pcRepository)
        {
            this.pcRepository = pcRepository;
        }

        public IEnumerable<ProductComment> GetAllProductComments()
        {
            return this.pcRepository.GetAll();
        }
        
        public ProductComment GetCommentById(Guid id)
        {
            return this.pcRepository.GetById(id);
        }

        public ProductComment UpdateComment(ProductComment commentToUpdate)
        {
            return this.pcRepository.Update(commentToUpdate);
        }

        public void RemoveComment(Guid id)
        {
            this.pcRepository.DeleteById(id);
        }
    }
}
