using GamerssChat.Models;
using GamerssChat.Repositories.Interfaces;

namespace GamerssChat.Repositories
{
    public class CartRepository : ICartRepository
    {
        public Cart AddProductsToCart(Guid cartId, List<Product> products)
        {
            throw new NotImplementedException();
        }

        public Cart AddProductToCart(Guid cartId, Product productToAdd)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cart GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Cart RemoveProductFromCart(Guid cartId, Product productToRemove)
        {
            throw new NotImplementedException();
        }

        public Cart Update(Cart cartToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
