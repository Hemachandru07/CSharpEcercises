using System;

namespace exercise1
{
     class Program
    {
        static void main(string[] args)
        {
            //C# program to accept student name, and five marks Calculate Average and grade

            Console.WriteLine("Enter the Student Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the 5 Subject Marks :");
            int subject1 = Convert.ToInt32(Console.ReadLine());
            int subject2 = int.Parse(Console.ReadLine());   
            int subject3 = int.Parse(Console.ReadLine());
            int subject4 = int.Parse(Console.ReadLine());
            int subject5 = int.Parse(Console.ReadLine());

            int avg = (subject1 + subject2 + subject3 + subject4 + subject5)/5;
            Console.WriteLine("The average is : "+avg);
            if (avg > 90)
            {
                Console.WriteLine("Outstanding");
            }
            else if (avg <= 90 && avg > 65)
            {
                Console.WriteLine("Excellent");
            }
            else if (avg <= 65 && avg > 40)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
