// See https://aka.ms/new-console-template for more information

namespace ConsoleUI
{
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
}
