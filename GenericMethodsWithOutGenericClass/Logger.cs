﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GenericMethodsWithOutGenericClass
{
    internal class Logger
    {
        public void Log<T>(T message)
        {
            Console.WriteLine(message.ToString());

        }
    }
}
