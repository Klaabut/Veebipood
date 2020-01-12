using System;
using System.Text;

namespace VeebiPood
{

    enum Category
    {
        PASTRY,
        DAIRY,
        SWEETS,
        CANNED_FOOD,
        MEAT,
        FISH,
        FRUIT,
        VEGETABLES,
        TOILETRIES,
        BEWERAGES

    }

    class Program
    {
        static void Main(string[] args)
        {//Create a warehouse object
            WareHouse currentlyInStock = new WareHouse();
            //Create a shopping cart object
            ShoppingCart shoppingCart = new ShoppingCart();
            //display warehouse content
            currentlyInStock.PrintInStock();

            
            bool needForList = true;
            AddItemsToShoppingCart(currentlyInStock, shoppingCart);
            while (needForList == true)
            {

                //show cart total
                Console.WriteLine();
                shoppingCart.PrintTotal();
                Console.WriteLine();

                Console.WriteLine("Add/Remove/Change Quantity/quit");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "add")
                {
                    AddItemsToShoppingCart(currentlyInStock, shoppingCart);

                    needForList = true;
                    continue;
                }
                else if (answer.ToLower() == "remove")
                {
                    shoppingCart.PrintShoppingCart();
                    Console.WriteLine("Write the id of the item you want to remove");
                    int ItemIdToRemove = int.Parse(Console.ReadLine());
                    shoppingCart.RemoveFromCart(ItemIdToRemove);
                        shoppingCart.PrintShoppingCart();
                   // ShoppingCart RemoveFromCart();
                }
                else if(answer.ToLower() == "change quantity")
                {
                    shoppingCart.PrintShoppingCart();
                    Console.WriteLine("Write the id of the item which's quantity you want to change:");
                    int ItemIdToChangeQuant = int.Parse(Console.ReadLine());
                    shoppingCart.ChangQuant(ItemIdToChangeQuant);
                    ChangeQuantity(currentlyInStock, shoppingCart, ItemIdToChangeQuant);
                    shoppingCart.PrintShoppingCart();
                }
                else if(answer.ToLower() == "quit")
                {
                    break;
                }

            }




            Console.ReadLine();
        }


        public static void AddItemsToShoppingCart(WareHouse currentlyInStock, ShoppingCart shoppingCart)
        {
            Console.WriteLine("Enter the id of the product to add it to the cart:");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items to add to cart:");
            int quantity = int.Parse(Console.ReadLine());

            Article articleToAdd = currentlyInStock.GetFromStock(productID);
            shoppingCart.AddToShoppingCart(articleToAdd, quantity);
            shoppingCart.PrintShoppingCart();
        }

        public static void ChangeQuantity(WareHouse currentlyInStock, ShoppingCart shoppingCart, int ItemIdToChangeQuant)
        {

            
            Console.WriteLine("Enter the new quantity:");
            int quantity = int.Parse(Console.ReadLine());



            Article articleToAdd = currentlyInStock.GetFromStock(ItemIdToChangeQuant);
            shoppingCart.AddToShoppingCart(articleToAdd, quantity);
            Console.WriteLine("This is your current shopping cart.");
            shoppingCart.PrintShoppingCart();
        }
    }
}
