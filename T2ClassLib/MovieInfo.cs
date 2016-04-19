using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2ClassLib
{
    class MovieInfo
    {
        private int movieId;
        private string movieTitle;
        private string genre;
        private DateTime releaseDate;
        private int runTime;
        private string rating;
        private int daysForRent;

        public MovieInfo()
        {
            movieId = 6789;
            movieTitle = "Steve Jobs";
            genre = "Drama";
            releaseDate = DateTime.Now;
            runTime = 130;
            rating = "PG-13";
            daysForRent = 5;
        }

        public int MovieID
        {
            get { return movieId; }
            set { MovieID = value; }
        }

        public string MovieTitle
        {
            get { return movieTitle; }
            set { MovieTitle = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { Genre = value; }
        }

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { ReleaseDate = value; }
        }

        public int RunTime
        {
            get { return runTime; }
            set { RunTime = value; }
        }

        public string Rating
        {
            get { return genre; }
            set { Genre = value; }
        }

        public  int DaysForRent
        {
            get { return daysForRent; }
            set { DaysForRent = value; }
        }

        
    }
}
