using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class UserAccount
    {
        protected string full_name, user_password, user_name;

        public UserAccount(string Name, string Uname, string pass)
        {
            this.full_name = Name;
            this.user_password = Uname;
            this.user_password = pass;
        }

        public abstract bool validateLogin(string Uname, string password);




    }
}
