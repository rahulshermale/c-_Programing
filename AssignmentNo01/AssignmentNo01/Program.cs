using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q1.Create class MyMaths and write 3 static methods to find square, cube and power of number

namespace AssignmentNo01
{
  
        internal class Program
        {
        public static class myMath
        {

            public static int findSquare(int num)
            {
                return num * num;
            }
            public static int findCube(int num)
            {
                return num * num * num;
            }

             public static int Power(int num,int exp) {
                return (int)Math.Pow(num, exp);

                   }
           

            static void Main(string[] args)
            {

                Console.WriteLine(myMath.findSquare(10));
                Console.WriteLine(myMath.findCube(5));
                Console.WriteLine(myMath.Power(3, 4));

            }
        }
    }
}