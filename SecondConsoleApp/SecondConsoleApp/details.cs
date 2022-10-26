using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    internal class details
    {
        //Member variables
        int eid;
        string name;
        float salary;

        public string Name
        {
            get { return Name; }
            set { Name = value; }

        }

        public int Eid
        {
            get { return eid; }
            set
            {
                if (value < 0)
                    Eid = 0;
                else
                    Eid = value;
            }
        }

        //Member functions
        public void AcceptDetails()
        {
            Console.WriteLine("Enter the eid, name, salary");
            eid = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            salary = float.Parse(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            Console.WriteLine("The employee details are : ");
            Console.WriteLine("eid : {0} name :{1} salary :{2}", eid, name, salary);
        }
    }

}
