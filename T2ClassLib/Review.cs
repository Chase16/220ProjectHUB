using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2ClassLib
{
    class Review
    {
        //members
        private int reviewId;
        private string comment;
        private int starRating;

        //constructors
        public Review()
        {
            reviewId = 876345;
            comment = " ";
            starRating = 4;
        }

        //properties

        public int ReviewId
        {
            get {return reviewId; }
            set { ReviewId = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { Comment = value; }
        }

        public int StarRating
        {
            get { return starRating; }
            set { StarRating = value; }
        }
    }
}
