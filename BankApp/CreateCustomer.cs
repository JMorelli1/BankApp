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
    public partial class CreateCustomer : Form
    {
        Customer customer;
        public CreateCustomer()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            int customerCount = customer.countCustomers();
            customer.CustomerID = (3001 + customerCount).ToString();
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.Address = txtAddress.Text;
            customer.Email = txtEmail.Text;
            customer.Password = txtPassword.Text;

            customer.insertCustomer();

            lbConfirmation.Text = "Customer created successfully!";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminLandingPage backPage = new AdminLandingPage();
            backPage.Show();
            this.Close();
        }
    }
}
