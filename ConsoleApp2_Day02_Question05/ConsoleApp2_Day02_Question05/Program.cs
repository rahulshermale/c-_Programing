using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Day02_Question05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 20;

            var sum = num1 + num2;

            var myName = "Rahul";


            Console.WriteLine(myName.GetType().FullName);
            Console.WriteLine(sum.GetType());
        }
    }
}
