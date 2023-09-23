// See https://aka.ms/new-console-template for more information

//only one executive project and many library 
using LibraryA;
Book book = new Book();
book.Title = "To kill a mocking bird";
book.Author = "harper lee";
book.Genere = "Social";
book.DateofPublish = new DateTime(1995, 06, 01);
book.BookmarkPage(125);
Console.WriteLine(book.GetCurrentPage());
Calculator calculator = new Calculator();
int addresult = calculator.Add(100, 40);
Console.WriteLine(addresult);
int multiplyresult = calculator.Multiply(100, 40);
Console.WriteLine(multiplyresult);
int divideresult = calculator.Divide(100, 40);
Console.WriteLine(divideresult);