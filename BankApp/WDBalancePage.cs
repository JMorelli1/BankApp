using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class WDBalancePage : Form
    {
        Customer customer = new Customer();
        Account tempAccount = new Account();
        public WDBalancePage(String AcctNum, Customer newCustomer)
        {
            InitializeComponent();
            customer = newCustomer;
            tempAccount.AccountNumber = AcctNum;
            tempAccount.selectAccount();

            txtAcccount.Text = "Account Number: " + tempAccount.AccountNumber;
            txtBalance.Text = "Current Balance: " + tempAccount.Balance;
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            double withdrawal = Double.Parse(tbAmount.Text);
            tempAccount.Balance -= withdrawal;
            tempAccount.updateAccount();
            txtBalance.Text = "Current Balance: " + tempAccount.Balance;
            tbAmount.Text = "";
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            double withdrawal = Double.Parse(tbAmount.Text);
            tempAccount.Balance += withdrawal;
            tempAccount.updateAccount();
            txtBalance.Text = "Current Balance: " + tempAccount.Balance;
            tbAmount.Text = "";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CustomerLandingPage customerPage = new CustomerLandingPage(customer);
            customerPage.Show();
            this.Close();
        }
    }
}
