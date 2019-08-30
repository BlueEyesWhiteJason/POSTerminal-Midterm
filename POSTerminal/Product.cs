using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSTerminal
{
    public class Product
    {
        public int ProductNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public Product(int productNumber, string name, string description, string category, double price)
        {
            this.ProductNumber = productNumber;
            this.Name = name;
            this.Description = description;
            this.Category = category;
            this.Price = price;
        }
        public List<Product> GetProductsList(List<Product> myList)
        {
            myList.Add(new Product(ProductNumber = 45, Name = "Military Boots", "these are chunky, sturdy boots.", "Womens Boots", 37.99));
            myList.Add(new Product(ProductNumber = 53, Name = "Brogues", "Flat shoe like ballerina.", "Womens Dress Shoes", 60.99));
            myList.Add(new Product(ProductNumber = 35, Name = "Wellington Boots", "keeping dry or warm.", "Women’s Casual Shoes", 69.99));
            myList.Add(new Product(ProductNumber = 39, Name = "Flip Flops", "Beach or pool use.", "Women’s Casual Shoes", 60.99));
            myList.Add(new Product(ProductNumber = 32, Name = "Loafer", "Generally slips on, with elasticated panels.", "Women’s Casual Shoes", 55.99));
            myList.Add(new Product(ProductNumber = 30, Name = "Mules", "An open backed shoe with a closed front.", "Women’s Casual Shoes", 43.99));
            myList.Add(new Product(ProductNumber = 23, Name = "Gladiator sandals", "A strappy sandal, with a T-bar running down the front.", "Women’s Casual Shoes", 25.99));
            myList.Add(new Product(ProductNumber = 51, Name = "Trainers", "Use at the gym, or yoga, as well as for fashion wear.", "Women’s Casual Shoes", 66.99));
            myList.Add(new Product(ProductNumber = 47, Name = "Heels", "Heels are an obvious choice for evening or dress wear.", "Womens Dress Shoes", 120.99));
            myList.Add(new Product(ProductNumber = 15, Name = "Court Shoes", "A classic style that work well for a more formal event.", "Womens Dress Shoes", 99.99));
            myList.Add(new Product(ProductNumber = 30, Name = "Chelsea Boots", "Flat boots with an elasticated side panel.", "Womens Boots", 65.99));
            myList.Add(new Product(ProductNumber = 23, Name = "Ballerinas", "Flat slipper that are an essential item to have in a wardrobe.", "Women’s Casual Shoes", 33.99));
            return myList;
        }
        public Product()
        {
        }
        /*public List<Product> RemoveShoeFromList(List<Product> myList, int index)
        {
            myList.RemoveAt(index);
            return myList;
        }*/
        public override string ToString()
        {
            return $"{ProductNumber}  {Name}  {Description}  {Category}  ${Price}";
        }

    }
}