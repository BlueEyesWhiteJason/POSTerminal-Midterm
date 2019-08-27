using System;
namespace POSTerminal
{
    abstract public class Payment
    {
        public Payment()
        {
        }
        abstract public void GetPaymentInfo(double total);
    }
}
