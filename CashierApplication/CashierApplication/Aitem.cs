using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class Aitem
    {

        protected int Quanaity;
        protected double Total_Price;
        protected double item_price;
        protected string item_name;

        public abstract double getTotalPrice();
        public abstract double getChange();

        public abstract void setPayment(double amount);


    }
}
