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
    public partial class rating : Form
    {
        public rating()
        {
            InitializeComponent();
            this.Text = "امتیاز دهی";
            LoadTheme();
            List<string> listg = new List<string>();
            foreach (game g in game.list())
            {
                listg.Add(g.date_time);
            }
            comboBox1.DataSource = listg;

            List<string> listp = new List<string>();
            foreach (player g in player.list())
            {
                listp.Add(g.firstname);
            }
            comboBox2.DataSource = listp;

            List<string> listr = new List<string>();
            for (int i = 0; i <= 5; i++)
            {
                listr.Add(i.ToString());
            }
            comboBox3.DataSource = listr;

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
            label2.ForeColor = ThemeColor.PrimaryColor;
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void rating_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play p = game.show_player(comboBox1.Text, comboBox2.Text);
            player x = player.find(p.playerid);
            List<DATAG2> dg = new List<DATAG2>();
            dg.Add(new DATAG2(x.firstname, p.ngoal.ToString(), p.npass.ToString(), p.ncpass.ToString()));
            dataGridView1.DataSource = dg;

        }
        public class DATAG2
        {
            string name;
            string Goals1;
            string Assits1;
            string Pass1;
            public DATAG2(string s, string t,string p, string q)
            {
                name = s;
                Goals1 = t;
                Assits1 = p;
                Pass1 = q;  
            }
            public string Name { get { return name; } set { Name = value; } }
            public string Goals { get { return Goals1; } set { Goals = value; } }
            public string Assits { get { return Assits1; } set { Assits = value; } }
            public string Pass { get { return Pass1; } set { Pass = value; } }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score= Convert.ToInt32(comboBox3.Text);
            game.score_player(comboBox1.Text, comboBox2.Text, score);
            MessageBox.Show("DONE");
        }
    }
}
