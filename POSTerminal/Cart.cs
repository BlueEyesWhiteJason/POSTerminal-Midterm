using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public class Cart
    {
        
        public Cart()
        {
            /*double SubTotal;
            double SalesTax;
            double GrandTotal;*/
            //SalesTax = SubTotal * .06;

            string answer;
            int a;
            Product p = new Product();
            Console.WriteLine("Hello! Welcome to KMJ Shoe shop");
            List<Product> productList = new List<Product>();
            List<Product> myProductList = p.GetProductsList(productList);
            //have your own cart list
            List<Product> cart = new List<Product>();
            for (int i = 0; i < myProductList.Count; i++)
            {
                Console.WriteLine($"{i}. " + myProductList[i]);
            }

            Console.WriteLine();
            while (true)
         
                try
                {
                    Console.WriteLine("Add To Cart");
                    a = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine(myProductList[a]);
                    //why can't i use my lsit of shoes
                    cart.Add(myProductList[a]);
                    //SubTotal = SubTotal + Convert.ToInt32(myProductList[a,5]);
                        //ask how many of items

                    Console.WriteLine("Continue? (y/n)");
                    answer = Console.ReadLine().Trim().ToLower();
                    if (answer == "y")
                    {
                        Console.WriteLine("Your cart list");
                        for (int i = 0; i < cart.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. " + cart[i]);
                        }
                        
                        continue;
                    }
                    else if (answer == "n")
                    {
                        if (cart.Count == 0)
                        {
                            Console.WriteLine("Your cart is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Your cart list");
                            for (int i = 0; i < cart.Count; i++)
                            {
                                Console.WriteLine($"{i+1}. " + cart[i]);
                            }
                            //Payment method
                        }


                        break;
                    }
                    else
                    {
                        Console.WriteLine("Unkown User input!");
                        Console.WriteLine("Your cart list");
                        //Display Cart list
                        //Add to cart method
                        continue;
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    continue;
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



    }

