using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Q2.Create class MyClass and write 2 instance method square and cube
 Create entrypoint class and call static and non static methods.Print results in 3 different ways
 1.using +
2.Using placeholder
3.Using “${}”*/

namespace AssignmentNo_01_Q_02
{
    public class MyClass
    {
      

            public int findSquare(int num)
            {
                return num * num;
            }
            public int findCube(int num)
            {
                return num * num * num;
            }
        }
        public class Program { 
            static void Main(string[] args)
            {
              //  Console.WriteLine("Static Method");
              //  Console.WriteLine("Square of 5 using '+' operator "+ MyClass.findCube(5)); 
              //  Console.WriteLine("Square of 2 using placeHolder :{0}",MyClass.findCube(5));


            MyClass obj=new MyClass();
           
            Console.WriteLine("This is a Non Static Method");
            Console.WriteLine(obj.findSquare(5));
            Console.WriteLine(obj.findCube(5));


            }


        }

    }
