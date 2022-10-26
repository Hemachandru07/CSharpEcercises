using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthConsoleApp
{
    internal interface ICalculator
    {
        void add (int a, int b);
        void sub(int a, int b);
        void mul(int a, int b);
        void div(int a, int b);
         string message()
        {
            return "hi";
        }

    }

    interface Iscientific : ICalculator
    {
        void sine(int a , int b );
        void cosine(int a , int b );


    }
}
