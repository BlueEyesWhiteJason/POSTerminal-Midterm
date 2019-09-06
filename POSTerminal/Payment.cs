using System;
namespace POSTerminal
{
    abstract public class Payment
    {

        abstract public void GetPaymentInfo(double total);

        abstract public void PrintToReceipt(double total);
    }
}
