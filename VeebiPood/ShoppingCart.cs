using System;
using System.Collections.Generic;
using System.Text;

namespace VeebiPood
{
    class ShoppingCart
    {
        List<Item> shoppingCart;
        double total;

        public ShoppingCart()
        {
            shoppingCart = new List<Item>();
            total = 0;
        }
        
        public double Total
        {
            get { return total; }
        }

        public void AddToShoppingCart(Article article, int quantity)
        {
            Item newItem = new Item(article, quantity);
            shoppingCart.Add(newItem);
        }

        public void PrintShoppingCart()
        {
            if(shoppingCart.Count == 0)
            {
                Console.WriteLine("The cart is empty.");
            }
            else
            {
                foreach(Item item in shoppingCart)
            {
                    item.PrintItem();
               // Console.WriteLine($"Total: {item.CalculateItemTotal()}");
            }
            }
            
        }

            public void RemoveFromCart(int id)
            {
                for(int i = 0; i<shoppingCart.Count; i++)
                {
                    if (shoppingCart[i].Article.Id == id)
                    {
                        Console.WriteLine($"{shoppingCart[i].Article.Name} has been removed.");

                        shoppingCart.Remove(shoppingCart[i]);
                    }
                }
            }

        public void ChangQuant(int id)
        {
            for(int i = 0; i < shoppingCart.Count; i++)
            {
                if (shoppingCart[i].Article.Id == id)
                {
                   shoppingCart.Remove(shoppingCart[i]);


                }
            }
        }
        

        //calculate item total
        public void PrintTotal()
        {
            foreach(Item item in shoppingCart)
            {
                total += item.CalculateItemTotal();

            }
            Console.WriteLine($"Total value of shopping cart {total}€");
        }


    }
}
