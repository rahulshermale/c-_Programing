using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   
    class Student
    {
        static string Prn;
        private string subject;
        private int total;
        private double Perc;

        public Student(int s1, int s2,int s3)
        {
            this.total = s1 + s2 + s3;
            Prn +=1; 
        }
        public void get_total() {
           
           // Console.WriteLine(this.total);
        }

        public void get_perc() {
            Perc=this.total * 0.01;
           // Console.WriteLine(Perc);
        }
        public void disp()
        {
            Console.WriteLine($"Prn  total");
            Console.WriteLine(total);
            Console.WriteLine(Perc);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student(10,20,30);
            obj.get_total();
            obj.get_perc();
            obj.disp();
            Student obj2 = new Student(100, 50, 60);
            obj2.disp();
        }
    }
}
