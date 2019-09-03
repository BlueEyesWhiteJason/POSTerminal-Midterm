using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSTerminal
{
    public class Product 
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public Product( string name, string description, string category, decimal price)
        {          
            this.Name = name;
            this.Description = description;
            this.Category = category;
            this.Price = price;
        }
        public List<Product> GetProductsList(List<Product> myList)
        {
            myList.Add(new Product("Military Boots", "these are chunky, sturdy boots.", "Womens Boots", 37.99m));
            myList.Add(new Product( "Brogues", "Flat shoe like ballerina.", "Womens Dress Shoes", 60.99m));
            myList.Add(new Product(  "Wellington Boots", "keeping dry or warm.", "Women’s Casual Shoes", 69.99m));
            myList.Add(new Product("Flip Flops", "Beach or pool use.", "Women’s Casual Shoes", 60.99m));
            myList.Add(new Product("Loafer", "Generally slips on, with elasticated panels.", "Women’s Casual Shoes", 55.99m));
            myList.Add(new Product("Mules", "An open backed shoe with a closed front.", "Women’s Casual Shoes", 43.99m));
            myList.Add(new Product("Gladiator sandals", "A strappy sandal, with a T-bar running down the front.", "Women’s Casual Shoes", 25.99m));
            myList.Add(new Product( "Trainers", "Use at the gym, or yoga, as well as for fashion wear.", "Women’s Casual Shoes", 66.99m));
            myList.Add(new Product("Heels", "Heels are an obvious choice for evening or dress wear.", "Womens Dress Shoes", 120.99m));
            myList.Add(new Product( "Court Shoes", "A classic style that work well for a more formal event.", "Womens Dress Shoes", 99.99m));
            myList.Add(new Product("Chelsea Boots", "Flat boots with an elasticated side panel.", "Womens Boots", 65.99m));
            myList.Add(new Product("Ballerinas", "Flat slipper that are an essential item to have in a wardrobe.", "Women’s Casual Shoes", 33.99m));
            return myList;
        }
        public Product()
        {
        }
             public List<Product> RemoveShoeFromList(List<Product> myList, int index)
        {
            myList.RemoveAt(index);
            return myList;
        }
        public override string ToString()
        {
            return $" {Name}  {Description}  {Category}  ${Price}";
        }
              
    }
}
