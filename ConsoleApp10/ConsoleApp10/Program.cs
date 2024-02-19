using ConsoleApp10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Employee
    {
        double salary;
        string name;
        static Employee()
        {
            Console.WriteLine("2006 SMVITA  corporation"); }  
        public Employee(string name, double salary)  
        {
            this.salary = salary;
            this.name = name;
        }
    public void display() 
        {      Console.WriteLine("{0}{1}", name, salary);
        }   
     }
 class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee("Raj", 50000); 
                  e1.display(); 

    Employee e2 = new Employee("Ketan",90000 ); 
                  e2.display();

    }
}
}