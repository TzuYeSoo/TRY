using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchasedDiscountedItem : Form
    {
        public frmPurchasedDiscountedItem()
        {
            InitializeComponent();
        }
        private item cs;
        private void Compute_Disc_Click(object sender, EventArgs e)
        {
            cs = new item(itemName.Text, Convert.ToDouble(txPriced.Text), Convert.ToInt16(txQuan.Text), Convert.ToDouble(Disc.Text));
            TotalPrice.Text = cs.getTotalPrice().ToString();   
        }

        private void frmPurchasedDiscountedItem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cs.setPayment(Convert.ToDouble(textBox1.Text));
            ChangeCus.Text = cs.getChange().ToString();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount f1 = new frmLoginAccount();
            f1.Show();
            this.Hide();
        }

        private void exitApplicaationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
