using System;

namespace SecondConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            details e1 = new(); //instantiation ---> creating an object
            //e1.AcceptDetails();
            //e1.DisplayDetails();
            e1.Eid = -44;
            Console.WriteLine(e1.eid);
            //Console.WriteLine("");
            //details e2 = new();
            //e2.AcceptDetails();
            //e2.DisplayDetails();
            
        }
    }
}
