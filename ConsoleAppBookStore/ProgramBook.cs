using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // sub-classes include: Book, SFBook, Movies, Reader, BlanksClass
    class ProgramBook
    {
        static void Main(string[] args)
        {
            
            Book dune = new Book("God Emperor of Dune", "Frank Herbert", 700);
            Book lotr = new Book("Silmarillion", "JRR Tolkien", 1300);
            dune.pages = 500;
            Console.WriteLine(dune.pages);
            BlanksClass.Blanks();

            Book myBook = new Book();
            myBook.author = "me";
            myBook.title = "myBook Title";
            myBook.pages = 220;
            Console.WriteLine(myBook.title);
            BlanksClass.Blanks();

            Reader reader1 = new Reader("Gigel", 17.21, 'A');
            Reader reader2 = new Reader("Mark", 20.05, 'B');
            Console.WriteLine(reader1.name + " is reading " + dune.title + " from " + reader1.hour);
            reader1.IsAfter8NoRETURN();
            Console.WriteLine(reader2.name + " is reading " + lotr.title + " from " + reader2.hour);
            Console.WriteLine(reader2.IsAfter8WithRETURN());
            BlanksClass.Blanks();

            reader2.ModifyBookCategory('Y');
            Console.WriteLine(reader2.category);
            BlanksClass.Blanks();

            Movies avengers = new Movies("The Avengers", "Director J", "PG-13");
            Console.WriteLine(avengers.Rating);
            BlanksClass.Blanks();

            Console.WriteLine(Book.bookCount);
            Book.GetBookCount();
            BlanksClass.Blanks();

            Book twoTowers = new Book("The Two Towers", "Author4", 200);
            twoTowers.BookCover();

            SFBook foundation = new SFBook("The Foundation", "Isaac Asimov", 180);
            foundation.SFBookCoverArt();
            foundation.BookCover();
            BlanksClass.Blanks();
            
            Console.ReadLine();
        }

    }
}
