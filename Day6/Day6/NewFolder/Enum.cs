using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.NewFolder
{
    internal class Enuml
    {


        public static void Mental()
        {
          List<Enum> list = new List<Enum>();
            
        Enum e1=new Enum() { Id = 11, name = "harish", salary = 1000 };
            list.Add(e1);
            
            Console.WriteLine("length"+list.Count);
            Console.WriteLine("" + list.Capacity);
            list.Add(new Enum() { Id=12,name="nimal",salary=1200});
            list.Add(new Enum() { Id=13,name="shriman",salary=1400});
            list.Add(new Enum() { Id = 14, name = "lohi", salary = 1500 });
            foreach(Enum e2 in list)

            {

                Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e2.Id, e2.name, e2.salary);

            }

        }

    }
}
