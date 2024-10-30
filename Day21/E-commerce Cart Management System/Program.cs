using System;

namespace CartManagemntSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add Item to Cart");
                Console.WriteLine("2. Update Item Quantity");
                Console.WriteLine("3. Remove Item from Cart");
                Console.WriteLine("4. Add Discount");
                Console.WriteLine("5. Calculate Total");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter item name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.Write("Enter price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        cart.AddItem(new CartItem(name, quantity, price));
                        Console.WriteLine("Item added to cart.");
                        break;

                    case "2": 
                        Console.Write("Enter item name to update: ");
                        string updateName = Console.ReadLine();
                        Console.Write("Enter new quantity: ");
                        int newQuantity = int.Parse(Console.ReadLine());
                        cart.UpdateItemQuantity(updateName, newQuantity);
                        Console.WriteLine("Item quantity updated.");
                        break;

                    case "3": 
                        Console.Write("Enter item name to remove: ");
                        string removeName = Console.ReadLine();
                        cart.RemoveItem(removeName);
                        Console.WriteLine("Item removed from cart.");
                        break;

                   case "4": 
                        Console.Write("Enter discount type (percentage/flat): ");
                        string discountType = Console.ReadLine().ToLower();
                        if (discountType == "percentage")
                        {
                            Console.Write("Enter percentage discount: ");
                            decimal percentage = decimal.Parse(Console.ReadLine());
                            cart.AddDiscount(new PercentageDiscount(percentage));
                        }
                        else if (discountType == "flat")
                        {
                            Console.Write("Enter flat discount amount: ");
                            decimal amount = decimal.Parse(Console.ReadLine());
                            cart.AddDis count(new FlatDiscount(amount));
                        }
                        else
                        {
                            Console.WriteLine("Invalid discount type.");
                        }
                        Console.WriteLine("Discount added.");
                        break;

                    case "5": 
                        Console.WriteLine("Total: $" + cart.CalculateTotal());
                        break;

                    case "6": 
                        break;
                }
            }
        }
    }
}
