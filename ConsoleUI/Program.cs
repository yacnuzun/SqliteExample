// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
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
}
