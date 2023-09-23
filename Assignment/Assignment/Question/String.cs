using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question
{
    internal class Stringl
    {
        public static void Stringln()

        {
            String strFriends = "Tom and Jerry are good friends";
            
          string[] s1=  strFriends.Split(' ');
            Console.WriteLine(s1.Count());
            foreach (string s2 in s1)
            {
                Console.WriteLine(s2);
            }

            
            char[] ch= strFriends.ToCharArray() ;


            

        }
    }
}
