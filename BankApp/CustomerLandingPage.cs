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
    public partial class CustomerLandingPage : Form
    {
        Customer customer;
        public CustomerLandingPage(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            lbWelcome.Text = "Welcome " + customer.FirstName + "!";
            loadAccounts();
        }

        public void loadAccounts()
        {
            customer.findAccounts();
            DataGridViewRow dgRow;
            dgAccounts.AllowUserToAddRows = false;
            for (int i = 0; i < customer.acctList.getSize(); i++)
            {
                dgRow = new DataGridViewRow();
                dgRow.CreateCells(dgAccounts);
                dgRow.Cells[0].Value = customer.acctList.getAccount(i).AccountNumber;
                dgRow.Cells[1].Value = customer.acctList.getAccount(i).Type;
                dgRow.Cells[2].Value = customer.acctList.getAccount(i).Balance;
                dgRow.Cells[3].Value = "Withdraw/Deposit";
                dgAccounts.Rows.Add(dgRow);
            }
            dgAccounts.CellClick += new DataGridViewCellEventHandler(DGAccounts_CellClick);
        }
        private void DGAccounts_CellClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgAccounts.Columns["Deposit"].Index)
            {
                return;
            }

            String AccountNum = dgAccounts.Rows[e.RowIndex].Cells[0].Value.ToString();
            WDBalancePage balancePage = new WDBalancePage(AccountNum, customer);
            balancePage.Show();
            this.Hide();
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount(customer);
            createAccount.Show();
            this.Close();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Close();
        }
    }
}
