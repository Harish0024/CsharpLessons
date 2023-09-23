using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.NewFolder
{
    internal class Second
    {
        public int Id;
        public static void Num() 
        {
            List<Emp> list = new List<Emp>();
            Emp s1 = new Emp(){ ID=1, Name = "harish", Salary = 1000 };
            
            list.Add(s1);
            list.Add(new Emp() {ID=2, Name="shriman",Salary=2000});
            foreach(Emp emp in list)
            {
                Console.WriteLine($"id={0},name={1},salary={2}"+emp.ID,emp.Name,emp.Salary);
            }


        }
        public static void GenericListInteger()
        {
            List<int> alist = new List<int>();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);



            for (int i = 0; i < 10; i++)
                alist.Add(i);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);



            //for (int j = 0; j < 10; j++)
            //    alist.Add("abcd" + j);





            for (int i = 0; i < count; i++)
            {
                Console.Write(alist[i] + ",");
            }
        }


    }
}
