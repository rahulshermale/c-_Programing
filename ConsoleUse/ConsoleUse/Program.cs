using ClassLibrary1;

//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System;

namespace ConsoleUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths ob = new Maths();
            int r = ob.add(3,5);
            Console.WriteLine(r);

        }
    }
}
