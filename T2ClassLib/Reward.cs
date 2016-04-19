using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2ClassLib
{
    class Reward
    {
        //members
        private int rewardId;
        private double discountRate;
        private DateTime expDate;

        //constructors
        public Reward()
        {
            rewardId = 67876;
            discountRate = .15;
            expDate = DateTime.Now;
        }

        //properties

        public int RewardId
        {
            get { return rewardId; }
            set { RewardId = value; }
        }

        public double DiscountRate
        {
            get { return discountRate; }
            set { DiscountRate = value; }
        }

        public DateTime ExpDate
        {
            get { return expDate; }
            set { ExpDate = value; }
        }
    }
}
