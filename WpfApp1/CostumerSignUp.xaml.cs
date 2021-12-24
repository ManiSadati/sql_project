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
    /// Interaction logic for CostumerSignUp.xaml
    /// </summary>
    public partial class CostumerSignUp : Window
    {
        DBAccess objDBAcess = new DBAccess();
        public CostumerSignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Costumername = FirstNameCostumerSignup.Text + " " + LastNameCostumerSignup.Text;
            string CostumerNID = NIDCostumerSignup.Text;
            string CostumerEmail = EmailCostumerSignup.Text;
            string CostumerPassword = PasswordCostumerSignup.Text;
            string CostumerAddress = AddressCostumerSignup.Text;

            if (CostumerNID.Equals(""))
            {
                MessageBox.Show("Please enter your National ID.");
            }
            else if (FirstNameCostumerSignup.Text.Equals(""))
            {
                MessageBox.Show("Please enter your First Name.");
            }
            else if (LastNameCostumerSignup.Text.Equals(""))
            {
                MessageBox.Show("Please enter your Last Name.");
            }
            else if (CostumerEmail.Equals(""))
            {
                MessageBox.Show("Please enter your Email.");
            }
            else if (CostumerPassword.Equals(""))
            {
                MessageBox.Show("Please enter your Password.");
            }
            else if (CostumerAddress.Equals(""))
            {
                MessageBox.Show("Please enter your Address.");
            }
            else
            {
                int row = Customer.insert(Costumername, CostumerNID, CostumerEmail, CostumerPassword, CostumerAddress, "0");
                
                if (row == 1)
                {
                    MessageBox.Show("account created successfully!");
                    this.Hide();
                    CostumerSignIn costumerSignIn = new CostumerSignIn();
                    costumerSignIn.Show();
                }
                else
                {
                    MessageBox.Show("account is not created");
                }
            }
        }
    }
}
