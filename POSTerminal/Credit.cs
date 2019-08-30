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
                Console.WriteLine(CheckCreditCardNum(ccNum));
            }
            while (CheckCreditCardNum(ccNum) == "INVALID");


            //TODO input validation (REGEX?)

            //Console.WriteLine("Please enter the expiration date (integers:");
            //while (!int.TryParse(Console.ReadLine(), out ExpDate))
            //{
            //    Console.WriteLine("Invalid Format!");
            //    Console.WriteLine("Please use the format MMYY with only integers:");
            //}


            do
            {
                Console.WriteLine("Expiration Date:");
                ExpDate = Console.ReadLine(); 
                Console.WriteLine(CheckCCExp(ExpDate));
            }
            while (CheckCCExp(ExpDate) == "Credit Card Expired" || CheckCCExp(ExpDate) == "Invalid, use numerical format MMYY");






            Console.WriteLine("Please enter the 3-digit CCV on the back of your card:");
           
            bool validIn = false;
            string ccvIn;
            while (!validIn)
            {
                // validIn = true;
                ccvIn = Console.ReadLine().Trim();


                try
                {
                    ccv = int.Parse(ccvIn);

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("Please enter your 3-digit CCV");
                    validIn = false;
                    continue;
                }
                if (ccvIn.Length != 3)
                {
                    Console.WriteLine("Input must be 3 digits:");
                    validIn = false;
                    continue;
                }
                validIn = true;



            }

        }

        public override void PrintToReceipt(double total)
        {
            Console.WriteLine($"Number: {ccNum}");
            Console.WriteLine($"Exp. Date: {ExpDate}");
            Console.WriteLine($"CCV: {ccv}");
           
        }

        public static string CheckCCExp(string ExpDate)
        {
            string expIn = ExpDate;
            char[] month = new char[2];
            char[] year = new char[2];

            if (expIn.Length != 4)
            {
                return "Invalid, use numerical format MMYY";
            }

            

            month[0] = expIn[0]; month[1] = expIn[1]; year[0] = expIn[2]; year[1] = expIn[3];
            try
            {
                int a = 10 * (month[0] - '0');
                int b = (month[1] - '0');
                int c = 10 * (year[0] - '0');
                int d = year[1] - '0';

                int mo = a + b;
                
                int yr = c + d;

                if (mo < 1 || mo > 12 || yr < 00)
                {
                    return "Invalid, use numerical format MMYY";
                }

                if (yr < 19)
                {
                    return "Credit Card Expired";
                }

                if (yr == 19 && mo < 8)
                {
                    return "Credit Card Expired";
                }

                return "";

            }
            catch (FormatException e)
            {
                return "Invalid, use numerical format MMYY";
            }
 
        }



        // My own code from a previous project done in C
        public static string CheckCreditCardNum(string ccNum)
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
