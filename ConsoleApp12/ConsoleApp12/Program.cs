using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Raj", 5000);
            double d = Employee.paytax(e1);

            Employee e2 = new Employee(2,"Geeta",7000);
      
                   d = Employee.paytax(e2);

        }
    }
    class Employee
    {
        int id;
        string name;
        double salary;
        public Employee(int eid, string ename, double sal)
        {
            id = eid;
            name = ename;
            salary = sal;
        }
        public static double paytax(Employee ob)
        {
            return ob.salary * 0.1;
        }

    }
}
