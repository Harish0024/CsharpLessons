using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2.day1
{
    internal class pass2
    {
        public static void password()
        {
            string s1="harish";
            Console.WriteLine("enter password");
           
            if (s1.Length > 8 || s1.Length < 14)
            {
                Console.WriteLine("ok");
            }
        }
    }
}
