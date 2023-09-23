using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson8.Day8
{
    internal class LamdaDemo
    {
        public static void DemoA()
        {
            //first is input , after is output
            Func<int, int> f1 = x => x / 2;//arrow function
            //public int foo(int x)
            //{
            //return x / 2;
            //this is used as lamda fuction
            int i = 100;
            int result = f1(i);
            Console.WriteLine(result);
        }
        public static void DemoB()
        {
            Func<int> foo = () => 100;
            int result = foo();
            Console.WriteLine(result);
        }
        public static void DemoC()
        {
            Func<double, double, double> callme = (x, y) => (x + y) / 2;
            int v1 = 100;
            int v2 = 25;
            double result = callme(v1, v2);
            Console.WriteLine(result);
        }
        public static void DemoD()
        {
            Func<double,int> hh = x => (int)x / 2;//if we wnat to get these we need to specify t
            int v1 = 101;
            int result = hh(v1);
            Console.WriteLine(result);
        }
        static void Echo(Func<string>foo)
        {
            string str=foo();
            Console.WriteLine(str);
        }
        public static void TestEcho()
        {
            Echo(() => "Hello");
            Echo(() => "World");
        }
         static double Dotrain(Func<int,int,double>foo) 
        {
            return foo(50, 5);
        
        }
        public static void TestDoTrans()
        {
            Func<int,int,double>Multiply=(x,y)=>(x*y);
            double d = Dotrain(Multiply);
            Console.WriteLine(d);

            Func<int, int, double> Add = (x, y) => (x + y);
            double e=Dotrain(Add);
            Console.WriteLine(e);

            Func<int, int, double> Divide = (x, y) =>
            {
                if (y == 0) y = 1; return x / y;
            };
            double d1=Dotrain(Divide);
            Console.WriteLine(d1);
        }

    }
}
