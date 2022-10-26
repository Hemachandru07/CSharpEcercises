using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class prac1
    {
        class player
        {
            public string name;
            public float avg;
        }
        public static void main()
        {
            #region
            player p1 = new player();
            p1.name = "chan";
            p1.avg = 23.45f;
            Console.WriteLine("player1 name is {0} and average is {1}", p1.name, p1.avg);
            player p2 = p1;
            Console.WriteLine("player2 name is {0} and average is {1}", p2.name, p2.avg);
            p1.name = "hemu";
            p1.avg = 34.5f;
            Console.WriteLine("player1 name is {0} and average is {1}", p1.name, p1.avg);
            Console.WriteLine("player2 name is {0} and average is {1}", p2.name, p2.avg);
            #endregion


        }
    }
}

