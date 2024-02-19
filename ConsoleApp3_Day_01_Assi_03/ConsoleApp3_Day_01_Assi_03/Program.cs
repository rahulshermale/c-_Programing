using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Day_01_Assi_03
{
    class calculator
    {
        public static int squre(int a) 
        {
            return a * a;
        }

        public static int cube(int b)
        {
            return b * b * b; 
        }

        public static int round(double q)
        {
            return (int)q;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calculator.squre(2));
            Console.WriteLine(calculator.cube(3));
            Console.WriteLine(calculator.round(22.5));
        }
    }
}
