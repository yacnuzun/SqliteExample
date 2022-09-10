// See https://aka.ms/new-console-template for more information
using Entities.Concrete;
using System.Net.Http.Json;

namespace ConsoleUI
{
    public class Crud
    {
        public static HttpClient client = new HttpClient();
        public async Task<List<Product>> GetAll()
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
            try
            {
                var response = await client.PostAsJsonAsync("http://localhost:5094/api/Products/add", product);
                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public async Task<bool> Update(Product product)
        {
            // IEnumerable<Product> products;
            try
            {
                var response = await client.PostAsJsonAsync("http://localhost:5094/api/Products/update", product);
                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public async Task<bool> Delete(int id)
        {
            // IEnumerable<Product> products;

            try
            {
                var response = await client.GetFromJsonAsync<bool>("http://localhost:5094/api/Products/delete?id=" + id);
                return response;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
