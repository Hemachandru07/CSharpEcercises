using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
     class ex2
    {
        public static void main()
        {
            Console.WriteLine("Enter the D.O.B : ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = today.Year - dob.Year;
            Console.WriteLine("The age of the Person is : "+age);

            if (((dob.Year % 4 == 0) && (dob.Year % 100 != 0)) || (dob.Year % 400 == 0))
            {
                Console.WriteLine("The Person was Born in Leap Year");
            }
            else
            {
                Console.WriteLine("The Person was not born in Leap year");
            }
        }
    }
}
