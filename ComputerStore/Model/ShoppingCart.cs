using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStore.Model
{
    public class ShoppingCart
    {
        public List<CartItem> cart;

        public ShoppingCart()
        {
           cart = new List<CartItem>();
        }

        public void Add(CartItem ci)
        {
            foreach (var i in cart)
            {
                if(ci.Id == i.Id)
                {
                    i.Count++;
                }
                else
                {
                    cart.Add(ci);
                }
            }
        }


    }
}
