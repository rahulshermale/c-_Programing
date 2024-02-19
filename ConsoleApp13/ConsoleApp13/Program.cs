using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void disp()
        {
            Console.WriteLine($"name = {name}, Age is {age}");

        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
                Person p1 = new Person();
                p1.Name = "Rahul";
                p1.Age = 25;
                p1.disp();
        }
    }
}
