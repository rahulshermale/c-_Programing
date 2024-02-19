using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Prog
    {
        public static void myMethod(string name="ram")
        {
            Console.WriteLine("Hi just got "+name);

        }
    } 
    internal class program { 
        static void Main(string[] args)
        {

            Prog.myMethod("rahul");
           Prog.myMethod("");
            Prog.myMethod("K");
            Prog.myMethod();
        }
    }
}
