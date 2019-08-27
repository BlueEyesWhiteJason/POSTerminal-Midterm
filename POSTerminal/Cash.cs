using System;
namespace POSTerminal
{
    public class Cash: Payment
    {
        public Cash()
        {
        }

        public override void GetPaymentInfo(double total)
        {
            Console.WriteLine("How much cash will you be giving us today?");

            double dosh = double.Parse(Console.ReadLine());

            double change = dosh - total;

            //TODO format change output
            Console.WriteLine($"Your change today is {change}");
            
        }
    }
}
