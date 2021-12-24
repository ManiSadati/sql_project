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
    /// Interaction logic for AdminPannel.xaml
    /// </summary>
    public partial class AdminPannel : Window
    {
        DBAccess objDBAcess = new DBAccess();
        public AdminPannel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string EmployeeNID = NIDAdminRegister.Text;
            string Employeename = FNameAdminRegister.Text + " " + LNameAdminRegister.Text;
            string EmployeeWHour = WorkHourAdminRegister.Text;
            string EmployeeSalary = SalaryAdminRegister.Text;
            string EmployeeEmail = EmailAdminRegister.Text;
            string EmployeePassword = PasswordAdminRegister.Text;

            if (EmployeeNID.Equals(""))
            {
                MessageBox.Show("Please enter Employee National ID.");
            }
            else if (FNameAdminRegister.Text.Equals(""))
            {
                MessageBox.Show("Please enter Employee First Name.");
            }
            else if (LNameAdminRegister.Equals(""))
            {
                MessageBox.Show("Please enter Employee Last Name.");
            }
            else if (EmployeeSalary.Equals(""))
            {
                MessageBox.Show("Please enter Employee Salary.");
            }
            else if (EmployeeEmail.Equals(""))
            {
                MessageBox.Show("Please enter Employee Email.");
            }
            else if (EmployeePassword.Equals(""))
            {
                MessageBox.Show("Please enter Employee Password.");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO Employee(NID, Name, WHour, Salary, Email, Password) values(@EmployeeNID, @Employeename, @EmployeeWHour, @EmployeeSalary, @EmployeeEmail, @EmployeePassword)");

                insertCommand.Parameters.AddWithValue("@EmployeeNID", EmployeeNID);
                insertCommand.Parameters.AddWithValue("@Employeename", Employeename);
                insertCommand.Parameters.AddWithValue("@EmployeeWHour", EmployeeWHour);
                insertCommand.Parameters.AddWithValue("@EmployeeSalary", EmployeeSalary);
                insertCommand.Parameters.AddWithValue("@EmployeeEmail", EmployeeEmail);
                insertCommand.Parameters.AddWithValue("@EmployeePassword", EmployeePassword);

                int row = objDBAcess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("account created successfully!");
                }
                else
                {
                    MessageBox.Show("account is not created");
                }
            }
        }
    }
}
