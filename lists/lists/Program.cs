using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
     class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            var num = new List<int>() { 1, 3, 4, 5 };
            foreach (var i in num) ;
            Console.WriteLine(i);
            
            Console.ReadLine();
        }
    }
}
