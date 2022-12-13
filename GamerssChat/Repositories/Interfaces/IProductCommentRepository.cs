using GamerssChat.Models;

namespace GamerssChat.Repositories.Interfaces
{
    public interface IProductCommentRepository
    {
        public IEnumerable<ProductComment> GetAll();
        public void DeleteById(Guid id);
        public ProductComment Update(ProductComment commentToUpdate);
        public ProductComment GetById(Guid id);
    }
}
