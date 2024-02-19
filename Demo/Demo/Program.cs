using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class MyClass {
        public int sum(int x, int y) {
            return x + y;

        }
    }
     class Program
    {
        static void Main(string[] args)
        {
           
           
            MyClass myobj = new MyClass();

            Console.WriteLine(myobj.sum(10,10));

            int result=myobj.sum(10,5);

            Console.WriteLine("The sum Of : "+result);
            Console.WriteLine("The Result ={0}", result);
        }
    }
}
