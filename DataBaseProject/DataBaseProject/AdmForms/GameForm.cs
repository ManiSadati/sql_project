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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            this.Text = "مسابقات";
            LoadTheme();
            List<string> l = new List<string>();
            foreach (tournament x in tournament.list())
            {
                l.Add(x.dname);
            }
            comboBox2.DataSource = l;
            List<string> l2 = new List<string>();
            foreach (game x in game.list())
            {
                l2.Add(x.date_time);
            }
            comboBox3.DataSource = l2;
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
            label5.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.SecondaryColor;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = maskedTextBox3.Text;
            tournament t = new tournament(name,"", 0, "cup", 0, "21-22");
            t.insert();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            string date_time = comboBox1.Text;
            string opponent = maskedTextBox1.Text;
            string refree = maskedTextBox2.Text;
            tournament t = tournament.find(comboBox2.Text);
            int tourid = t.ID;
            MessageBox.Show(tourid.ToString());
            game g = new game(date_time, "", refree, 0, opponent, tourid);
            g.insert();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date_time = comboBox3.Text;
            game g = game.find_by_date(date_time);
            maskedTextBox5.Text = g.opponent;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string date_time = comboBox3.Text;
            game g = game.find_by_date(date_time);
            g.wteam = maskedTextBox4.Text;
            g.opponent = maskedTextBox5.Text;
            g.update();
        }
    }
}
