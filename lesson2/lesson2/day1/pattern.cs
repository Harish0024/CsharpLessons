using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace lesson2.day1
{
    internal class Pattern
    {
        public static void ggg()
        {
            int row=9;
            int a = row;
            for (int i = 1; i <=row; i++)
            {
                Console.Write("");
                for (int j = a; j>1; j--)
                {
                    Console.Write("");
                }
                    for (int k = i; k!= 0; k--)
                        
                    {
                    
                    Console.Write(k);
                    }
                
                a--;
                    
                    
                    for(int l=2;l<=i; l++)
                    {
                        Console.Write(l);
                    Console.WriteLine("");
                }
                    Console.WriteLine("");

                
                
            }
        }
    }
}
