using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Num 1 :");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Num 2 :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int product = Num1 * num2;
            int sum = Num1 + num2;
            Console.WriteLine("The Product Of : " + product);
            Console.WriteLine("The Sum of : " + sum);
            Console.ReadLine();

        }
    }
}
