using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListEg
{
    internal class HashsetEg
    {
        public static void main()
        {
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("chennai");
            hashset.Add("chennai");
            hashset.Add("delhi");
            hashset.Add("chennai");
            hashset.Add("mumbai");
            hashset.Add("chennai");
            hashset.Add("chennai");
            hashset.Add("hydrebad");
            hashset.Add("chennai");
            hashset.Add("lucknow");
            hashset.Add("chennai"); 
            hashset.Add("chennai");

            foreach (string names in hashset)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("Total Cities : "+hashset.Count);

        }
    }
}
