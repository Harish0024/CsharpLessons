using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9.Day9
{
    internal class StreamLesson
    {
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("press any key");
            
                int x = Console.Read();
                ch = (char)x;
                Console.WriteLine("\n" + x + "your key is=" + ch);
            
        }
        public static void TestTwo()
        {
            char ch = ' ';
            Console.WriteLine("press any key");
            while (ch != 'q')
            {
                ch=(char)Console.Read();
                Console.WriteLine("your key is"+ch);
            }
           
        }
        public static void TestThree()
        {
            Console.Out.WriteLine("enter a sentence");
            string?str=Console.ReadLine();//to set a value type to null we use ?
            Console.Out.WriteLine(" "+str);
        }
        public static void TestNull()
        {
            int? x = 0;
            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine(x.GetValueOrDefault());
            }

        }
    }

}
