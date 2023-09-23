using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Day4
{
    internal abstract class Book
    {
        public Book() 
        {
            Console.WriteLine("book constructor");
        }
        public abstract void OpenBook();//abstaract method inside a abstract class should contain abstract key word
    }
    internal class Ebook:Book 
    {
        public Ebook()
        {
            Console.WriteLine("this is ebook");
        }
        public override void OpenBook()
        {
            Console.WriteLine("Ebook open");
        }
    } 
    internal class Nill
    {
        public Nill()
        {
            Ebook ebook = new Ebook();
            ebook.OpenBook();
        }
    }
}
