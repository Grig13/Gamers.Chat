using GamerssChat.Models;

namespace GamerssChat.Repositories.Interfaces
{
    public interface ICartRepository
    {
        public IEnumerable<Cart> GetAll();
        public Cart AddProductsToCart(Guid cartId, List<Product> products);
        public Cart AddProductToCart(Guid cartId, Product productToAdd);
        public Cart RemoveProductFromCart(Guid cartId, Product productToRemove);
        public void DeleteById(Guid id);
        public Cart Update(Cart cartToUpdate);
        public Cart GetById(Guid id);

    }
}
