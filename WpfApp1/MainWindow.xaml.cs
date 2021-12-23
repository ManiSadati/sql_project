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
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBAccess dbaccess = new DBAccess();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string firstname = txtfirstname.Text;
            string secondname = txtsecondname.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;
            string phone = txtphone.Text;
            Console.WriteLine("{0} ,{1} ,{2} ,{3} ,{4} ", firstname,secondname,email,password,phone);
            SqlCommand insert = new SqlCommand("insert into SIGNUP(firstname,secondname,email,pass,phone) values(@firstname,@secondname,@email,@password,@phone)");
            insert.Parameters.AddWithValue("@firstname", firstname);
            insert.Parameters.AddWithValue("@secondname", secondname);
            insert.Parameters.AddWithValue("@email", email);
            insert.Parameters.AddWithValue("@password", password);
            insert.Parameters.AddWithValue("@phone", phone);

            int success = dbaccess.executeQuery(insert);
            if (success == 1)
            {
                Console.WriteLine("it was successfull");
            }
            else {
                Console.WriteLine("it was not successfull");
            }
        }
    }
}
