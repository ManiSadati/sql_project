using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEmailHome.Text == "admin.admin" && txtPasswordHome.Text == "admin"){
                this.Hide();
                AdminForm ADM = new AdminForm();
                ADM.ShowDialog();
                return;
            }
            if (txtEmailHome.Text == "user.user" && txtPasswordHome.Text == "user")
            {
                this.Hide();
                CustomerForm CSF = new CustomerForm();
                CSF.ShowDialog();
                return;
            }

            string email = txtEmailHome.Text;
            string password = txtPasswordHome.Text; 
            customer c = customer.find(email, password);
            if (c != null)
            {
                this.Hide();
                CustomerForm CSF = new CustomerForm(c);
                CSF.ShowDialog();
                return;
            }
            else
            {
                txtEmailHome.Text = "";
                txtPasswordHome.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignUPForm SUP = new SignUPForm();
            this.Hide();
            SUP.ShowDialog();
            return;
            
        }
    }
}
