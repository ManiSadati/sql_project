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
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
            this.Text = "فروشگاه";
            LoadTheme();
            List<string> list = new List<string>();
            foreach (product s in product.list())
            {
                if(s.dname == "ticket")
                {
                    list.Add(s.date_time);
                }
            }
            comboBox1.DataSource = list;
            List<string> list2 = new List<string>();
            foreach (product s in product.list())
            {
                if (s.dname != "ticket")
                {
                    list2.Add(s.dname);
                }
            }
            comboBox2.DataSource = list2;
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
            label1fd.ForeColor = ThemeColor.SecondaryColor;
            label534.ForeColor = ThemeColor.SecondaryColor;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = comboBox1.Text;
            string id = maskedTextBox6.Text;
            int numb = Convert.ToInt32(maskedTextBox1.Text);
            int price = Convert.ToInt32(maskedTextBox2.Text);
            product x = new product();
            x = product.find("ticket", date);
            if(x == null)
            {
                x = new product(id,price,"ticket",0,numb,date,0);
                x.insert();
            }
            else
            {
                x.price = price;
                x.remain += numb;
                x.update();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            string name = comboBox2.Text;
            string id = maskedTextBox5.Text;
            int numb = Convert.ToInt32(maskedTextBox3.Text);
            int price = Convert.ToInt32(maskedTextBox4.Text);
            product x = new product();
            x = product.find(name, "");
            if (x == null)
            {
                x = new product(id, price, name, 0, numb, "",0);
                x.insert();
            }
            else
            {
                x.price = price;
                x.remain += numb;
                x.update();
            }
        }
    }
}
