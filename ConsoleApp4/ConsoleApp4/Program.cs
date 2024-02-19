using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{class Employee
    {
        public int age;
        public int salary;
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ob = new Employee();

            double net_sal;
            ob.age = 20;
            ob.salary = 50000;
            ob.name = "RAm";

            net_sal = ob.salary + ob.salary * 0.1;


            Console.WriteLine("Name= {0} NetSal {1}", ob.name, net_sal);

            Employee ob1 = new Employee();
            ob1.age = 25;
            ob1.salary = 65000;
            ob1.name = "sham";
            net_sal = ob1.salary + ob1.salary * 0.1;
            Console.WriteLine("Age {0}  SAlary {1} Name {2} NetSAlary {3}",ob1.age,ob1.salary,ob1.name,net_sal);

        }
    }
}
