using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Day8
{
    internal class ThreadDemo
    {
        public static void DemoCurrentTH()
        {
            Thread t1= Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadId="  +id);
            Console.WriteLine("IsAlive="+t1.IsAlive);
            Console.WriteLine("priority="  +t1.Priority);
            Console.WriteLine("Threadstate="+t1.ThreadState);
            Console.WriteLine("Threadculture="+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new CultureInfo("ge-Ge");
            Console.WriteLine("currentculture"+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new CultureInfo("de-De");
            Console.WriteLine("currentculture"+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
