// C# program to illustrate the use of
//'virtual' and 'override' modifiers
using System;
using ThirdConsoleApp;

class GFG
{

	// Main Method
	public static void Main()
	{

		baseClass obj;

		// 'obj' is the object
		// of class 'baseClass'
		obj = new baseClass();

		// it invokes 'show()'
		// of class 'baseClass'
		obj.show();


		// the same object 'obj' is now
		// the object of class 'derived'
		obj = new derived();

		// it invokes 'show()' of class 'derived'
		// 'show()' of class 'derived' is overridden
		// for 'override' modifier
		obj.show();

	}
}
