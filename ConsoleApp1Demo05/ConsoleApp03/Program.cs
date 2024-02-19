using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp03
{

    internal class Program
    {
        class car
        {
            string colour = "Red";


            static void Main(string[] args)
            {

                car obj = new car();

                Console.WriteLine(obj.colour);
            }
        }
    }
}