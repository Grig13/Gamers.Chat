using GamerssChat.Models;

namespace GamerssChat.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAll();
        public Product AddCommentsToProduct(Guid productId, List<ProductComment> comments);
        public Product AddCommentToProduct(Guid productId, ProductComment commentToAdd);
        public Product RemoveCommentFromProduct(Guid productId, ProductComment commentToRemove);
        public void DeleteById(Guid id);
        public Product Update(Product productToUpdate);
        public Product GetById(Guid id);
    }
}
