namespace LibraryA
{
    public class Book
    {
        public string Title=string.Empty;
        public string Author = string.Empty;
        public string Genere = string.Empty;
        public DateTime DateofPublish;
        public int BookPrice;
        public int TotalPages=300;
       
        public void OpenBook()
        {
            Console.WriteLine("book is open");
        }
        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"page no:{pageNo}Bookmarked");
        }
        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }


    }
}