using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEg
{
    internal class Shop :  INormalPhone
    {
        public void brand(string b)
        {
            Console.WriteLine("Brand : " +b);
        }

        public void Brand(string b)
        {
            Console.WriteLine("Brand :" +b);
        }

        public void price(int a)
        {
            Console.WriteLine("Price : " +a);
        }

        public void Price(int a)
        {
            Console.WriteLine("Price : " + a);
        }
    }
}
