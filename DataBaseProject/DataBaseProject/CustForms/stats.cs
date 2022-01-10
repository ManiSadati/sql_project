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
    public partial class stats : Form
    {
        string playerid;
        public stats()
        {
            InitializeComponent();
            this.Text = "آمار و ارقام";
            LoadTheme();
            List<string> listg = new List<string>();
            foreach (tournament g in tournament.list())
            {
                listg.Add(g.dname);
            }
            comboBox1.DataSource = listg;

            List<string> listp = new List<string>();
            foreach (player g in player.list())
            {
                listp.Add(g.firstname);
            }
            comboBox2.DataSource = listp;

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
            label2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void stats_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> listp = new List<string>();
            string playerid = "";
            foreach (player g in player.list())
            {
                if(g.firstname == comboBox2.Text)
                {
                    playerid = g.ID.ToString();
                }
            }
            tournament t = tournament.find(comboBox1.Text);
            int tourid = t.ID;
            MessageBox.Show("this is tid and pid " + tourid.ToString() + " " + playerid.ToString());
            play p = game.tournoment_performance(tourid, playerid);
            List<DATAG3> dg = new List<DATAG3>();

            dg.Add(new DATAG3(comboBox2.Text, p.ngoal.ToString(), p.npass.ToString(), p.ncpass.ToString(),
                p.tplayed.ToString(), p.grade.ToString()));
            dataGridView1.DataSource = dg;
        }
        public class DATAG3
        {
            string name;
            string Goals1;
            string Assits1;
            string Pass1;
            string timesplay1;
            string grade1;
            //string sscore1;
            //string nscore1;
            public DATAG3(string s, string t, string p, string q,string q2, string q3)
            {
                name = s;
                Goals1 = t;
                Assits1 = p;
                Pass1 = q;
                timesplay1 = q2;
                grade1 = q3;    

            }
            public string Name { get { return name; } set { Name = value; } }
            public string Goals { get { return Goals1; } set { Goals = value; } }
            public string Assits { get { return Assits1; } set { Assits = value; } }
            public string Pass { get { return Pass1; } set { Pass = value; } }
            public string PlayTime { get { return timesplay1; } set { PlayTime = value; } }
            public string Grade { get { return grade1; } set { Grade = value; } }

        }

    }
}
