using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Day_01_Assi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number 1 :");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter the Number 2 :");
            string num2 = Console.ReadLine();


            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            int result = n1 + n2;
            Console.WriteLine("The Sum of "+result);

        }
    }
}
