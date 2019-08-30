using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public class Cash : Payment
    {
        double change;
        double dosh;
        public Cash()
        {
        }

        public override void GetPaymentInfo(double total)
        {
            Console.WriteLine("How much cash will you be giving us today?");

            dosh = double.Parse(Console.ReadLine());

            change = dosh - total;


        }

        public override void PrintToReceipt(double total)
        {
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Cash tendered: {dosh}");
            Console.WriteLine($"Change owed: {change}");
        }
    }
}
