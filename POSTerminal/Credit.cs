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
            
            do
            {
                Console.WriteLine("Please enter your Credit Card Number:");
                ccNum = Console.ReadLine(); //getting exceptions for ints and longs?
                Console.WriteLine(CheckCreditCard(ccNum));
            }
            while (CheckCreditCard(ccNum) == "INVALID");
       

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

        // My own code from a previous project done in C
        public static string CheckCreditCard(string ccNum)
        {
            long number;
            try
            {
                number = long.Parse(ccNum);
            }
            catch (FormatException e)
            {
                return "INVALID";
            }
            
            long digit;
            long sum = 0;
            long part;
            long part_digit;
            long part_part;
            int count = 2; //because we need the first 2 digits to check brand

            // check card brand
            long num2 = number;
            while (num2 > 99)
            {
                num2 /= 10;
                count++; // gets total number of digits
            }


            while (number > 1)
            {
                // digits to be added straight up
                digit = number % 10; //isolate digit
                sum += digit;
                number /= 10;

                // digits to be multiplied by 2
                digit = number % 10; //isolate digit
                part = digit * 2;

                if (part > 9) // need to add the digits of the numbers
                {
                    part_digit = part % 10;
                    part_part = part / 10;
                    part = part_digit + part_part;
                }
                sum += part;
                number /= 10;



                // interpret and print the findings
            }
            if (sum % 10 == 0 && (num2 == 34 || num2 == 37) && count == 15)
            {
                return "AMEX";
            }
            else if (sum % 10 == 0 && (num2 > 50 && num2 < 56) && count == 16)
            {
                return "MASTERCARD";
            }
            else if (sum % 10 == 0 && (num2 > 39 && num2 < 50) && (count == 13 || count == 16))
            {
                return "VISA";
            }
            else
            {
                return "INVALID";
            }
        }
    }
}
