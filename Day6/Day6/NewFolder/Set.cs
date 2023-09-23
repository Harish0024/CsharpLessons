using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.NewFolder
{
    //no duplication happen nomerror is thrown only one is printed and duplicate is ignored
    internal class Set
    {
        public static void Hello()
        {
            HashSet<string>str = new HashSet<string>(10);
            //initialize with size more than normal 10%
            str.Add("Alt");
            str.Add("Alt");
            str.Add("king");
            str.Add("Alt");
            str.Add("King");
            foreach (string s in str)
            {
                Console.WriteLine(s); ;
            }
            Console.WriteLine(str.Count());
            
                SortedSet<int> alist = new SortedSet<int>();
                int count = alist.Count;
                Console.WriteLine("Count " + count);
                alist.Add(10);
                alist.Add(10);
                alist.Add(10);
                Random r1 = new Random();
                for (int i = 0; i < 10; i++)
                {
                    int x = r1.Next(100);
                    alist.Add(x);
                    Console.Write(x + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Count " + alist.Count);
                foreach (int i in alist)
                    Console.Write(i + ",");
            HashSet<String> stringSet = new HashSet<String>();
            stringSet.Add("Chennai");
            stringSet.Add("Salem");
            stringSet.Add("Erode");
            stringSet.Add("Tirupur");
            stringSet.Add("Kovai");
            stringSet.Add("Chennai");
            stringSet.Add("Trichy");
            stringSet.Add("Madurai");
            stringSet.Add("Nellai");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add(null);
            stringSet.Add(null);
            Console.WriteLine($"Count:{stringSet.Count}");
            foreach (var item in stringSet)
            {
                if (item != null)
                    Console.WriteLine(item);
                else
                    Console.WriteLine("NULL");
            }



        
    }

    }
}
