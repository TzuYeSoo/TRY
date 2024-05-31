using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class AUserAccount
    {
        public abstract bool validateLogin(string Uname, string password);


    }
}
