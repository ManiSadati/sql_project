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
    public partial class Shop : Form
    {
        private customer custi;
        public Shop(customer cs)
        {
            this.custi = cs;
            InitializeComponent();
            this.Text = "فروشگاه";
            label10.Text = "888";
            maskedTextBox1.Text = "0";
            textBox2.Text = "0";
            label11.Text = this.custi.credit.ToString();


            List<string> MyList2 = new List<string>();
            List<string> MyList = new List<string>();
            foreach(product x in product.list())
            {
                if(x.dname == "ticket")
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
            label534.ForeColor = ThemeColor.PrimaryColor;
            label1fd.ForeColor = ThemeColor.PrimaryColor;
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            product x1 = product.find("ticket", comboBox1.Text);
            product x2 = product.find(comboBox2.Text, "");
            x1.remain -= Convert.ToInt32(maskedTextBox1.Text);
            x2.remain -= Convert.ToInt32(textBox2.Text);
            x1.nsell += Convert.ToInt32(maskedTextBox1.Text);
            x2.nsell += Convert.ToInt32(textBox2.Text);
            foreach (club clb in club.list())
            {
                clb.income += Convert.ToInt32(maskedTextBox1.Text) * x1.price;
                clb.income += Convert.ToInt32(textBox2.Text) * x2.price;
                clb.update();
            }
          
            x1.update();
            x2.update();
            this.custi.credit -= Convert.ToInt32(label10.Text);
            this.custi.update();
            MessageBox.Show("DONE");
            label11.Text = this.custi.credit.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int costs = 0;
            product x1 = product.find("ticket", comboBox1.Text);
            int numb1 = Convert.ToInt32(maskedTextBox1.Text);
            product x2 = product.find(comboBox2.Text, "");
            int numb2 = Convert.ToInt32(textBox2.Text);
            if(x1.remain < numb1)
            {
                maskedTextBox1.Text = "0";
                MessageBox.Show("Select lower amount of tickets!");
            }
            if (x2.remain < numb2)
            {
                textBox2.Text = "0";
                MessageBox.Show("Select lower amount of product!");
            }
            costs += x1.price * numb1;
            costs += x2.price * numb2;
            label10.Text = costs.ToString();
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
