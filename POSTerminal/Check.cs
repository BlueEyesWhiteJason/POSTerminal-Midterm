using System;
namespace POSTerminal
{
    public class Check: Payment
    {

        
        public Check()
        {
        }


        public override void GetPaymentInfo(double total)
        {
            Console.WriteLine("Please enter the check number:");
            int checkNum = int.Parse(Console.ReadLine());
        }
    }
}
