using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._25
{
    public class ProductService
    {
        ProductContext db = new ProductContext();

        public void AddProduct(string name)
        {
            var product = new Product { Name = name, Price = getprice() };
            db.Products.Add(product);
            db.SaveChanges();
        }
        public void AddCategory(string name)
        {
            var category = new Category { Name = name };
            db.Categories.Add(category);
            db.SaveChanges();
        }
        public int getprice()
        {
            int i = 0;
            while(true){ 
                Console.WriteLine("Please add a price to the product");
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}