using System.Security.Cryptography.X509Certificates;

namespace GenericsIntroduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
             
            Box<string> boxSt = new Box<string>("Hello world");
            Console.WriteLine(boxSt.GetContent());
            boxSt.UpdateContent("Teaching C# is fun");
            Console.WriteLine(boxSt.GetContent());
      



        }
    }
}
