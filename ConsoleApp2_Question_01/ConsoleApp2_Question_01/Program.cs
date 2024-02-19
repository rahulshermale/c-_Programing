using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create struct employee with member Id Name Salary,
//create method netsalary which will return netsalary after deducting 10% Tds.

namespace ConsoleApp2_Question_01
{
    public struct Employe {
        public int id;
        public string name;
        public double salary;

        public double netsalary() {

            return salary * 0.9;
        }
        public Employe(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void disp()
        {
            Console.WriteLine(" id " + id + "name: " + name + " salary " + salary);
        }
        
    }
    class Demo {
        public static void Main() {
            Employe obj = new Employe(10, "Ram", 60000);
            Console.WriteLine("Net Salary "+obj.netsalary());
            obj.disp();


        }
    }
}
