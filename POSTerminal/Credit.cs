using System;
namespace POSTerminal
{
    public class Credit: Payment
    {
        public Credit()
        {
        }

        string ccNum;
        string ExpDate;
        int ccv;
        override public void GetPaymentInfo(double total)
        {
            Console.WriteLine("Please enter your Credit Card Number:");
            ccNum = Console.ReadLine(); //getting exceptions for ints and longs?

            //TODO input validation (REGEX?)
            Console.WriteLine("Please enter the expiration date:");
            ExpDate = Console.ReadLine();

            Console.WriteLine("Please enter the 3-digit CCV on the back of your card:");

            ccv = int.Parse(Console.ReadLine());

        }

        public override void PrintToReceipt(double total)
        {
            Console.WriteLine($"Number: {ccNum}");
            Console.WriteLine($"Exp. Date: {ExpDate}");
            Console.WriteLine($"CCV: {ccv}");
           
        }
    }
}
