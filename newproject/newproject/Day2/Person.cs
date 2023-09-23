using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject.Day2
{
    internal class Person
    {
        public int Id { get; set; }//it get initialized so that it doestnt throw Null
        public string Name { get; set; } = String.Empty;
        public string FirstName { get; set; }=String.Empty;
        public string LastName { get; set; }= String.Empty;
        public string Title { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Region { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public long Phone { get; set; }
        public override string ToString()
        {
            return $"ID:{this.Id},Name:{FirstName}{LastName}{Title},\n" + $"Address:{Address},Cit:{City},Region:{Region}\n" +
                $" Phone:{Phone},Country:{Country}";
        }
    }
    internal class TestPerson
    {
        public static void Testone()
        {
            Person firstperson = new Person();
            firstperson.Id = 1;
            firstperson.FirstName = "harish";
            firstperson.Title = "Mr";
            firstperson.LastName = "v";
            firstperson.Address = "chennai";
            firstperson.City = "poonamallee";
            firstperson.Region = "nil";
            firstperson.Country = "India";
            firstperson.Phone = 8667454215;
            String value=firstperson.ToString();
            Console.WriteLine(value);

        }
    }
}
