using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson29._08.New.Day8
{
    public delegate void hi(int a, int b);

    public class Dele
    {
        public void mul(int a,int b)
        {
            int c = a + b;

            Console.WriteLine(c);
        }
        public void add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
   public class Hello
    {
        public static  void win()
        {

            Dele dd = new Dele();

            hi haris = dd.mul;
             haris(10,20);
            hi har=dd.add;
            har(100, 20);

           
        }

    }
}
