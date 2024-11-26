using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguradoBanko
{
    public partial class PayBills1 : Form
    {
        BankAccount account = null;
        public PayBills1()
        {
            InitializeComponent();
        }
        public PayBills1(BankAccount account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (account.PayBillsMethod(chkBiller.Text, txtBillsAccountID.Text, Convert.ToInt32(txtBillsAmount.Text)))
            {
               DialogResult dialog =  MessageBox.Show($"     RECEIPT      \nAccount Holder: {account.Fullname} \nBiller: {chkBiller} \nAmount: {txtBillsAmount.Text} \n\n\n\nReference No. 209320-2392", "Segurado Banko", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    txtBillsAccountID.Clear();
                    txtBillsAmount.Clear();
                    chkBiller.Focus();
                }
            }
        }
    }
}
