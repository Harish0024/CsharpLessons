using Lesson8.Day8;


// C# program to illustrate the
// concept of nested class
// accessing non-static member
// of the outer class
//using System;

//// Outer class
//public class Outer_class
//{

//    // Non-static data
//    // member of outer class
//    public int number = 1000000;

//    // Inner class
//    public class Inner_class
//    {

//        // Static method of Inner class
//        public static void method1()
//        {
//            // Creating the object of the outer class
//            Outer_class obj = new Outer_class();

//            // Displaying the value of a
//            // static member of the outer class
//            // with the help of obj
//            Console.WriteLine(obj.number);
//        }
//    }
//}

//// Driver Class
//public class GFG
//{

//    // Main method
//    static public void Main()
//    {

//        // Accessing static method1
//        // of inner class
//        Outer_class.Inner_class.method1();
//    }
//}
using System;
using System.Text;

class GFG
{

    // Main Method
    public static void Main()
    {

        // "20" is capacity
        StringBuilder s = new StringBuilder("HELLO ", 20);

        s.Append("GFG");

        // after printing "GEEKS"
        // a new line append
        s.AppendLine("GEEKS");

        s.Append("GeeksForGeeks");
        Console.WriteLine(s);
    }
}