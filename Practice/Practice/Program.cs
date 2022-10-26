using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num, num1, num2;
            try
            {
                Console.WriteLine("Enter first number :");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number :");
                num1 = Convert.ToInt32(Console.ReadLine());

                num2 = num / num1;
                Console.WriteLine("Result : " + num2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            Console.ReadLine();
        }
       
    }
}
