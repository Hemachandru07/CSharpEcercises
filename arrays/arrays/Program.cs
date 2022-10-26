using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new[] { 0, 1, 2, 3, 4, 5, 7, 8 };

            //Length

            Console.WriteLine("lenth of array : " +num.Length);

            //Indexof

            var index = Array.IndexOf(num, 4);
            Console.WriteLine(index);

            //Clear()

            Array.Clear(num, 4, 3);

            Console.WriteLine("Clear method:");
            foreach(var n in num)
                Console.WriteLine(n);

            //Copy()

            var nums = new int[3];
            Array.Copy(num, nums, 3);
            Console.WriteLine("Copy method:");
            foreach (var n in nums)
                Console.WriteLine(n);

            //Sort()

            Array.Sort(num);

            Console.WriteLine("Sort method:");
            foreach (var n in num)
                Console.WriteLine(n);


            Console.ReadLine();
        }
    }
}
