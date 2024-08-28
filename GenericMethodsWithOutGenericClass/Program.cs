namespace GenericMethodsWithOutGenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log<int>(10);
            logger.Log<string>("Hello World");
            logger.Log(new { Name = "Jonas", Age = 30 ,MYiP= "192 16 800.01"}); 
           

        }
    }
}
