using System;
using System.Collections.Generic;

namespace POSTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello! Welcome to KMJ Shoe shop");
            List<Product> productList = new List<Product>();

            productList.Add(new Product("Sneakers", "Sport use", "Sports", 37.99));
            productList.Add(new Product("Mens Boot", "Summer use", "Hicking", 60.99));
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"{i}. " + productList[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Here is Our Shoes ");
          

        }
    }
}
