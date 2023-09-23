using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Day4
{
    internal abstract class Vehicle//abstract classes must be inherited
        
    {
        public Vehicle()
        {
            Console.WriteLine("vehicle constructor");
        }
        public abstract void Start();
        
    }
    internal class Car:Vehicle 
    {
        public Car()
        {
            Console.WriteLine("car constructor");
        }
        public override void Start()
        {
            Console.WriteLine("hi");
        }
    }
    class VehicleTest
    {
        public static void TestOne()
        {
           
            //abstract classes must be inherited
            Vehicle tester=new Car();//parent is clled from child
            tester.Start();
            
        }
    }
    //end of class
    //it is not compulsory to have a abstract method in abstract class
}
