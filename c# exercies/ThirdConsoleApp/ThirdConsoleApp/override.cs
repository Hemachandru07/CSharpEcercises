using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp
{
	class baseClass
	{

		// show() is 'virtual' here
		public virtual void show()
		{
			Console.WriteLine("Base class");
		}
	}


	// class 'baseClass' inherit
	// class 'derived'
	class derived : baseClass
	{

		//'show()' is 'override' here
		public override void show()
		{
			Console.WriteLine("Derived class");
		}
	}

}
