using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public class Check : Payment
    {

        int checkNum;
        //int total { get; set; }
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
