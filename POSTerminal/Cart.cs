using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSTerminal
{
    public class Cart : Product
    {
        public int Quantity { get; set; }
        public double Total { get; set; } = 0;
        public Cart(string name, string description, string category, double price, int quantity) : base(name, description, category, price)
        {
            this.Quantity = quantity;
            Total = quantity * price;
        }

        public Cart()
        {
        }

        public override string ToString()
        {
            return $" {Quantity} {Name}  ${Price} ${Total} ";
        }

        public double CulateTotalPrice(List<Cart> myCart)
        {

            double totalPrice = 0;
            
            foreach (var product in myCart)
            {
                totalPrice += product.Total;
            }

            double salesTax = totalPrice * 0.06;
            double grandTotal = totalPrice - salesTax;
            Console.WriteLine("Subtotal: {0:c}", totalPrice);
            Console.WriteLine("Total sales Tax: {0:c}", salesTax);
            Console.WriteLine("Grand Total {0:c}", grandTotal);
            return grandTotal;
        }
        public void DisplayCart(List<Cart> myCart)
        {

            for (int i = 0; i < myCart.Count; i++)
            {
                Console.WriteLine($"{i + 1}" + myCart[i]);

            }
        }
        public List<Cart> RemoveShoeFromList(List<Cart> myCartList, int index)
        {
            myCartList.RemoveAt(index - 1);
            return myCartList;
        }

    }
}