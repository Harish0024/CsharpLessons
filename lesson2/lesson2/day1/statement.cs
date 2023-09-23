using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace lesson2.day1
{
    internal class statement
    {
        public static void test() {
            int age;
            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
             
            {
                Console.WriteLine("hi");
            }
            if (age < 18)
            {
                Console.WriteLine("you cant drive");
            }
            else
            {
                Console.WriteLine("yes u can");
            }
                 }
    }
}
