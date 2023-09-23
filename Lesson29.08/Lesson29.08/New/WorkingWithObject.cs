using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._08.New
{
    internal class WorkingWithObject
    {
        //hashcode is clr gives a specific number when an object is called

        public static void TestOne()
        {

            Object objectOne = new object();

            Console.WriteLine($"ToString: {objectOne.ToString()}");

            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");

            Type typeOne = objectOne.GetType();

            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";

            Console.WriteLine($"ToString: {stringData.ToString()}");

            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");

            Type typeTwo = stringData.GetType();

            Console.WriteLine($"Type: {typeTwo.FullName}");

        }
        public static void TestTwo()
            //two obj does not have same hashcode they are autogenerted
            
        {
            Emp empOne=new Emp();
            empOne.ID = 1001;
            Emp empTwo = empOne;//new Emp();
            empTwo.ID = 1001;
            Emp empThree = empOne;// new Emp();
            empThree.ID = 1003;
            bool flag=(empOne.Equals(empTwo));
            Console.WriteLine(flag);
            flag=empOne.Equals(empTwo);
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());

        }
    }
}
