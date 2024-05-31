using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

            Cashier user = new Cashier("Jessie Samaniego","Cashier", users.Text, pass.Text);

            if (user.validateLogin(users.Text, pass.Text))
            {
                frmPurchasedDiscountedItem frm = new frmPurchasedDiscountedItem();
                frm.Show();
                this.Hide();
            }
        }
    }
}
