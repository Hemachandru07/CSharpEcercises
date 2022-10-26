using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthConsoleApp
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
