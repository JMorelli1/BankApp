using System;
using System.Collections;
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
    public partial class DeleteCustomer : Form
    {
        Customer customer;
        ArrayList allCustomers;
        String selectedCustomer;
        public DeleteCustomer()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            loadCustomers();
        }

        public void loadCustomers()
        {
            customer = new Customer();
            allCustomers = customer.selectAllCustomers();

            dgAllCustomers.AllowUserToAddRows = false;
            DataGridViewRow rows;
            for (int i = 0; i < allCustomers.Count; i++)
            {
                rows = new DataGridViewRow();
                rows.CreateCells(dgAllCustomers);
                rows.Cells[0].Value = allCustomers[i];
                rows.Cells[1].Value = "Select";
                dgAllCustomers.Rows.Add(rows);
            }
            dgAllCustomers.CellClick += new DataGridViewCellEventHandler(DGCustomers_CellClick);
        }
        public void DGCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex != dgAllCustomers.Columns["SelectedCustomer"].Index)
            {
                return;
            }

            selectedCustomer = dgAllCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbConfirmation.Text = "Select Customer ID is: " + selectedCustomer + "\n Are you sure you wish to delete this customer?";
            btnDelete.Enabled = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminLandingPage back = new AdminLandingPage();
            back.Show();
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            customer.CustomerID = selectedCustomer;
            customer.deleteCustomer();
            dgAllCustomers.Rows.Clear();
            loadCustomers();
        }
    }
}
