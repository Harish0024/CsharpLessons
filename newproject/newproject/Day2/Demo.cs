using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//int y=110 should not be declared here
namespace newproject.Day2
{
    //int z=10 should not be declared before the class
    internal class Demo
    {
        //GLOBAL VARIABLES
        int x = 10; //member variable/class variable should be declared only here
        //method should be inside a class
        static int y = 20;
        public static void FirstMethod()
        {
            //name of loacl and global var can be same
            //you cannot acces non static global variable inside a static class the variable should be static
            int x = 2000;
            int y = 1000;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(Demo.y);
        }
        int variable = 0;
        //it can be only declared cant use if or any condition
        public void SecondMethod()//inside a non static method static method and normal variable can be called
        {
            int y = 1000;
            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.WriteLine(Demo.y);
            Console.WriteLine(variable);
        }
    }
}
namespace newproject.Gavs
{
    internal class Demo
    {

    }
}
