using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSTerminal
{
    public class Cart : Product
    {       
        public int Quantity { get; set; }
        public decimal Total { get; set; } = 0;
        public Cart(string name, string description, string category, decimal price, int quantity) : base(name, description, category, price)
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

        public void CulateTotalPrice(List<Cart> myCart)
        {
            var totalPrice = 0m;
            foreach (var product in myCart)
            {
                totalPrice += product.Total;
            }
            
            Console.Write("Total to be paid: ");
            Console.WriteLine("{0:c}", totalPrice);
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
            myCartList.RemoveAt(index-1);
            return myCartList;
        }

    }
}