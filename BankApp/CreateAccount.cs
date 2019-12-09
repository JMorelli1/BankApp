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
    public partial class CreateAccount : Form
    {
        Customer customer;
        public CreateAccount(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account();
            int acct = (90001 + newAccount.countAccounts());
            newAccount.AccountNumber = acct.ToString();
            newAccount.Type = cbType.SelectedItem.ToString();
            newAccount.Balance = Double.Parse(txtBalance.Text);
            newAccount.CustomerID = customer.CustomerID;

            newAccount.insertAccount();

            CustomerLandingPage customerPage = new CustomerLandingPage(customer);
            customerPage.Show();
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CustomerLandingPage customerPage = new CustomerLandingPage(customer);
            customerPage.Show();
            this.Close();
        }
    }
}
