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
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
            this.Text = "آمار بازیکنان";
            LoadTheme();
            List<string> li = new List<string>();
            foreach (player x in player.list())
            {
                li.Add(x.ID);
            }
            comboBox2.DataSource = li;

            List<string> lii = new List<string>();
            foreach (game x in game.list())
            {
                lii.Add(x.date_time);
            }
            comboBox1.DataSource = lii;
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
            label10.ForeColor = ThemeColor.SecondaryColor;
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pid = comboBox2.Text;
            player p = player.find(pid);
            maskedTextBox2.Text = p.firstname;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date_time = comboBox1.Text;
            game g = game.find_by_date(date_time);
            maskedTextBox1.Text = g.opponent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pid = comboBox2.Text;
            string date_time = comboBox1.Text;
            int time = Convert.ToInt32(maskedTextBox3.Text);
            int goal = Convert.ToInt32(maskedTextBox4.Text);
            int assits = Convert.ToInt32(maskedTextBox5.Text);
            int apass = Convert.ToInt32(maskedTextBox6.Text);
            play x = new play(pid, date_time, goal, time, assits, 0, apass, 0, 0);
            x.insert();
            MessageBox.Show("UPDATED!");
        }
    }
}
