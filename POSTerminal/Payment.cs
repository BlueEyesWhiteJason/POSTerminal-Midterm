using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    abstract public class Payment
    {
        public Payment()
        {
        }
        abstract public void GetPaymentInfo(double total);

        abstract public void PrintToReceipt(double total);
    }
}
