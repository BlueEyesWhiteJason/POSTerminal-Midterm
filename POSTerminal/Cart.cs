using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Cart : Product
    {
        public int Quantity { get; set; }
        public double Total { get; set; } = 0;
        public Cart( string name, string description, string category, double price, int quantity, double total) : base(name, description, category, price)
        {
            this.Quantity = quantity;
            this.Total = total;
        }

        public Cart()
        {
        }
    
       
        public override string ToString()
        {
            return $" {Name} {Description} {Category} ${Price} {Quantity} ${Total}";
        }
        public virtual List<Cart> AddShoeIntoCartList(List<Cart> myCartList, int index)
        {
           // Total = Price * Quantity;
            myCartList.Add(new Cart( Name , Description, Category,Price,Quantity, Total));
            return myCartList;
        }
        public List<Cart> RemoveShoeFromList(List<Cart> myCartList, int index)
        {
            myCartList.RemoveAt(index);
            return myCartList;
        }

    }
}
