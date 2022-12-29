using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatch
{
    public class User
    {
        public string password { get; set; }
        public string username { get; set; }    
        public string name_account { get; set; }
        public User()
        {
            password = "";
            username = "";
            name_account = "";
        }
        public User(string pass,string username,string name_Account)
        {
            password = pass;
            this.username = username;
            name_account = name_Account;
        }
    }
}
