using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    
    internal class Cashier : UserAccount
    {
        private string department;

        public Cashier(string Name, string deparment, string uName, string password) : base(Name, uName, password)
        {

        }
        public override bool validateLogin(string Uname, string password)
        {
            if (Uname.Equals("Jessie") && password.Equals("Pogi"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getDepartment()
        {
            return department;
        }
        public string getFullName()
        {
            return full_name;
        }
    }
}
