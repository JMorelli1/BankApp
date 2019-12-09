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
    public partial class AdminLandingPage : Form
    {
        public AdminLandingPage()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateCustomer createPage = new CreateCustomer();
            createPage.Show();
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer deletePage = new DeleteCustomer();
            deletePage.Show();
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
