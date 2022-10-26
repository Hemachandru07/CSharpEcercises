using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void main(string[] args)
        {
            //Get details
            Console.WriteLine("enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age : ");
            //int age = int.Parse(Console.ReadLine());
            //int age = Convert.ToInt32(Console.ReadLine());
            int age;
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("enter your grade : ");
            char grade = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter the DOB : ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter the average : ");
            float avg = float.Parse(Console.ReadLine());

            //print details
            Console.WriteLine("my name is {0}", name);
            Console.WriteLine($"my age is {age} and my Grade is {grade} ");
            Console.WriteLine("My dob is " +dob);
            Console.WriteLine($"My average is {avg}");
        }

    }
}