using System;
using System.Collections.Generic;
using System.Text;

namespace db_chat
{
    public class Users
    {
        private string username;
        private string password;

        public Users(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public String UserName
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
