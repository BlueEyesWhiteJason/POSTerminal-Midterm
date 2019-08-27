using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
   public  class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
         List<Product> productList = new List<Product>();
        public Product(string name, string description, string category, double price)
        {
           this.Name = name;
            this.Description = description;
            this.Category = category;
            this.Price = price;
        }
   
        public  List<Product> RemoveShoeFromList(List<Product> myList, int index)
        {
            myList.RemoveAt(index);
            return myList;
        }
        public override string ToString()
        {
            return $"{Name} {Description} {Category} ${Price}";
        }


    }
}
