using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Employee : IEmployee<Employee>
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public float Salary { get; set; }

        public Employee() { }

        public Employee(int eid, string ename, float salary)
        {
            Eid = eid;
            Ename = ename;
            Salary = salary;
        }

        public static List<Employee> employees = new List<Employee>();

        public List<Employee> GetEmpList()
        {
            employees.Add(new Employee(1,"Chandru",25000));
            employees.Add(new Employee(2,"Hemu",20000));
            return employees;
        }

        public bool AddEmployee(Employee e)
        {
            employees.Add(e);
            return true;
        }

        public bool RemoveEmployee(int id)
        {
            Employee e = GetEmpById(id);
            employees.Remove(e);
            return true;
        }

        public Employee GetEmpById(int id)
        {
            Employee e = employees.Where(x => x.Eid == id).SingleOrDefault();
            return e;
        }

        public string message(string name)
        {
            return "Hello" + name;
        }

        public bool checksal(int sal)
        {
            int result = add(sal, 40);
            if (result > 70)
                return true;
            else
                return false;
        }

        public int add(int x, int y)
        {
            return x + y;
        }
    }
}
