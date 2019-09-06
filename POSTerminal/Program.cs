using System;

using System.Collections.Generic;

namespace POSTerminal
{
    class Program
    {

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
                Console.WriteLine($"{i + 1}. " + myProductList[i]);
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
                    bool cont = true;
                    while (cont)
                    {
                        Console.WriteLine("Choose shoe number to be Added To Cart");
                        Console.WriteLine();
                        input = Console.ReadLine().Trim().ToLower();
                        Console.WriteLine("Enter quantity: ");
                        a = Convert.ToInt32(input) - 1;
                        quantity = Convert.ToInt32(Console.ReadLine());

                        total = quantity * myProductList[a].Price;
                        price += quantity * (myProductList[a].Price); // accessing price of shoe                        
                        myCart.Add(new Cart($"{myProductList[a].Name}", $"{myProductList[a].Description}", $"{myProductList[a].Category}", myProductList[a].Price, quantity));
                        Console.Clear();
                        Console.WriteLine("Your Cart:");
                        c.DisplayCart(myCart);
                        //   c.CulateTotalPrice(myCart);                      
                        bool goodAnswer = false;
                        string response;
                       
                            Console.WriteLine("Would you like to continue shopping? (y/n)");
                            response = Console.ReadLine().Trim().ToLower();
                            if (response == "y")
                            {
                                for (int i = 0; i < myProductList.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. " + myProductList[i]);
                                }

                                break;
                            }
                            else if (response == "n")
                            {
                                Console.Clear();
                                answer = false;
                                Console.WriteLine("Cart Details");
                                c.DisplayCart(myCart);
                                c.CulateTotalPrice(myCart);
                            bool remove = true;
                                while (remove)
                                {
                                    Console.WriteLine("do you wish to remove any item?(y/n)");
                                    string rm = Console.ReadLine().Trim().ToLower();
                                    Console.Clear();
                                    if (rm == "y")
                                    {
                                        Console.WriteLine("Enter item number");
                                        int rmv = Convert.ToInt32(Console.ReadLine());
                                        c.RemoveShoeFromList(myCart, rmv);
                                        Console.WriteLine("Cart Details");
                                        //c.DisplayCart(myCart);
                                        c.CulateTotalPrice(myCart);
                                        break;
                                    }
                                    if (rm == "n")
                                    {
                                       
                                        double x = c.CulateTotalPrice(myCart); // total to be passed to payment method                                        
                                        
                                        PrintReceipt(myCart, MakePayment(x), x);
                                    cont = false;
                                    remove = false;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong input");
                                        break;
                                    }
                                
                                }

                            }
                            else
                            {
                                Console.WriteLine("Unkwown Answer!!!");
                                continue;
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

        public static Payment MakePayment(double total)
        {
            Console.WriteLine("How will you be making your payment today?");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Credit");
            Console.WriteLine("3. Check");
            Payment c;
            while (true)
            {

                try
                {
                    int num = int.Parse(Console.ReadLine()); //TODO int validation
                    if (num == 1)
                    {
                        c = new Cash();
                        break;

                    }
                    else if (num == 2)
                    {
                        c = new Credit();
                        break;


                    }
                    else if (num == 3)
                    {
                        c = new Check();
                        break;
                    }
                    else
                    {
                        Console.Write("Please enter a number from the list: ");
                    }

                }
                catch (FormatException e)
                {
                    Console.Write("Please enter a number from the list: ");
                    continue;
                }

     
            }
            
            c.GetPaymentInfo(total);
            Console.Clear();

            return c;

        }

        public static void PrintReceipt(List<Cart> cart, Payment c, double total)
        {
            Console.WriteLine("SALES RECEIPT");
            Console.WriteLine("______________________________");
            Console.WriteLine("ITEMS PURCHASED");
            cart[0].DisplayCart(cart);
            Console.WriteLine();
            Console.WriteLine("______________________________");
            Console.WriteLine("PAYMENT");

            c.PrintToReceipt(total);
            Console.WriteLine();
            Console.WriteLine("HAVE A NICE DAY!");

        }
    }
}
