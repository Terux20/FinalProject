using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //CategoryTest();
            ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetalils();
            if (result.Success == false)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine((product.ProductName+"/"+product.CategoryName));
                }
                    Console.WriteLine(Messages.ProductsListed);
            }
            else
            {
                Console.WriteLine(Messages.ProductNameInvalid);
            }

            //foreach (var product in productManager.GetProductDetalils().Data)
            //{
            //    Console.WriteLine(product.ProductName + "/" + product.ProductName);
            //}
        }
    }
}
