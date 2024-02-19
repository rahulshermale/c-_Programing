using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Day_01_Assi_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x, y;

            Console.WriteLine("Enter the Value ");

           x = Console.ReadLine();
            Console.WriteLine("Enter the Value ");
            y = Console.ReadLine();

            float n1 = float.Parse(x);
            float n2 = float.Parse(y);

            float result = n1 * n1;
            float r2 = n2 * n2;
            Console.WriteLine(result);
            Console.WriteLine(r2);

        }
    }
}
