using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBrandsHub
{
    internal class UserDetails
    {
        public string Fullname;
        public string UserName; 
        public int ID; 
        public string Password;
        public decimal Wallet;
        public UserDetails() { }
        public UserDetails(string fullName, string userName, int iD, string password, decimal wallet)
        {
            Fullname= fullName; 
            UserName= userName;
            ID= iD;
            Password= password;
            Wallet= wallet;
        }
    }
}
