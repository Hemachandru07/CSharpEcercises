using System;

namespace FourthConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator c = new cal();
            c.add(5, 6);
            c.mul(5, 6);
            c = new cal1();
            c.div(5, 6);
            c.sub(5, 6);
            Console.WriteLine(c.message());
        }
    }
}
