using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject.Day2
{
    internal class Box
    {
        public static int height;
        public  int width;
        public const string type = "woden";//the value should be assigned it can not be changed

        public int Getheight()//in non static method both static and non static value can be called
        {
            return height;
        }
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            
            Box.height=100;
           // Box.width = 100;it cannot be accesed because it is not static
           Box firstbox= new Box();
            Box secondbox= new Box();
            firstbox.width=66;
            secondbox.width = 300;
            Console.WriteLine(Box.type); 
            
            Console.WriteLine($"First Box={firstbox.width},{firstbox.Getheight()}");//now non static is called using object
            Console.WriteLine($"second box={secondbox.width},{secondbox.Getheight()}");
            Box.height = 200;
            Console.WriteLine($"First Box={firstbox.width},{firstbox.Getheight()}");//now non static is called using object
            Console.WriteLine($"second box={secondbox.width},{secondbox.Getheight()}");

        }
    }
    
}
