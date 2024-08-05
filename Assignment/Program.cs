namespace Assignment
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 01
            #region 1.  Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:
            //Class Book 
            //Class BookFunctions

            List<Book> books = new List<Book>
            {
            new Book("1234316", "Book Title 1", new string[] { "Auther 1" }, new DateTime(2023, 1, 1), 40.99m),
            new Book("1234123" , "Book Title 2", new string[] { "Auther 2", "Author 3" }, new DateTime(2024, 5, 12), 50m)
            };


            #endregion

            #region 2. You need to parameterize ProcessBooks function to accept BookFunctions Methods using following cases: 

            //a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            Func<Book, string> getTitleFunc = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, getTitleFunc);

            //b) Use the Proper build in delegate.
            Func<Book, string> getAuthorsFunc = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, getAuthorsFunc);

            //c) Anonymous Method (GetISBN).
            LibraryEngine.ProcessBooks(books, delegate (Book book) { return book.ISBN; });

            //d) Lambda Expression (GetPublicationDate).
            LibraryEngine.ProcessBooks(books, book => book.PublicationDate.ToShortDateString());
            #endregion



        }
    }
}
