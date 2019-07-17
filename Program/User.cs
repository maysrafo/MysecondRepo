using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class User
    {
        public string firstName;
        public string lastName;
        public string userID;
 

        public User(string FirstName,string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;

        }

        public User(string FirstName, string LastName,string userID)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.userID = userID;

        }

        public string GetUserInfo()
        {
            string userName = $"{ firstName } {lastName}, {userID}";
            return userName;
        }
    }
}
