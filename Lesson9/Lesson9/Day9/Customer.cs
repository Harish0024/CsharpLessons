using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9.Day9
{
    [Serializable]
    internal class Customer//:ISerializable
    {
        private readonly double ID;
        public string Title;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double CreditLimit { get; set; }
        public Customer(double v1) { ID=v1; }
        public double GetId() { return ID; }
        public string ToString()
        {
            return $"Details:{ID}{FirstName}{MiddleName}{LastName}{CreditLimit}";
        }
    }
}
