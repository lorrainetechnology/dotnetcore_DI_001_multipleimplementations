﻿namespace _01_MultipleImplementation
{
    public class ShoppingCartDB : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded from DB";
        }
    }
}
