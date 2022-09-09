// See https://aka.ms/new-console-template for more information

namespace ConsoleUI
{
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
                    Console.WriteLine(responseForAdd.Result ? "Ürün Eklendi" : "Bir hata oluştu!");
                    break;
                case "delete":
                    var resultForDelete = _takeForProcess.TakeForDelete();
                    var responseForDelete = crud.Delete(resultForDelete);//Hata kodu dönüyor. Bakılacak!!
                    Console.WriteLine(responseForDelete.Result ? "Ürün Silindi" : "Bir hata oluştu!");
                    break;
                case "update":
                    var resultForUpdate = _takeForProcess.TakeForUpdate();
                    var responseForUpdate = crud.Update(resultForUpdate);
                    Console.WriteLine(responseForUpdate.Result ? "Ürün Güncellendi" : "Bir hata oluştu!");
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
}
