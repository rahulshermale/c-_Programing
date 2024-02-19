using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static int demo(int x) {
            return x + 5;
        }
        static void demo1(string z) {
            Console.WriteLine("Hii");
        }
        static void Main(string[] args) {
           Program program = new Program();
           demo1("Ra");
           Console.WriteLine(demo(10));
            Console.WriteLine(demo(20));
        }
    }
}
