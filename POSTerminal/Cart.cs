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
            Total = quantity*price;
        }

        public Cart()
        {
        }
     
        public override string ToString()
        {
            return $" {Quantity} {Name}  ${Price} ${Total} ";
        }
           
        
       public void DisplayCart(List<Cart> myCart)
        {
            
            for (int i = 0; i < myCart.Count; i++)
            {               
                Console.WriteLine($"{i+1}" +myCart[i]);
                 
            }
            
            
            
        }
        public List<Cart> RemoveShoeFromList(List<Cart> myCartList, int index)
        {
            myCartList.RemoveAt(index);
            return myCartList;
        }

    }
}
