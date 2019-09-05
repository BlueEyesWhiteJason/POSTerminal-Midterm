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
                    while (true)
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
                        
                        c.DisplayCart(myCart);
                        //   c.CulateTotalPrice(myCart);                      
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
                                c.CulateTotalPrice(myCart);
                                while (true)
                                {
                                    Console.WriteLine("do you wish to remove any item?(y/n)");
                                    string rm = Console.ReadLine().Trim().ToLower();
                                    if (rm == "y")
                                    {
                                        Console.WriteLine("Enter item number");
                                        int rmv = Convert.ToInt32(Console.ReadLine());
                                        c.RemoveShoeFromList(myCart, rmv);
                                        Console.WriteLine("Cart Details");
                                        c.DisplayCart(myCart);
                                        c.CulateTotalPrice(myCart);
                                        break;
                                    }
                                    if (rm == "n")
                                    {
                                        Console.WriteLine("Cart Details");
                                        c.DisplayCart(myCart);
                                        c.CulateTotalPrice(myCart);
                                        double x = c.CulateTotalPrice(myCart); // total to be passed to payment method                                        
                                        MakePayment(x);


                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong input");
                                        break;
                                    }
                                    Console.ReadLine();
                                    Console.WriteLine();
                                    break;
                                }

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

        public static void MakePayment(double total)
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
            Console.Clear();
            c.GetPaymentInfo(total);
            Console.Clear();

            c.PrintToReceipt(total);

        }
    }
}
