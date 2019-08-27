using System;
namespace POSTerminal
{
    public class Check: Payment
    {

        int checkNum;
        int total { get; set; }
        public Check()
        {
        }


        public override void GetPaymentInfo(double total)
        {
            Console.WriteLine("Please enter the check number:");
            checkNum = int.Parse(Console.ReadLine());
        }

        public override void PrintToReceipt(double total)
        {
            Console.WriteLine($"{total} paid by check number {checkNum}");
            
        }
    }
}
