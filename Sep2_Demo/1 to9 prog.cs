using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Category[] cs = new Category[2];
            for (int i = 0; i < cs.Length; i++)
            {
                Category c = new Category();
                Console.WriteLine("Enter category ID");
                c.ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Category name");
                c.Name = Console.ReadLine();
                Console.WriteLine("Enter desc");
                c.Desc = Console.ReadLine();
                cs[i] = c;
                List<Products> product = new List<Products>();
                for (int j = 0; j < 2; j++)
                {
                    Products p = new Products();
                    Console.WriteLine("Enter Product Id");
                    p.Productid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product name");
                    p.Productname = Console.ReadLine();
                    p.AddProduct(p.Productid, p.Productname);

                    product.Add(p);
                    cs[i].AddProdut();


                }
                cs[i].prod = product;

            }

            for (int i = 0; i < 2; i++)
            {
                cs[i].Display();
            }
            Console.ReadLine();
        }
    }
}
