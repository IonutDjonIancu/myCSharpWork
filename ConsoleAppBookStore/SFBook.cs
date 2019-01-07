using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SFBook : Book
    {
        public SFBook(string aTitle, string aAuthor, int aPages) : base(aTitle, aAuthor, aPages)
        {
        }

        public void SFBookCoverArt()
        {
            Console.WriteLine(title + " has a cool SF book art on cover.");
        }

        public override void BookCover()
        {
            Console.WriteLine(title + " has now a cover which includes the number " + pages + " as artwork.");
        }


    }
}
