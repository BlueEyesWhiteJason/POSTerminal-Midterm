using System;
using System.Collections.Generic;

namespace POSTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart run = new Cart();
            //Payment run = new Payment();
            

            /*string answer;
            int a;
            Product p = new Product();
            Console.WriteLine("Hello! Welcome to KMJ Shoe shop");
            List<Product> productList = new List<Product>();
            List<Product> myProductList = p.GetProductsList(productList);
            for (int i = 0; i < myProductList.Count; i++)
            {
                Console.WriteLine($"{i}. " + myProductList[i]);
            }

            Console.WriteLine();

            while (true)
            {
                try
                {
                    Console.WriteLine("Add To Cart");
                    a = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine(myProductList[a]);
                    //Add to cart method

                    Console.WriteLine("Continue? (y/n)");
                    answer = Console.ReadLine().Trim().ToLower();
                    if (answer == "y")
                    {
                        Console.WriteLine("Your cart list");
                        //Display Cart list
                        //Add to cart method
                        continue;
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Your cart list");
                        //Display Cart list
                        //Payment method
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Unkown User input!");
                        Console.WriteLine("Your cart list");
                        //Display Cart list
                        //Add to cart method
                        continue;
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }

            }*/
            //cart run = new cart();


        }
        
    }
}

//subtotal,sales tax, and grand total (rounding issues w math libary will be handy)

// list for storing all selected items (used car examples)

// ask for payment and then direct to jason