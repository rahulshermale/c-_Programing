using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Employee 
    {
        float salary;
        string name;
        public Employee(float sal,string nm) 
        {
            salary = sal;
            name = nm;
        }
        public double netSal() {
            double netSalary;
              netSalary = salary - salary * 0.1;
            return netSalary;
        
        }
        public string disp()
        {
            double nsal = netSal();
            return string.Format("{0} {1} {2}", name, salary, nsal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ob = new Employee(1000,"game");
            Console.WriteLine(ob.disp());
        }
    }
}
