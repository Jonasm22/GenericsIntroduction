using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleGeneric
{
    internal class Box_1<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public Box_1(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public void Display()
        {
            Console.WriteLine($"First: {First} second: {Second}");
        }





    }

    
}
