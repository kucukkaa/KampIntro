using System;
using System.Linq;

namespace Gun8Odev2EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET 
            //ENTITY FRAMEWORK - ORM - OBJECT RELATIONAL MAPPING ALTERNATİFLER NHIBERNATE, DAPPER


            //GetAll();

            GetProductsByCategory(1);

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var item in northwindContext.Products)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
