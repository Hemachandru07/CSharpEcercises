using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListEg
{
    internal class ExceptionEg
    {
        public static void main()
        {
            int a, b, c = 0;
            Console.WriteLine("Enter the two numbers : ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
            }
            //catch (DivideByZeroException d)

            //{
            //    Console.WriteLine("Dont enter 0");
            //}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Result : " + c);
            }
            
        }
    }
}
