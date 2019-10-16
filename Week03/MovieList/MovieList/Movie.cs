using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title;
        public int ReleaseYear;
        private string director;
        private string genre;
        private int time;

        public Movie(string title, int releaseYear)
        {
            Title = title;
            ReleaseYear = releaseYear;
            
        }

        public Movie(string title, int releaseYear, string director, string genre, int time) : this(title, releaseYear)
        {         
            this.director = director;
            this.genre = genre;
            this.time = time;
        }

        public void ShowDetails()
        {
            MessageBox.Show(Title + " was released in " + ReleaseYear);
        }


    }
}
