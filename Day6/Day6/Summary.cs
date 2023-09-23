using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Summary
    {
        public Summary()
        {
            int[] sample = new int[10];
            int length = sample.Length;
            int i;
            Random random = new Random();
            for (i = 0; i < 10; i++)
            {
                sample[i] = random.Next(50);

                for(i = 0;i < 10; i++)
                {
                    Console.WriteLine("sample[" + i + "]" + sample[i]);
                }

            }
        }
    }
}
