using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CostumerSignIn.xaml
    /// </summary>
    public partial class CostumerSignIn : Window
    {
        DBAccess objDBAcess = new DBAccess();
        DataTable dtCustomer = new DataTable();
        public CostumerSignIn()
        {
            InitializeComponent();
        }

        private void signinbtn_Click(object sender, RoutedEventArgs e)
        {
            string CostumerEmail = EmailCostumerSignin.Text;
            string CostumerPassword = PasswordCostumerSignin.Text;
            if (CostumerEmail.Equals(""))
            {
                MessageBox.Show("Please enter your Email.");
            }
            else if (CostumerPassword.Equals(""))
            {
                MessageBox.Show("Please enter your Password.");
            }
            else
            {

                Customer newcusotmer = Customer.find(CostumerEmail, CostumerPassword);
                
                if (newcusotmer != null)
                {
                    MessageBox.Show("You are Logged in Successfully!");
                    this.Hide();
                    CostumerHomePage home = new CostumerHomePage(newcusotmer);
                    home.Show();
                }
                else
                {
                    MessageBox.Show("email or password is wrong!");
                }

            }
        }
    }
}
