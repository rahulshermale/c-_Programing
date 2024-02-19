using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Student {
        string name;
        int math;
        int sci;
        int eng;

        public Student(string name, int math, int sci, int eng) {
            this.name = name;
            this.math = math;
            this.eng = eng;
            this.sci = sci;
        }
        public double totalMarks() {
            double total;
                total= math + sci + eng;
            return total;
        }
        public string disp() {
            double tot = totalMarks();
           return string.Format("{0} {1}",name,tot);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ram", 100, 90, 80);
            Console.WriteLine(s1.disp());
        }
    }
}
