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

            //List<Book> books = new List<Book>
            //{
            //new Book("1234316", "Book Title 1", new string[] { "Auther 1" }, new DateTime(2023, 1, 1), 40.99m),
            //new Book("1234123" , "Book Title 2", new string[] { "Auther 2", "Author 3" }, new DateTime(2024, 5, 12), 50m)
            //};


            #endregion

            #region 2. You need to parameterize ProcessBooks function to accept BookFunctions Methods using following cases: 


            //List<Book> books = new List<Book>
            //{
            //new Book("1234316", "Book Title 1", new string[] { "Auther 1" }, new DateTime(2023, 1, 1), 40.99m),
            //new Book("1234123" , "Book Title 2", new string[] { "Auther 2", "Author 3" }, new DateTime(2024, 5, 12), 50m)
            //};

            ////a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            //Func<Book, string> getTitleFunc = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(books, getTitleFunc);

            ////b) Use the Proper build in delegate.
            //Func<Book, string> getAuthorsFunc = BookFunctions.GetAuthors;
            //LibraryEngine.ProcessBooks(books, getAuthorsFunc);

            ////c) Anonymous Method (GetISBN).
            //LibraryEngine.ProcessBooks(books, delegate (Book book) { return book.ISBN; });

            ////d) Lambda Expression (GetPublicationDate).
            //LibraryEngine.ProcessBooks(books, book => book.PublicationDate.ToShortDateString());
            #endregion

            //Part 02
            #region 1. We need to Implement the List methods from scratch with all overloads.


            //    List<Book> books = new List<Book>
            //    {
            //    new Book("1234316", "Book Title 1", new string[] { "Auther 1" }, new DateTime(2023, 1, 1), 39.99m),
            //    new Book("1234123" , "Book Title 2", new string[] { "Auther 2", "Author 3" }, new DateTime(2024, 5, 12), 50m)
            //    };

            //    // Exist
            //    bool exists = books.Exists(b => b.Title == "Book Title 1");
            //    Console.WriteLine($"Book Title 1 exists: {exists}");

            //    // Find
            //    Book foundBook = books.Find(b => b.Title == "Book Title 2");
            //    Console.WriteLine($"Found book: {foundBook}");

            //    // FindAll
            //    var allBooks = books.FindAll(b => b.Price > 20);
            //    Console.WriteLine("Books with price > 20:");
            //    foreach (var book in allBooks)
            //            Console.WriteLine(book);


            //    // FindIndex
            //    int index = books.FindIndex(b => b.Title == "Book Title 2");
            //    Console.WriteLine($"Index of 'Book Title 2': {index}");

            //    // FindLast
            //    Book lastBook = books.FindLast(b => b.Price > 20);
            //    Console.WriteLine($"Last book with price > 20: {lastBook}");


            //    // FindLastIndex
            //    int lastIndex = books.FindLastIndex(b => b.Price > 20);
            //    Console.WriteLine($"Last index of book with price > 20: {lastIndex}");

            //    // ForEach
            //    Console.WriteLine("ForEach example:");
            //    books.ForEach(b => Console.WriteLine(b.Title));


            //    // TrueForAll
            //    bool allAbove20 = books.TrueForAll(b => b.Price > 20);
            //    Console.WriteLine($"All books priced above 20: {allAbove20}");


            #endregion

        }
    }
    
}
