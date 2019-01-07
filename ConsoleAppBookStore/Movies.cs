using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Movies
    {
        public string title;
        public string director;
        private string rating;

        public Movies(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        // property methods
        public string Rating
        {
            // gets the attribute of the class
            get
            {
                return rating;
            }
            // defines specific rules
            set
            {
                if (value.Equals("PG") || value.Equals("PG-13"))
                {
                    rating = value;
                }
                else
                {
                    rating = "Wrong value given";
                }
            }
        }




    }
}
