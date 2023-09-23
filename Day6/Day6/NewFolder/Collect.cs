using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.NewFolder
{//collection are hetrogenous (stack,queues,lists,hash tables)//not a fixed size
    //all collection classes implements IEnumerable interface
    //that is extended by ICollection *interface
    //Idictionary and ilist are also interface for collection which are derived Icollection


    //collection has 2 types namely Dictionary and List
    //Dictionary -the object are memory unorded but for the computer convenience it has a key to find ,like finding book in a library
    //list is ordered in an index like 0,1,2,3
    //interfaces used in collection
    //IEnumerable//IEnumerator//ICollection//IList//IDictionary//IDictionaryEnumerator
    //ArrayList=implements the list interface using an array whole size is dynamically increased
    //queue=represents a first in,firstout collection of data
    //stack=represents a simple last in first out non generic collection of object
    //HastTable  represents a colletion of key/values that are organized based on the hash code of the key
    //Sorted list =represents a collection of key/value pairs cthat are sorted by the keys
    //Iterator{common algo to write through irrespective of the datatype
    //IEnumerable,IEnumerable}
    internal class Collect
    {
       
            public static void TestArrayList()
            {
                ArrayList alist = new ArrayList();
                int count = alist.Count;
                Console.Write("Count " + count);
                Console.WriteLine(" Capacity " + alist.Capacity);// 0
                Random r1 = new Random();
                for (int i = 0; i < 10; i++)
                    alist.Add(r1.Next(10));
                Console.Write("Count " + alist.Count);
                Console.WriteLine(" Capacity " + alist.Capacity);// 16
           

                for (int j = 0; j < 10; j++) alist.Add(j);

            Console.Write("Count " + alist.Count);

            Console.WriteLine(" Capacity " + alist.Capacity);// 32



                 for (int i = 0; i < alist.Count; i++)

                 {

                Console.Write(alist[i] + ",");

                if (i > 0 && i % 10 == 0) Console.WriteLine();

            }


            }
    }

    
}
