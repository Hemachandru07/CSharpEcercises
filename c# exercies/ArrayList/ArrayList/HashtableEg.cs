using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListEg
{
    internal class HashtableEg
    {
        public static void main()
        {
            Hashtable h1 = new Hashtable();
            //SortedDictionary<int, string> h1 = new SortedDictionary<int, string>(); 
            h1.Add(100, "Dell");
            h1.Add(104, "Lenovo");
            h1.Add(102, "HP");
            h1.Add(108, "Asus");
            foreach (var h2 in h1.Keys)
            {
                Console.WriteLine(h2);
            }
            foreach (var h3 in h1.Values)
            {
                Console.WriteLine(h3);
            }
            foreach (DictionaryEntry h3 in h1)
            {
                Console.WriteLine(h3.Key + " " + h3.Value);
            }
            //foreach (KeyValuePair<int, string> h3 in h1)
            //{
            //    Console.WriteLine(h3.Key + " " + h3.Value);
            //}
            //Console.WriteLine("Enter the key : ");
            //int search = Convert.ToInt32(Console.ReadLine());
            //if(h1.Contains(search))
            //{
            //    Console.WriteLine(h1[search]);
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}

        }
    }
}
