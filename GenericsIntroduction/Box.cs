using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntroduction
{
    internal class Box<T>
    {

        private T Content { get; set; }

        public Box(T initialValue)
        {
            Content = initialValue;
        }


        public void UpdateContent(T newContent)
        {
            Content = newContent;

            Console.WriteLine($"Updated content to {Content}");


        }
        public T GetContent()
        {
            return Content; 
        }

    }
}
