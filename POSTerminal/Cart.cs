using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public class Cart
    {
        public double SubTotal { get; set; }
        public double SalesTax { get; set; }
        public double total { get; set; }
       
        public int Quantity { get; set; }


        public Cart()

        {
            



            string answer;
            int a;
            Product p = new Product();
            Console.WriteLine("Hello! Welcome to The KMJ Shoe Shack. Please, take a gander.");
            List<Product> productList = new List<Product>();
            List<Product> myProductList = p.GetProductsList(productList);
            //have your own cart list
            List<Product> cart = new List<Product>();
            for (int i = 1; i < myProductList.Count; i++)
            {
                Console.WriteLine($"{i}. " + myProductList[i].Name + " " + myProductList[i].Description + " " + myProductList[i].Category + " "+myProductList[i].Price);
               
            }

            Console.WriteLine();

            bool cont = true;
            while (cont)
            {//change output to not show quantity
                //declare someplace if quantity >1 then quantity * mrPRoductList[a].Price
                // change quantity and display only in cart

                try
                {
                    Console.WriteLine("Which shoes would you like? I think they'd all suit you. (enter a number 1-11)");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(myProductList[a].Name + " " + myProductList[a].Description + " " + myProductList[a].Category + " $" + myProductList[a].Price);

                    Console.WriteLine("How many pairs do you want?");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    if (quantity == 1)
                    {
                        Console.WriteLine("Perfect! We've got one pair for you right here.");
                        Console.WriteLine($"" + quantity + "x " + (myProductList[a]).Name + " x " + (myProductList[a]).Price + " = " + ((myProductList[a]).Price * quantity));
                    }
                    else if (quantity > 1)
                    {
                        Console.WriteLine("Fantastic, we've got those pairs for you right here.");
                        Console.WriteLine($"" + quantity + "x " + (myProductList[a]).Name + " x " + (myProductList[a]).Price + " = " + ((myProductList[a]).Price * quantity));
                        (myProductList[a]).Quantity = quantity;
                        (myProductList[a]).Price = (myProductList[a]).Price * quantity;
                    }
                    else
                    {
                        Console.WriteLine("error message because they put in zero");
                    }

                    Console.WriteLine("Would you like to add these to your cart? (y/n)");
                    answer = Console.ReadLine().Trim().ToLower();
                    if (answer == "y")
                    {
                        cart.Add(myProductList[a]);

                        SubTotal = SubTotal + (myProductList[a].Price);
                        Console.WriteLine("Here's your current cart:");

                        for (int i = 0; i < cart.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. " + " x" + cart[i].Quantity + " " + (cart[i]).Name + " $" + cart[i].Price);
                        }

                        Console.WriteLine("\nYour current subtotal is: $" + SubTotal);

                    }
                    else if (answer == "n")
                    {
                        if (cart.Count == 0)
                        {
                            Console.WriteLine("Your cart is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Here's your current cart:");
                            for (int i = 0; i < cart.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. " + " x" + cart[i].Quantity + " " + (cart[i]).Name + " $" + cart[i].Price);
                            }
                            Console.WriteLine("\nYour current subtotal is: " + SubTotal);

                        }



                    }
                    else
                    {
                        Console.WriteLine("Unkown User input!");
                        Console.WriteLine("Here's your current cart:");
                        for (int i = 0; i < cart.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. " + " x" + cart[i].Quantity + " " + (cart[i]).Name + " $" + cart[i].Price);
                        }
                        Console.WriteLine("\nYour current subtotal is: $" + SubTotal);
                        
                    }

                }

                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    //continue;
                }

                
                Console.WriteLine("\nWould you like to keep looking? (enter y/n):");
                string option = Console.ReadLine();

                if (option == "y")
                {
                    cont = true;
                }
                else if (option == "n")
                {
                    Console.WriteLine("Here's your current cart:");
                    for (int i = 0; i < cart.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. " + " x" + cart[i].Quantity + " " + (cart[i]).Name + " $" + cart[i].Price);
                    }
                    cont = false;
                    SalesTax = SubTotal * .06;
                    total = SubTotal + SalesTax;
                    Console.WriteLine($"\nSubtotal: $" + SubTotal.ToString("#.##"));
                    Console.WriteLine($"Sales Tax: $" + SalesTax.ToString("#.##"));
                    Console.WriteLine($"Grand Total: $" + total.ToString("0.##"));

                }

            }
            Payment(total);

        }
        public static void Payment(double total)
        {
            Console.WriteLine("\nHow will you be making your payment today?");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Credit");
            Console.WriteLine("3. Check");
            Payment c;
            while (true)
            {

                int num = int.Parse(Console.ReadLine()); //TODO int validation



                if (num == 1)
                {
                    c = new Cash();
                    break;

                }
                else if (num == 2)
                {
                    c = new Credit();
                    break;


                }
                else if (num == 3)
                {
                    c = new Check();
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose a number from the list: ");
                }

            }
            c.GetPaymentInfo(total);
            c.PrintToReceipt(total);
        }
    }
}

        
        
        // ALTERNATE METHOD

        //List<Cart> items = new List<Cart>();
        /*public void AddProduct(Product i)
        {
            items.Add(i);
        }*/

        /*public void DeleteProduct(Product item)
        {
            items
        }*/
        
    // make sure you have a remove from list method

        /*public List<Product> RemoveShoeFromList(List<Product> myList, int index)
        {
            myList.RemoveAt(index);
            return myList;
        }
        public void ShowList(List<Product> shoes)
        {
            for (int i = 0; i < shoes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {shoes[i]}");
            }
        }*/



    

