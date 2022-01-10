using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject.AdmForms
{
    public partial class FinancialForm : Form
    {
        public FinancialForm()
        {
            InitializeComponent();
            this.Text = "اطلاعات مالی";
            LoadTheme();
            List<string> MyList2 = new List<string>();
            List<string> MyList = new List<string>();
            foreach (product x in product.list())
            {
                if (x.dname == "ticket")
                {
                    MyList.Add(x.date_time);
                }
                else
                {
                    MyList2.Add(x.dname);
                }
            }
            comboBox1.DataSource = MyList;
            comboBox2.DataSource = MyList2;
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
            label1fd.ForeColor = ThemeColor.SecondaryColor;
            label534.ForeColor = ThemeColor.SecondaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
        }

        private void FinancialForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            product x = product.find("ticket", comboBox1.Text);
            product y = product.find(comboBox2.Text, "");
            label12.Text = x.nsell.ToString();
            label9.Text = y.nsell.ToString();
            label11.Text = (x.nsell * x.price).ToString();
            label10.Text = (y.nsell * y.price).ToString();
            label13.Text = club.list()[0].income.ToString();
        }
    }
}
