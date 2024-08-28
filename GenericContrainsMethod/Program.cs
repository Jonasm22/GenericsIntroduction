namespace GenericContrainsMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ProductOne = new Product();
            var ProductTwo = new Product();

           var result =  Comparer.AreEqual(ProductOne, ProductTwo);
            Console.WriteLine(result);
        }
    
        public class Product()
        {
            




        }
    
    
    }
}
