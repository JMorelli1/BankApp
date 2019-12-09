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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            try
            {
                customer.CustomerID = txtUserID.Text;
                customer.selectCustomer();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error entering username0" + error);
            }
            if(txtUserID.Text.Equals(customer.CustomerID) && txtPassword.Text.Equals(customer.Password))
            {
                CustomerLandingPage customerPage = new CustomerLandingPage(customer);
                customerPage.Show();
                this.Hide();
            }
            else if (txtUserID.Text.Equals("admin") && txtPassword.Text.Equals("123"))
            {
                AdminLandingPage adminPage = new AdminLandingPage();
                adminPage.Show();
                this.Hide();
            }
            else
            {
                lbError.Text = "Incorrect UserId or Password entered. \n Please try again";
            }
        }
    }
}
