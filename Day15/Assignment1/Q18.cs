using System;
using System.Collections.Generic;
using System.Linq;
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Product1", Price = 120 },
            new Product { Name = "Product2", Price = 85 },
            new Product { Name = "Product3", Price = 150 },
            new Product { Name = "Product4", Price = 60 },
            new Product { Name = "Product5", Price = 200 }
        };
       
        var filteredProducts = products.Where(p => p.Price > 100).OrderBy(p => p.Price).ToList();
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"{product.Name}:{product.Price}");
        }
    }
}
