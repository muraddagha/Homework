using System;
using System.Collections.Generic;
using System.Text;

namespace _11102020
{
    class Account
    {
         static int _totalNo;
        private int _no;
        public int No { get => _no; }
        public string UserName;
        private string Password;
        public Account(string userName,string password)
        {
            _totalNo++;
            _no = _totalNo;
            this.UserName = userName;
            this.Password = password;
        }
        public Account(string userName)
        {
            _totalNo++;
            _no = _totalNo;
            this.UserName = userName;
            
        }

        public void IsUserNameValid()
        {

        }

        public void IsPasswordValid()
        {

        }
    }
}
