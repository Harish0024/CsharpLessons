﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._08.New
{
    internal class Hash
    {

        public static void HashtableDemo()

        {

            Hashtable ht = new Hashtable();

            Console.WriteLine("Count " + ht.Count);

            Console.WriteLine("IsFixedSize " + ht.IsFixedSize);

            ht.Add("id", 123);

            ht.Add("name", "Gates");

            Console.WriteLine("Count " + ht.Count);

            ht.Add("sal", 15000);

            ht.Add("r1", new Random().Next());

            ht.Add("IsDirector", false);

            ht.Add("Address", null);

            // ht.Add("name", "Bill");// Runtime Error duplicate key 

            Console.WriteLine("Count " + ht.Count);

            Console.WriteLine(ht["sal"]);

            Console.WriteLine("ContainsKey(r1) " + ht.ContainsKey("sal"));

            Console.WriteLine("ContainsKey(name) " + ht.ContainsKey("name"));



            foreach (object k in ht.Keys)

                Console.WriteLine(k + "--" + ht[k]);

        }
        public static void EmpHTDemo()
        {
            Hashtable empTable = new Hashtable();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empTable.Add(e.ID,e);
            }
            foreach (object k in empTable.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Count " + empTable.Count);
            Console.WriteLine("ContainsKey(5) " + empTable.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empTable.ContainsKey(15));
        }
        public static void EmpDictionaryDemo()
        {
            Dictionary<int, Emp> empMap = new Dictionary<int, Emp>();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empMap.Add(e.ID, e);
            }
            Emp e1 = new Emp() { ID = 12345, Name = "Venkat", Salary = 1000000 };
            
            empMap.Add(15, e1);
            empMap.Add(16, e1);



            Console.WriteLine("Count " + empMap.Count);
            Console.WriteLine("ContainsKey(5) " + empMap.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empMap.ContainsKey(15));
        }
        public static void TestSortedListA()
        {
            SortedList<int, int> slist = new SortedList<int, int>();
            int count = slist.Count;
            Console.WriteLine("Count " + count);
            Console.WriteLine(" Capacity " + slist.Capacity);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                if (!slist.ContainsKey(x))
                    slist.Add(x, x * 55);
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + slist.Count);
            Console.WriteLine(" Capacity " + slist.Capacity);



            foreach (var i in slist)
            {
                Console.WriteLine(i.Key + "," + i.Value);
            }
        }

    }
    class Emp
    {
        public int ID;
        public string Name;
        public int Salary;
    }


}
