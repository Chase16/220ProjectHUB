using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2ClassLib
{
    class Member
    {
        //members
        private int memberId;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zipCode;
        private long phoneNum;
        private DateTime dOB;

        //constructors
        public Member()
        {
            memberId = 234;
            firstName = "John";
            lastName = "Smith";
            address = "123 Right Road";
            city = "Tuscaloosa";
            state = "AL";
            zipCode = 35487;
            phoneNum = 2057896543;
            dOB = DateTime.Now;
        }

        public int MemberId
        {
            get { return memberId; }
            set { MemberId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { FirstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { LastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { Address = value; }
        }

        public string City
        {
            get { return city; }
            set { City = value; }
        }

        public string State
        {
            get { return state; }
            set { State = value; }
        }

        public int ZipCode
        {
            get { return zipCode; }
            set { ZipCode = value; }
        }

        public long PhoneNum
        {
            get { return phoneNum; }
            set { PhoneNum = value; }
        }

        public DateTime DOB
        {
            get { return dOB; }
            set { DOB = value; }
        }
    }

   
}
