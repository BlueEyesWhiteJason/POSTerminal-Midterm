using System;
using System.Collections.Generic;

namespace POSTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Payment(49.95);

            
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
            Payment c;
            while (true)
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
                    Console.WriteLine("Please choose a number from the list: ");
                }
     
            }
            c.GetPaymentInfo(total);
            c.PrintToReceipt(total);
        }
    }
}
