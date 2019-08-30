using System;
using System.Collections.Generic;

namespace POSTerminal
{
    class Program
    {
        public static void Looping()
        {
            bool goodAnswer = false;
            string response;
            while (goodAnswer == false)
            {
                Console.WriteLine("Would you like to continue? (yes/no)");
                response = Console.ReadLine();
                if (response == "yes" || response == "Yes")
                {
                    break;
                }
                else if (response == "no" || response == "No")
                {
                    answer = false;
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Unkwown Answer!!!");
                    continue;
                }
            }
        }
        public static bool answer = true;
        static void Main(string[] args)
        {
            //string answer;
            int a;
            Cart c = new Cart();
            Product p = new Product();
            Console.WriteLine("Hello! Welcome to KMJ Shoe shop");
            List<Product> productList = new List<Product>();
            List<Product> myProductList = p.GetProductsList(productList);
            for (int i = 0; i < myProductList.Count; i++)
            {
                Console.WriteLine($"{i+1}. " + myProductList[i]);
            }
            Console.WriteLine();

            while (answer == true)
            {
                try
                {

                    string input;
                    double price = 0;
                    int quantity = 0;
                    double total = 1;
                    List<Cart> myCart = new List<Cart>();
                    while (true)
                    {
                        Console.WriteLine("Choose shoe number to be Added To Cart");
                        Console.WriteLine();
                        input = Console.ReadLine().Trim().ToLower();
                        Console.WriteLine("Enter quantity: ");
                        a = Convert.ToInt32(input)-1;
                        quantity = Convert.ToInt32(Console.ReadLine());
                        total = quantity * myProductList[a].Price;
                        price += quantity * (myProductList[a].Price); // accessing price of shoe    
                        
                         myCart.Add(new Cart( $"{myProductList[a].Name}", $"{myProductList[a].Description}", $"{myProductList[a].Category}", myProductList[a].Price, quantity));
                        for (int i = 0; i < myCart.Count; i++)
                        {
                            Console.Write(i+1 +". ");
                            Console.Write(myCart[i].Quantity);
                            Console.Write(" " + myCart[i].Name);
                            Console.Write(" x " + myCart[i].Price);
                            Console.WriteLine(" = " + myCart[i].Total);
                        }
                        Console.WriteLine("Your total: $" + price);


                        bool goodAnswer = false;
                        string response;
                        while (goodAnswer == false)
                        {
                            Console.WriteLine("Would you like to continue? (yes/no)");
                            response = Console.ReadLine().Trim().ToLower();
                            if (response == "yes")
                            {
                                break;
                            }
                            else if (response == "no")
                            {
                                answer = false;
                                Console.WriteLine("Cart Details");
                                c.DisplayCart(myCart);
                                
                               Console.WriteLine("Total to be paid: $" + price);

                                Console.ReadLine();
                               
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Unkwown Answer!!!");
                                continue;
                            }
                        }
                        }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }

            }


        }
    }
}
