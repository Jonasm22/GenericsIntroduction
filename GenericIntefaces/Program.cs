namespace GenericIntefaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public interface IEntity
    {
        int Id { get; }


        public interface IRepository<T> where T : IEntity
        {
            void Add(T entity);
            void Remove(T entity);


        }

        public class Product : IEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }


        public class ProductRepository : IRepository<Product>
        {

            public void Add(Product entity)
            {

            }
            public void Remove(Product entity)
            {


            }

        }
    }
}
