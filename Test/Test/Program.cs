// See https://aka.ms/new-console-template for more information
using Test.Testing;

namespace Test.Testing
{
    internal class Class1
    {


        class Sample
        {
            int i;
            Single j;
            public void SetData(int i, Single j)
            {
                this.i = i;
                this.j = j;
            }
            public void Display()
            {
                Console.WriteLine(i + " " + j);
            }
        }
        class MyProgram
        {
            static void Main(string[] args)
            {
                Sample s1 = new Sample();
                s1.SetData(36, 5.4f);
                s1.Display();
            }
        }
    }
}



