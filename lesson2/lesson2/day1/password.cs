using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2.day1
{
    internal class password
    {
        public static void pas()
        {
            string password;
            Console.WriteLine("enter the password \n");
            password = Console.ReadLine();
            
            
             
            
                
            
                if (password.Length < 8 || password.Length > 14)
                {
                    Console.WriteLine("nil");
                 }
                else if (!password.Any(char.IsUpper))
                {
                    Console.WriteLine("nil");
                }
                else if(password.Contains(" "))
                {
                    Console.WriteLine("nil");
                }
           
                 
                 else
                {
                     Console.WriteLine("password is correct");
                }

        }
    }
}
