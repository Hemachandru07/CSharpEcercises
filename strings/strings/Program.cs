using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*concatenation of strings

            var name = "Hemachandru" + " is a very good boy";
            Console.WriteLine(name);
            Console.ReadLine();*/

            /* Length
            var name = "Hemachandru" + " is a very good boy";
            Console.WriteLine(name.Length);
            Console.ReadLine();*/

            /* string methods
             * ToUpper case

            var name = "Hemachandru" + " is a very good boy";
            Console.WriteLine(name.ToUpper() );
            Console.ReadLine(); */

            /*ToUpper case
            var name = "Hemachandru" + " is a very good boy";
            Console.WriteLine(name.ToLower());
            Console.ReadLine();*/

            /* Contains
            var name = "Hemachandru" + " is a very good boy";
            Console.WriteLine(name.Contains("very"));
            Console.ReadLine();*/

            /* IndexOf
            var name = "Hemachandru" + " is a very good boy";
            Console.WriteLine(name.IndexOf("good") );
            Console.ReadLine();*/

            /*Index
            var name = "Hemachandru" + " is a very good boy";
            Console.WriteLine(name[0]);
            Console.ReadLine();*/

            /* Substring
            var name = "Hemachandru" + " is a very good boy";
            Console.WriteLine(name.Substring(0, 3) );
            Console.ReadLine();*/

            /* Padding
            var name = "Hemachandru" + " is a very good boy";
            Console.WriteLine(name.PadLeft(300) );
            Console.ReadLine();*/

            /*Comparing Two strings
            string str1 = "chandru";
            string str2 = "chandru";
            var str3 = "hemu";
            bool result1 = str1.Equals(str2);
            bool result2 = str1.Equals(str3);
            Console.WriteLine("String 1 is equal to String 2: " + result1);
            Console.WriteLine("String 1 is equal to String 3: " + result2);

            Console.ReadLine();*/

        }
    }
}
