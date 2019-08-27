using System;
namespace POSTerminal
{
    public class Credit: Payment
    {
        public Credit()
        {
        }
        override public void GetPaymentInfo(double total)
        {
            Console.WriteLine("Please enter your Credit Card Number:");
            string ccNum = Console.ReadLine(); //getting exceptions for ints and longs?

            //TODO input validation (REGEX?)
            Console.WriteLine("Please enter the expiration date:");
            string ExpDate = Console.ReadLine();

            Console.WriteLine("Please enter the 3-digit CCV on the back of your card:");

            int ccv = int.Parse(Console.ReadLine());

        }
    }
}
