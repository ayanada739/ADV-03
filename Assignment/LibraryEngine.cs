using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate string BookFunctionDelegate(Book book);
    public class LibraryEngine

    { 

        public static void ProcessBooks(List<Book> bList, Func<Book, string> fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }
    }
}
