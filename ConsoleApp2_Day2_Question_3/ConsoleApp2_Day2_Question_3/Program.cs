using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//declare 2 int variable and accept 2 value and  apply .
//equals, ToString() and == operater
namespace ConsoleApp2_Day2_Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the Number : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"num1.Equals(num2): {num1.Equals(num2)}");

            Console.WriteLine($"num1.ToString(): {num1.ToString()}");

            Console.WriteLine($"num1 == num2: {num1 == num2}");

        }
    }
}
