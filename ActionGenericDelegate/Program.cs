namespace ActionGenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FuncLect.Example3();

            PredicatesLecture.Example5();

        }




        public class ActionsLect()
        {
            public static void Example1()
            {
                Action action = () =>
                {
                    Console.WriteLine("Hello World");
                };
                action();

            }

        }

        public class FuncLect()
        {
            public static void Example2()
            {
                Func<string> getName = () =>
                {
                    return "Jonas";

                };


                var MyName = getName();
                Console.WriteLine(MyName);
            }


            public static void Example3()
            {
                Func<int, int, string> sum = (x, y) =>
                {
                    return (x + y).ToString();
                };
                Console.WriteLine(sum(3, 5));
            }




        }

        public class PredicatesLecture
        {
            public static void Example4()
            {
                Predicate<int> isEven = (x) =>
                {
                    return x % 2 == 0;
                };

                Console.WriteLine(isEven(5));

                List<int> numeros = new List<int> { 1, 2, 3, 4, 5 ,6 , 8};

                var eventsInts = numeros.FindAll(isEven);

            }    
            public static void Example5()
            {
                List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

                // Predicado para verificar si un número es par
                Predicate<int> esPar = numero => numero % 2 == 0;

                // Encontrar el primer número par (sin LINQ)
                int primerPar = Array.Find(numeros.ToArray(), esPar);
                Console.WriteLine("El primer número par es: " + primerPar);


            }

        }
    }
}
