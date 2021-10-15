using System;
using System.Collections.Generic;
using System.Text;

namespace Authenthication
{
    class Employee : User
    {
        public Employee(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password)
        { this.isAdmin = false; }

    }
}
