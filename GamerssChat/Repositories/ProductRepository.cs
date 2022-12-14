using GamerssChat.Models;
using GamerssChat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamerssChat.Repositories
{
    public class ProductRepository : IProductRepository
    {
        protected readonly GamersChatDbContext _dbContext;

        public ProductRepository(GamersChatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product AddCommentsToProduct(Guid productId, List<ProductComment> comments)
        {
            var product = GetById(productId);
            foreach(var comment in comments)
            {
                product.Comments.Add(comment);
            }
            this._dbContext.SaveChanges();
            return product;
        }

        public Product AddCommentToProduct(Guid productId, ProductComment commentToAdd)
        {
            var product = GetById(productId);
            product.Comments.Add(commentToAdd);
            this._dbContext.SaveChanges();
            return product;
        }

        public void DeleteById(Guid id)
        {
            var product = GetById(id);
            _dbContext.Set<Product>().Remove(product);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbContext.Set<Product>().Include(a => a.Name).Include(b => b.Price).Include(c => c.Description).Include(d => d.Comments).ToList();
        }

        public Product GetById(Guid id)
        {
            var productToReturn = _dbContext.Set<Product>().Where(a => a.Id == id).Include(b => b.Comments).FirstOrDefault();
            if(productToReturn == null)
            {
                throw new KeyNotFoundException("Product not found.");
            }
            return productToReturn;
        }

        public Product RemoveCommentFromProduct(Guid productId, ProductComment commentToRemove)
        {
            var product = GetById(productId);
            product.Comments.Remove(commentToRemove);
            this._dbContext.SaveChanges();
            return product;
        }

        public Product Update(Product productToUpdate)
        {
            _dbContext.Set<Product>().Update(productToUpdate);
            _dbContext.SaveChanges();
            return productToUpdate;
        }
    }
}
