﻿namespace _01_MultipleImplementation
{
    public class ShoppingCartAPI : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded through API.";
        }
    }
}
