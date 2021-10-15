using System;
using System.Collections.Generic;
using System.Text;

namespace Authenthication
{
    class User
    {
        public string lastName;
        protected string password;
        public string firstName;
        public string username;
        public bool isAdmin;
       

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User(string firstName, string lastName, string username, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.password = BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
