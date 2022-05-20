using System;

namespace _01_MultipleImplementation
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly Func<string, IShoppingCart> _shoppingCart;
        public ShoppingCartRepository(Func<string, IShoppingCart> shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public object GetCart()
        {
            return _shoppingCart(CartSource.DB.ToString()).GetCart();
        }
    }
}
