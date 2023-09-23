using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject.Day2
{
    internal class Book
    {
        public  int Bookno { get; set; }
        public string Title { get; set; }=String.Empty;
        public string Edition { get; set; }=String.Empty;
        public string Description { get; set; } = String.Empty;

        public int Row { get; set; }
        public string Authorname { get; set; } = String.Empty;

        public override string ToString()
        {
            return $"Bookno={Bookno}\n" +$" Title={Title}\n" +$"Description={Description}\n"+
            $"Authorname={Authorname},Row={Row}"+$"Edsion={Edition}";
        }
    }

    internal class search
    {
        public static void store()
        {
            Book look = new Book();
            look.Bookno = 1987;
            look.Title = "PS one";
            look.Description = "story books";
            look.Authorname = "Nimal sugar";
            look.Row = 17;
            look.Edition = "New";
            string value=look.ToString();
            Console.WriteLine(value);
        }
    }
}
