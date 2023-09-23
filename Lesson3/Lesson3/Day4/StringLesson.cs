using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Day4
{
    internal class StringLesson
    {
        public static void Demo()
        {
            string firststring = "hello";
            char[] data = { 'h', 'e', 'l', 'l', 'o' };
            string secondstring = new string(data);
            Console.WriteLine(firststring+""+secondstring);
            string thirdstring=string.Empty;

        }
        public static void DemoB() {
            String s1 = "tom and jerry are good friends";
            Console.WriteLine("length"+s1.Length);
            char[] data=s1.ToCharArray();
            foreach(char c1 in data)
            {
                Console.WriteLine(c1);
            }
        }
        public static void DemoC()
        {
            string s1 = "tom and jerry are good friends";
            string[] words = s1.Split(' ');
            Console.WriteLine("word count"+words.Count());
            foreach(var item in words)//varchar 
            {
                Console.WriteLine(item);
            }
        }
        public static void DemoD()
        {
            string firststring = "Tom and jerry are good friends";
            string stringInUPPER=firststring.ToUpper();
            Console.WriteLine("firststring:"+firststring);
            Console.WriteLine("stringInUPPER:"+stringInUPPER);
            string stringInLower=firststring.ToLower();
            Console.WriteLine("firststring:" + firststring);
            Console.WriteLine("stringInUPPER:" + stringInLower);
        }
        public static void DemoE()
        {
            String secondString = "    abcdef    ";
            String trimmedString = secondString.Trim();
            Console.WriteLine(secondString);
            Console.WriteLine("secondString Length: " + secondString.Length);
            Console.WriteLine(trimmedString);
            Console.WriteLine("trimmedString Length: " + trimmedString.Length);
            String trimmedAtEnd = secondString.TrimEnd();
            Console.WriteLine(trimmedAtEnd);
            Console.WriteLine("trimmedAtEnd Length: " + trimmedAtEnd.Length);
            String trimmedAtStart = secondString.TrimStart();
            Console.WriteLine(trimmedAtStart);
            Console.WriteLine("trimmedAtStart Length: " + trimmedAtStart.Length);

        }
    }
}
