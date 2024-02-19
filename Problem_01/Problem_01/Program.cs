using System;
using Problem_01;


namespace Problem_01
{
    public class MyClass {
        public int square(int a) {
            return a * a;
        }
        public int cube(int x) {
            return x * x * x;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine(obj.square(2));
            Console.WriteLine(obj.cube(2));

            Console.WriteLine(Class1.square(10));
            Console.WriteLine(Class1.cube(5));
        
        }


    }
}
