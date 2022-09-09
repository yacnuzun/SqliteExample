// See https://aka.ms/new-console-template for more information
using Entities.Concrete;

namespace ConsoleUI
{
    public class TakeForProcess
    {
        public Product TakeForAdd()
        {
            Product product = new Product();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Barcode:");
            string barcode = Console.ReadLine();
            Console.WriteLine("Quantity:");
            int quantity = int.Parse(Console.ReadLine());

            product.Name = name;
            product.ProductCode = barcode;
            product.Quantity = quantity;
            return product;
        }
        public Product TakeForUpdate()
        {
            Product product = new Product();
            Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Barcode:");
            string barcode = Console.ReadLine();
            Console.WriteLine("Quantity:");
            int quantity = int.Parse(Console.ReadLine());

            product.Id = id;
            product.Name = name;
            product.ProductCode = barcode;
            product.Quantity = quantity;
            return product;
        }
        public int TakeForDelete()
        {
            Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());
            return id;
        }
        public int TakeForGetProduct()
        {
            Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());
            return id;
        }
        public void TakeForProducts()
        {

        }

    }
}
