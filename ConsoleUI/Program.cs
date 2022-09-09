// See https://aka.ms/new-console-template for more information
using Entities.Concrete;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleUI
{
    class Program
    {

        static async Task Main(string[] args)
        {

            Selector selector = new Selector();
            while (true)
            {
                string answerUser = Question.GiveQuestion();
                selector.ChoiseSelector(answerUser);
            }

            //  program.GetAll();
        }
    }
    public static class Question
    {
        public static string GiveQuestion()
        {
            Console.WriteLine("What is your process?");
            Console.WriteLine("GetProducts");
            Console.WriteLine("GetProduct");
            Console.WriteLine("Add");
            Console.WriteLine("Update");
            Console.WriteLine("Delete");
            return Console.ReadLine();
        }
    }
    public class Crud
    {
        public static HttpClient client = new HttpClient();
        public async Task<List<Product>> GetAll() // Geliyorum şimdi arıyom la
        {
            // IEnumerable<Product> products;

            var response = await client.GetFromJsonAsync<List<Product>>("http://localhost:5094/api/Products/getall");
            return response;
        }
        public async Task<Product> Get(int id)
        {
            // IEnumerable<Product> products;


            var response = await client.GetFromJsonAsync<Product>("http://localhost:5094/api/Products/get?id=" + id);
            return response;
        }
        public async Task<bool> Add(Product product)
        {
            // IEnumerable<Product> products;


            var response = await client.PostAsJsonAsync("http://localhost:5094/api/Products/add", product);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> Update(Product product)
        {
            // IEnumerable<Product> products;


            var response = await client.PostAsJsonAsync("http://localhost:5094/api/Products/update", product);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> Delete(int id)
        {
            // IEnumerable<Product> products;


            var response = await client.GetFromJsonAsync<bool>("http://localhost:5094/api/Products/delete?id=" + id);
            return response;
        }
    }
    public class Selector
    {
        TakeForProcess _takeForProcess = new TakeForProcess();

        public void ChoiseSelector(string answer)
        {
            Crud crud = new Crud();
            answer = answer.ToLower();
            switch (answer)
            {
                case "add":
                    var resultForAdd = _takeForProcess.TakeForAdd();
                    var responseForAdd = crud.Add(resultForAdd);
                    Console.WriteLine(responseForAdd.Result.ToString());
                    break;
                case "delete":
                    var resultForDelete = _takeForProcess.TakeForDelete();
                    var responseForDelete = crud.Delete(resultForDelete);
                    Console.WriteLine(responseForDelete.Result);
                    break;
                case "update":
                    var resultForUpdate = _takeForProcess.TakeForUpdate();
                    var responseForUpdate = crud.Update(resultForUpdate);
                    Console.WriteLine(responseForUpdate.Result.ToString());
                    break;
                case "getproduct":
                    var resultForGetProduct = _takeForProcess.TakeForGetProduct();
                    var responseForGetProduct = crud.Get(resultForGetProduct).Result;
                    Console.WriteLine(responseForGetProduct.ProductCode);
                    Console.WriteLine(responseForGetProduct.Name);
                    Console.WriteLine(responseForGetProduct.Quantity);
                    break;
                case "getproducts":
                    var responseForGetProducts = crud.GetAll();
                    foreach (var item in responseForGetProducts.Result)
                    {
                        Console.WriteLine(item.Id);
                        Console.WriteLine(item.ProductCode);
                        Console.WriteLine(item.Name);
                        Console.WriteLine(item.Quantity);
                        Console.WriteLine("=========================");
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    Question.GiveQuestion();
                    break;

            }

        }
    }
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
