using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2ClassLib
{
    public class Account
    {
        //members
        private int acctId;
        private string memberStatus;
        private long cardNum;
        private int cVV;
        private string pmtType;
        
        //Constructors
        public Account()
        {
            acctId = 54321;
            memberStatus = "Gold";
            cardNum = 0987654321456789;
            cVV = 876;
            pmtType = "Monthly";
        }

     
        //Encapsulation

        public int  AcctID
        {
            get {return acctId; }
            set {AcctID = value; }
        }

        public string MemberStatus
        {
            get { return memberStatus; }
            set { MemberStatus = value; }
        }

        public long CardNum
        {
            get { return cardNum; }
            set { CardNum = value; }
        }

        public int CVV
        {
            get { return cVV; }
            set { CVV = value; }
        }

        public string PmtType
        {
            get { return pmtType; }
            set { PmtType = value; }
        }


    }
}
