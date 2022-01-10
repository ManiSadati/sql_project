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
    public partial class lineup : Form
    {
        public lineup()
        {
            InitializeComponent();
            this.Text = "نمایش ترکیب";
            LoadTheme();
            List<string> list = new List<string>(); 
            foreach(game g in game.list())
            {
                list.Add(g.date_time);
            }
            comboBox1.DataSource = list;
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
            label4.ForeColor = ThemeColor.PrimaryColor;
        }

        private void lineup_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date_time = comboBox1.Text;
            game g = game.find_by_date(date_time);
            label5.Text = g.opponent;
            label6.Text = g.referee;

            List<player> LP = game.player_list(date_time);
            List<string> ls = new List<string>();
            IList<String> list_string = new List<String>();
            List<DATAG1> ls_ = new List<DATAG1>();
            foreach(player player in LP)
            {

                ls_.Add(new DATAG1(player.firstname,player.age.ToString()));
            }
            dataGridView1.DataSource = ls_;
            //dataGridView1.DataSource = list_string.Select(x => new { Name = x }).ToList();

            //dataGridView1.DataSource = LP;
        }
        public class DATAG1
        {
            string value;
            string tii;
            public DATAG1(string s, string t)
            {
                value = s;
                tii = t;
            }
            public string Name { get { return value; } set { Name = value; } }
            public string Age { get { return tii; } set { Age = value; } }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
