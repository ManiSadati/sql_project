using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject.CustForms
{
    public partial class CustomerSetting : Form
    {
        private customer custi;
        public CustomerSetting(customer cs)
        {
            InitializeComponent();
            this.Text = "تنظیمات";
            this.custi = cs;
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label1.ForeColor = ThemeColor.PrimaryColor;
        }

        private void CustomerSetting_Load(object sender, EventArgs e)
        {
            LoadTheme();
            label13.Text = this.custi.email;
            txtNameHome.Text = this.custi.dname;
            textBox3.Text = this.custi.ID.ToString();
            textBox2.Text = this.custi.addres;
            txtPasswordHome.Text = this.custi.pass;
            label12.Text = this.custi.credit.ToString();

        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            this.custi.dname = txtNameHome.Text;
            this.custi.ID = textBox3.Text;
            this.custi.addres = textBox2.Text;
            this.custi.pass = txtPasswordHome.Text;
            this.custi.update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            this.custi.credit += x;
            this.custi.update();
            label12.Text = this.custi.credit.ToString();
        }

        private void btndetele_Click(object sender, EventArgs e)
        {
            this.custi.Delete();
            this.Hide();
            SignInForm form = new SignInForm();
            form.ShowDialog();
        }
    }
}
