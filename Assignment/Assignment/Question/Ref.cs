﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question
{
    internal class Ref
    {
        public static void DoTask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void DoTaskA(ref int x) 
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
    }
}
