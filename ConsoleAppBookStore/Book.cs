using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        // class attributes
        public string title;
        public string author;
        public int pages;
        // class's static attribute shared accross all objects
        public static int bookCount = 0;

        //class constructors
        public Book()
        {
            bookCount++;
        }

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            Console.WriteLine("Generating new book: " + title);
            bookCount++;
        }

        public static void GetBookCount()
        {
            Console.WriteLine(bookCount);
        }

        public virtual void BookCover()
        {
            Console.WriteLine(title + " has now a cover.");
        }

    }
}




