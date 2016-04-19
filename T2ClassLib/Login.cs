using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2ClassLib
{
    class Login
    {
        //members
        private int userId;
        private string userName;
        private string passWord;
        private bool isAdmin;
        private bool newMem;
        
        //constructors
        public Login()
        {
            userId = 77;
            userName = "johnsmith";
            passWord = "RollTide15";
            isAdmin = true;
            newMem = false;
        } 


        //Encapsulation
        public int UserID
        {
            get { return userId; }
            set { UserID = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { UserName = value; }
        }

        protected string PassWord
        {
            get { return passWord; }
            set { PassWord = value; }
        }

        protected bool IsAdmin
        {
            get { return isAdmin; }
            set { IsAdmin = value; }
        }

        public bool NewMem
        {
            get { return newMem; }
            set { NewMem = value; }
        }
    }
}
