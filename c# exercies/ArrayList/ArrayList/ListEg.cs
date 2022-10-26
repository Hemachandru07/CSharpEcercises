using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListEg
{
    internal class ListEg
    {
        public static void main()
        {
            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(11);
            l1.Add(12);

            Console.WriteLine("Index of 11 : " +l1.IndexOf(11));
            foreach (var l2 in l1)
            {
                Console.WriteLine(l2);
            }

            List<string> s1 = new List<string> { "Dell", "Lenovo", "HP" };
            foreach (var s2 in s1)
            {
                Console.WriteLine(s2);
            }
        }
    }
}
