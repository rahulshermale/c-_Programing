using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

   class abc
    {
        public static void disp()
        {
            Console.WriteLine("hi I Am Rahul SSSS");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "10";
            //Point p1 = new Point(50, 60);
            // p1.disp();
            //abc.disp();
            Console.WriteLine(x.GetType().BaseType.BaseType);
            Console.WriteLine("hi I Am Rahul");
        }
    }
}
