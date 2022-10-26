using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
     class ex4
    {
        public static void main()
        {
            Console.WriteLine("Enter the Total Number of students : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("WELCOME STUDENT  " +i);
            }

        }
    }
}
