using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Day5
{
    public enum City { Chennai,Bangalore,Hyderbad,Pune}//list of constants
    public enum Designation { Manager,Admin,Developer}
    internal class Employee
    {
        public readonly int Id;//value only can be assigned by constructor it can not canged once it is assigned
        public string Name;
        public City Ecity;
        public Designation JobTittle;

        public Employee(int v1) { Id = v1; } //id is readonly it is asigned by constructor
        public override string ToString()
        {
            string output = string.Empty;
            output = $"detail of employee Id={Id} name={Name} {Ecity} {JobTittle}";
            return output;
        }
    }   class TestEmployee
    {
        public static void TestOne()
        {
            Employee emp = new Employee(122);
            //e1.id=123 it cant be assigned by object
            emp.Name = "Harish";
            emp.Ecity = City.Chennai;
            emp.JobTittle = Designation.Manager;
            string output = emp.ToString();
            Console.WriteLine(output);
        }
    }
        class TestEnum
        {

            public static void TestMovieRating()
            {
                Type t1 = typeof(Deserts);//it is a inbuilt data type //t1 gives reference of metadata
                String[] enumNames = Enum.GetNames(t1);//whenever creating enum always give value for it
                String name = String.Empty;
                int len = enumNames.Length;
                for (int i = 0; i < len; i++)
                {
                    name = enumNames[i];
                    MovieRating movies = (MovieRating)Enum.Parse(t1, name);
                    Console.WriteLine(name + " " + (int)movies);
                }
            }

        }
}


