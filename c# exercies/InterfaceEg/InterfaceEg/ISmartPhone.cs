using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEg
{
    internal interface ISmartPhone
    {
        void brand(string b);
        void price(int a);
    }
    interface INormalPhone : ISmartPhone
    {
        void Brand(string b);
        void Price(int a);
    }
}
