using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
     class prac2
    {
        public static void Main()
        {
            Console.WriteLine("if statement");
            Console.WriteLine("enter your mark : ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark < 100 && mark >= 90)
            {
                Console.WriteLine("the grade is A");
            }
            else if (mark < 90 && mark >= 60)
            {
                Console.WriteLine("the grade is B");
            }
            else
            {
                Console.WriteLine("the grade is C");
            }

            Console.WriteLine("Do while statement");

            int i = 1;
            do
            {
                Console.WriteLine("C# Programming");
                i++;
            } while (i <= 10) ;

            Console.WriteLine("");
            Console.WriteLine("Switch statement");

            Console.WriteLine("Enter any choice 1-4");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Hi");
                    break;
                case 3:
                    Console.WriteLine("Vanakam");
                    break;
                case 4:
                    Console.WriteLine("Namasthe");
                    break;
                default:
                    Console.WriteLine("bye");
                    break;

            }
            Console.WriteLine("");
            Console.WriteLine("Foreach statement");

            string[] names = new[] { "chandru", "hemu", "hemachandru", "chan" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}
