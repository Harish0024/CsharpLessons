using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace newproject.Day2
{
     class Click 
    {
       public int roll;
        public String name;

        public Click()
        {
        }

        public Click(int roll, string name)
        {
            this.roll = roll;
            this.name = name;
        }
        public void SetData()
        {
            Console.WriteLine("enter roll");
            roll=int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
        }
        public void GetData()
        {
            Console.WriteLine("roll"+roll);
            Console.WriteLine("name"+name);
        }
    }
    
}
