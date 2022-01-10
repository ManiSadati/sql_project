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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            this.Text = "کارمندان";
            radioButton4.Checked = true;
            label9.Visible = false;
            label10.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            textBox5.Visible = false;
            textBox4.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            LoadTheme();
            List<string> list = new List<string>();
            foreach(employee s in employee.list())
            {
                list.Add(s.ID);
            }
            txtNameHome.DataSource = list;
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
            label5.ForeColor = ThemeColor.SecondaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }


        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string name = txtEmailHome.Text;
            string lname = "";
            string email = txtPasswordHome.Text;
            string cid = txtNameHome.Text;
            string pass = textBox1.Text;
            int worktime = Convert.ToInt32(textBox3.Text);
            int payment = Convert.ToInt32(textBox6.Text);
            string phone = textBox2.Text;

            string ctype = "other";
            if (radioButton1.Checked)
            {
                ctype = "player";
                int health = Convert.ToInt32(textBox5.Text);
                int value = Convert.ToInt32(textBox4.Text);
                int age = Convert.ToInt32(textBox7.Text);
                int ngname = Convert.ToInt32(textBox8.Text);
                int ngoal = Convert.ToInt32(textBox9.Text);
                int nwin = Convert.ToInt32(textBox10.Text);
                player p = new player(cid,ctype,name,lname,email,pass,phone,worktime,payment, ngname,ngoal,nwin,age,health,value);
                p.insert();
                MessageBox.Show("CREATED A NEW PLAYER!");
            }
            if (radioButton2.Checked)
            {
                ctype = "coach";
                int experince = Convert.ToInt32(textBox5.Text);
                int nwins = Convert.ToInt32(textBox4.Text);
                int nloses = Convert.ToInt32(textBox7.Text);
                int possession = Convert.ToInt32(textBox8.Text);
                Coach c = new Coach(cid, ctype, name, lname, email, pass, phone, worktime, payment,experince,nwins,nloses,possession);
                c.insert();
                MessageBox.Show("CREATED A NEW COACH!");
            }
            if (radioButton3.Checked)
            {
                ctype = "doctor";
                string experince = textBox5.Text;
                Doctor d = new Doctor(cid, ctype, name, lname, email, pass, phone, worktime, payment, experince);
                d.insert();
                MessageBox.Show("CREATED A NEW DOCTOR!");
            }
            if (radioButton4.Checked)
            {
                ctype = "other";
                employee e2 = new employee(cid, ctype, name, lname, email, pass, phone, worktime, payment);
                e2.insert();
                MessageBox.Show("CREATED A NEW Employee!");
            }
            //employee emp = new employee(id,cid,ctype,name,lname,email,pass, phone,worktime,payment,);
            //emp.insert();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == false)
            {
                MessageBox.Show("ONLY CHANGE PLAYERS!");
                return;
            }
            string cid = txtNameHome.Text;
            player p = player.find(cid);
            radioButton1.Checked = true;

            txtEmailHome.Text = p.firstname;
            txtPasswordHome.Text = p.email;
            textBox1.Text = p.pass;
            textBox3.Text = p.worktime.ToString();
            textBox6.Text = p.payment.ToString();
            textBox2.Text = p.phone;

            textBox5.Text = p.health.ToString();
            textBox4.Text = p.val.ToString();
            textBox7.Text = p.age.ToString();
            textBox8.Text = p.Ngame.ToString();
            textBox9.Text = p.Ngoal.ToString();
            textBox10.Text = p.Nwin.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                MessageBox.Show("ONLY CHANGE PLAYERS!");
                return;
            }
            string name = txtEmailHome.Text;
            string lname = "";
            string email = txtPasswordHome.Text;
            string cid = txtNameHome.Text;
            string pass = textBox1.Text;
            int worktime = Convert.ToInt32(textBox3.Text);
            int payment = Convert.ToInt32(textBox6.Text);
            string phone = textBox2.Text;

            string ctype = "player";
            int health = Convert.ToInt32(textBox5.Text);
            int value = Convert.ToInt32(textBox4.Text);
            int age = Convert.ToInt32(textBox7.Text);
            int ngname = Convert.ToInt32(textBox8.Text);
            int ngoal = Convert.ToInt32(textBox9.Text);
            int nwin = Convert.ToInt32(textBox10.Text);
            player p = new player(cid, ctype, name, lname, email, pass, phone, worktime, payment, ngname, ngoal, nwin, age, health, value);
            p.update();
            MessageBox.Show("UPDATED A PLAYER!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                MessageBox.Show("ONLY DELETE PLAYERS!");
                return;
            }
            string name = txtEmailHome.Text;
            string lname = "";
            string email = txtPasswordHome.Text;
            string cid = txtNameHome.Text;
            string pass = textBox1.Text;
            int worktime = Convert.ToInt32(textBox3.Text);
            int payment = Convert.ToInt32(textBox6.Text);
            string phone = textBox2.Text;

            string ctype = "player";
            int health = Convert.ToInt32(textBox5.Text);
            int value = Convert.ToInt32(textBox4.Text);
            int age = Convert.ToInt32(textBox7.Text);
            int ngname = Convert.ToInt32(textBox8.Text);
            int ngoal = Convert.ToInt32(textBox9.Text);
            int nwin = Convert.ToInt32(textBox10.Text);
            player p = new player(cid, ctype, name, lname, email, pass, phone, worktime, payment, ngname, ngoal, nwin, age, health, value);
            p.Delete();
            MessageBox.Show("Deleted A PLAYER!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label9.Visible = true;
                label10.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                textBox5.Visible = true;
                textBox4.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                label9.Text = "وضعیت سلامتی";
                label10.Text = "ارزش بازار";
                label12.Text = "سن";
                label13.Text = "تعداد بازی";
                label14.Text = "تعداد گل";
                label15.Text = "تعداد برد";

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label9.Visible = true;
                label10.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                textBox5.Visible = true;
                textBox4.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                label9.Text = "تخصص";
                label10.Text = "ارزش بازار";
                label12.Text = "سن";
                label13.Text = "تعداد بازی";
                label14.Text = "تعداد گل";
                label15.Text = "تعداد برد";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label9.Visible = true;
                label10.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = false;
                label15.Visible = false;
                textBox5.Visible = true;
                textBox4.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = false;
                textBox10.Visible = false;
                label9.Text = "تعداد بازی";
                label10.Text = "تعداد برد";
                label12.Text = "تعداد گل";
                label13.Text = "ارزش";
                label14.Text = "تعداد گل";
                label15.Text = "تعداد برد";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label9.Visible = false;
                label10.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                textBox5.Visible = false;
                textBox4.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
            }

        }
    }
}
