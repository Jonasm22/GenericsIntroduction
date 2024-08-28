namespace MultipleGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box_1<int,string> box_1 =  new Box_1<int, string> (100 , "One Hundred");
            box_1.Display();
        }
    }
}
