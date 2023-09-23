using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject.Day2
{
    internal class Try
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
    }
}
