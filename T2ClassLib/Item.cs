using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2ClassLib
{
    class Item
    {
        //members
        private int itemID;
        private string itemStatus;
        private int timeRented;

        //constructors
        public Item()
        {
            itemID = 2987;
            itemStatus = "Rented";
            timeRented = 5;
        }

        //properties
        public int ItemId
        {
            get { return itemID; }
            set { ItemId = value; }
        }

        public string ItemStatus
        {
            get { return itemStatus; }
            set { ItemStatus = value; }
        }

        public int TimeRented
        {
            get { return timeRented; }
            set { TimeRented = value; }
        }
            
    }
}
