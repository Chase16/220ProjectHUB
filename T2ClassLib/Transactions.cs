using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2ClassLib
{
    class Transactions
    {
        //members
        private int transId;
        private DateTime rentDate;
        private DateTime dueDate;
        private double totalPrice;

        //constructors
        public Transactions()
        {
            transId = 7254;
            rentDate = DateTime.Now;
            dueDate = DateTime.Now;
            totalPrice = 10.00;
        }

        //properties
        public int TransId
        {
            get { return transId; }
            set { TransId = value; }
        }

        public DateTime RentDate
        {
            get { return rentDate; }
            set { RentDate = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { DueDate = value; }
        }

        public double TotalPrice
        {
            get { return totalPrice; }
            set { TotalPrice = value; }
        }
    }
}
