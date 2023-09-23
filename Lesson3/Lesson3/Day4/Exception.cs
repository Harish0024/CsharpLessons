using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Day4
{
    internal class exception
    {
        public static void DemoAExceptions()
        {
            Console.WriteLine("\tEnter a no for X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter a no Y");
            int y = int.Parse(Console.ReadLine());
            Calculator c1 = new Calculator();
            int z = c1.Divide(x, y);
            Console.WriteLine("Result in M3 " + z);
        }
        class Calculator
        {
            public int Divide(int x, int y)
            {
                return x / y;
            }
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                return x * y;
            }
            public int Subtract(int x, int y)
            {
                return x - y;
            }

            public int DivideA(int x, int y)
            {
                //if (y == 0)
                //    throw new ZeroValueException();
               // if (y == 0)
                   // throw new ZeroValueException("ERROR!!! Value for Y is " + y);
                return x / y;
            }
        }


    }
    internal class Exc
    {
        public static void TestCatchFinally()
        {
            Console.WriteLine("Before Try");
            int v1 = 0;
            // return;
            try
            {
                Console.WriteLine("Inside Try");
                Console.WriteLine("Enter a no");
                v1 = int.Parse(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine("Inside Catch " + err.Message);
            }
            finally
            {
                Console.WriteLine("Inside  Finally");
            }
            Console.WriteLine("After  Finally");
        }
        class ClassA
        {
            public int M1(int x, int y)
            {
                ClassB b1 = new ClassB();
                return b1.M2(x, y);
            }
        }
        class ClassB
        {
            public int M2(int x, int y)
            {
                Calculator c1 = new Calculator();
                return c1.Divide(x, y);
            }
        }
        class Calculator
        {
            public int Divide(int x, int y)
            {
                return x / y;
            }
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                return x * y;
            }
            public int Subtract(int x, int y)
            {
                return x - y;
            }

            public int DivideA(int x, int y)
            {
                //if (y == 0)
                //    throw new ZeroValueException();
                // if (y == 0)
                // throw new ZeroValueException("ERROR!!! Value for Y is " + y);
                return x / y;
            }
        }
    }
}
