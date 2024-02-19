using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Employee 
    {
        private int id;
        private string name;
        private double salary;
        private double netsalary;


        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
         
        }
        public double Calculatesal() {
            this.netsalary = this.salary - (this.salary * 0.1);
            return this.netsalary;
        }
        public void disp() {

            Console.WriteLine($"Name: {this.name} Net-Salary: {this.netsalary}");
        }
    
    
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(10,"Manu",50000);
            Console.WriteLine(e1.Calculatesal());
            e1.disp();

            Employee emp1 = new Employee(101, "John Doe", 50000);

            Employee emp2 = new Employee(102, "Jane Smith", 60000);

            emp2.Calculatesal();
            emp1.Calculatesal();

            emp1.disp();
            emp2.disp();

        }
    }
}
