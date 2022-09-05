using Prg1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2
{
    public class Program
    {
        static void Main(string[] args)
        {
            product prod1 = new product();
            prod1.ProductId = 1;
            prod1.ProductName = "banana";
            prod1.QtySold = 2;
            prod1.UnitofMeasure = "kg";
            prod1.UnitPrice = 150;
            prod1.QtyinHand = 5;
            prod1.ReorderLvl = 10;


            product prod2 = new product();
            prod2.ProductId = 10;
            prod2.ProductName = "Pen";
            prod2.QtySold = 1;
            prod2.UnitofMeasure = "kg";
            prod2.UnitPrice = 10;
            prod2.QtyinHand = 3;
            prod2.ReorderLvl = 7;

            product prod3 = new product();
            prod3.Addproduct();

            List<product> prodlist = new List<product>();
            prodlist.Add(prod1);
            prodlist.Add(prod2);
            prodlist.Add(prod3);

            Console.WriteLine("One category many products ");



            category cat = new category();
            cat.CatId = 17;
            cat.CatName = "Metal";
            cat.Description = "Different types of drinks availble ";
            cat.ProductList = prodlist;


            Console.WriteLine("_______________");
            Console.WriteLine("Category Details:");
            Console.WriteLine("this Category is " + cat.CatName);
            Console.WriteLine("Category ID" + cat.CatId);
            Console.WriteLine("A short description of this category\t " + cat.Description);

            foreach (var item in cat.ProductList)
            {
                Console.WriteLine(item.ProductId);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.QtySold);
                Console.WriteLine(item.UnitPrice);
                Console.WriteLine(item.UnitofMeasure);
                Console.WriteLine(item.QtyinHand);
                Console.WriteLine(item.ReorderLvl);
            }
            Console.ReadKey();


        }
    }
}
