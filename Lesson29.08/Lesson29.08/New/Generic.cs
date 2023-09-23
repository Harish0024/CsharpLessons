using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._08.New
{
    internal class Generic
    {
        class Box
        {
            List<int> noList = new List<int>();
            public void FillList(int from, int to)
            {
                int i = 0;
                for (i = from; i < to; i++)
                {
                    noList.Add(i);
                }
            }
            public List<int> GetList()
            {
                return noList;
            }
        }
        

        class BoxA<T>

        {

            List<T> myList = new List<T>();

            public void FillList(T data)

            {

                myList.Add(data);

            }

            public List<T> GetList()

            {

                return myList;

            }

        }
        

        public static void TestA()

        {

            Box b1 = new Box();

            b1.FillList(10, 110);

            List<int> l = b1.GetList();

            foreach (int x in l)

            {

                Console.WriteLine(x);

            }

        }

        public static void TestB()

        {

            BoxA<string> b1 = new BoxA<string>();

            b1.FillList("Hello");

            List<string> l = b1.GetList();

        }
        

//params - variable length argument

        public static void AddIntParameters(params int[] arguments)

        {

            int add = 0;

            Console.WriteLine("Param Length " + arguments.Length);

            foreach (int argu in arguments)

            {

                add += argu;

            }

            Console.WriteLine(add);

        }

        static void TestAddIntParams()

        {

            AddIntParameters(1);

            AddIntParameters(1, 2, 3, 4, 5);

        }

    }
}
