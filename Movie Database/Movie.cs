using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    internal class Movie
    {
  

        public string Title { get; set; }
        public string Category { get; set; }


        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public string DisplayCategories()
        {
            return $"Title: {Title}, Category: {Category}";

        }
        
           

        
    }
}





