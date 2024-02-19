using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Employee
    {
        string firstname, lastname, middlename;
        public Employee()
        {
            Console.WriteLine("parameter less const");

        }
        public Employee(string fname, string lname, string mname)
        {
            firstname = fname;
            lastname = lname;
            middlename = mname;
            Console.WriteLine(fname+" "+lname+" "+mname);
        }
        public Employee(string fname, string lname) {
            firstname = fname;
            lastname = lname;
        }
        public string disp() {
            return firstname + " " + lastname + " " + middlename;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ob = new Employee();
            string r1=ob.disp();
            Employee e1 = new Employee("Ram ","sham");
            string r2 =e1.disp();
            Employee e2 = new Employee("SHam", "sita", "geeta");


            string r3=e2.disp();
           // Console.WriteLine(r1);
           // Console.WriteLine(r2);
           // Console.WriteLine(r3);
            
        }
    }
}
