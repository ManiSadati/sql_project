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
    public partial class SignUPForm : Form
    {
        public SignUPForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int credit = 0;
            string address = textBox2.Text;
            string id = textBox1.Text;
            string email = txtPasswordHome.Text;
            string name = txtEmailHome.Text;
            string password = textBox3.Text;
            customer cs = new customer(id,name, email, password, address,credit);
            cs.insert();
            this.Hide();
            SignInForm form = new SignInForm();
            form.ShowDialog();
        }
    }
}
