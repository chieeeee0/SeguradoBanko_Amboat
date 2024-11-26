using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguradoBanko
{
    public partial class PayBills : Form
    {
        BankAccount account = null;
        public PayBills()
        {
            InitializeComponent();
        }
        public PayBills(BankAccount account)
        {
            this.account = account;
        }

        private void PayBills_Load(object sender, EventArgs e)
        {
            lblBillsFullname.Text = account.Fullname;
            lblBillsBalance.Text = "₱ " + Convert.ToString(account.Balance);
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            PayBills1 pay1 = new PayBills1();
            pay1.Show();
            this.Hide();
        }
    }
}
