using System;
namespace POSTerminal
{
    public class Cash: Payment
    {
        double change;
        double dosh = -1;
        public Cash()
        {
        }

        public override void GetPaymentInfo(double total)
        {
            Console.WriteLine("How much cash will you be somehow inserting into your computer today?");
      
            while (true)
            {

                try
                {
                    dosh = double.Parse(Console.ReadLine());
                  
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Non-numeric input detected");
                }

                if (dosh < total)
                {
                    Console.WriteLine("Please enter a number equal to or greater than your order total:");
                }
                else
                {
                    break;
                }

      
            }


            change = dosh - total;

         
        }

        public override void PrintToReceipt(double total)
        {
            Console.WriteLine("Total: {0:c}", total);
            Console.WriteLine("Cash tendered: {0:c}", dosh);
            Console.WriteLine("Change owed: {0:c}", change);
        }
    }
}
