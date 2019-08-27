using System;
using System.Collections.Generic;

namespace POSTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product();
            List<Product> shoes = new List<Product>();
            shoes.Add(p1);
            shoes.Add(p2);

            Console.WriteLine("Hello World heeelo !");

            ShowList(shoes);
            Payment(1000);
        }

        public static void ShowList(List<Product> shoes)
        {    
            for (int i = 0; i < shoes.Count; i++)
            {
                Console.WriteLine($"{i+1}. {shoes[i]}");
            }
        }

        public static void Payment(double total)
        {
            Console.WriteLine("How will you be making your payment today?");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Credit");
            Console.WriteLine("3. Check");   

            while (true)
            {
                int num = int.Parse(Console.ReadLine()); //TODO validation
                if (num == 1)
                {
                    Payment c = new Cash();
                    c.GetPaymentInfo(total);
                    break;
                    
                }
                else if (num == 2)
                {
                    Payment c = new Credit();
                    c.GetPaymentInfo(total);

                    break;


                }
                else if (num == 3)
                {
                    Payment c = new Check();
                    c.GetPaymentInfo(total);

                    break;
                }
                else
                {
                    Console.WriteLine("Please choose the number from the list");
                }
            }
        }
    }
}
