using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CleanLoad
{
    public class ULAccount
    {
        private string username;
        private string password;
        
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public ULAccount(string user, string pw)
        {
            username = user;
            password = pw;
        }
    }
}
