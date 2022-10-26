using System;
using ClassLibrary1;

namespace LibEg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 add = new Class1();
            int a = add.Add(2, 3);
            Console.WriteLine("sum : "+a);



        }
    }
}
