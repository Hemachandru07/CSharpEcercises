using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthConsoleApp
{

    class cal : ICalculator
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        
    }
    class cal1 : ICalculator
    {
        public void add(int a, int b)
        {
            Console.WriteLine("Sum is : "+(a+b));
        }

        public void div(int a, int b)
        {
            Console.WriteLine("Division : "+(a/b));    
        }

        public void mul(int a, int b)
        {
            Console.WriteLine("Multipllication : " + (a *b));
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("Difference : " + (a - b));
        }
    }
}

