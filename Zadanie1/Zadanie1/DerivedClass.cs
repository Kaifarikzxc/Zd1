﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class DerivedClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Метод, реализованный в классе DerivedClass");
        }
    }
}
