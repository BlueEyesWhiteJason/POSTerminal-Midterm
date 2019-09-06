using System;
namespace POSTerminal
{
    public class Check : Payment
    {
        long checkNum;
        //int total { get; set; }

        public override void GetPaymentInfo(double total)
        {
            Console.WriteLine("Please enter the check number:");
            while (true)
            {
                try
                {
                    checkNum = long.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Number must contain only integers:");
                }
            }
        }
        public override void PrintToReceipt(double total)
        {
            Console.WriteLine($"{total} paid by check number {checkNum}");

        }
    }
}