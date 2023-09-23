using Lesson29._08.New.Day8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._08.New.Day8
{
    //Create a class called Car.
    //The Car has a RegistrationNo, Model, FuelType, Wheels[4], and 1 Engine.

    //The FuelType must be an Enum
    //Wheel, and Engine must be INNER Class.

    class Car
    {
        public string RegNum { get; set; }
        public string Model { get; set; }
        public enum FuelType
        {
            Diesel,
            Petrol,
            CNG
        }

        private readonly string Engine;
        private readonly int Wheel;
        public class Wheeel
        {
            public  void Wheel()
            {
                int[] wheel = { 1, 2, 4, 4 };
                foreach (int i in wheel)
                {
                    Console.WriteLine("wheel no" + i);
                }

            }

        }
        public class Enginee
        {
            public  void On()
            {
                Console.WriteLine("engine is started");
            }
            public  void off()
            {
                Console.WriteLine("engine is off");
            }

        }



    }




        class TestEmp
        {
            public static void TestA()
            {

                Car c = new Car();
                Car.Wheeel d = new Car.Wheeel();
                Car.Enginee e = new Car.Enginee();
                c.RegNum = "tn12ak2574";
                c.Model = "KIA";
            
            Console.WriteLine(c.RegNum);
            Console.WriteLine(c.Model);
            d.Wheel();
            e.off();
            e.On();



            }
        }
    
}

