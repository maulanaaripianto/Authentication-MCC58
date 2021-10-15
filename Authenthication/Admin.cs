using System;
using System.Collections.Generic;
using System.Text;

namespace Authenthication
{
    class Admin : User
    {
        public Admin(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password)
        { this.isAdmin = true; }
    }
}
