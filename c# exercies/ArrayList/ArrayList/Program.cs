using System;
using System.Collections;



namespace ArrayListEg
{
    class Program
    {
        static void main(string[] args)
        {
            
            ArrayList l1 = new ArrayList();
            l1.Add(1);
            foreach (var n in l1)
            Console.WriteLine(n);


        }
    }
}
