using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class employee
    {
        DBAccess dbaccess = new DBAccess();
        public int ID { set; get; }
        public int CID { set; get; }
        public string Ctype { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public string email { set; get; }
        public string pass { set; get; }
        public string phone { set; get; }
        public int worktime { set; get; }
        public int payment { set; get; }
        public employee(int id,int cid, string Ctype,string firstname,string lastname,string email,string pass,string phone,int worktime,int payment)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.ID = id;
            this.CID = cid;
            this.Ctype = Ctype;
            this.pass = pass;
            this.worktime = worktime;
            this.payment = payment;
            this.phone = phone;
        }
        public employee()
        {
            this.firstname = "";
            this.lastname = "";
            this.email = "";
            this.ID = 0;
            this.CID = 0;
            this.Ctype = "";
            this.pass = "";
            this.worktime = 0;
            this.payment = 0;
            this.phone = "";
        }
        public void insert() {
            SqlCommand insert = new SqlCommand("insert into employee(id,cid,Ctype,firstName,lastname,email,pass,phone,worktime,payment) values(@this.id,@this.cid,@this.Ctype,@this.firstName,@this.lastname,@this.email,@this.pass,@this.phone,@this.worktime,@this.payment)");
            int success = dbaccess.executeQuery(insert);
            if (success == 1)
            {
                Console.WriteLine("it was successfull");
            }
            else
            {
                Console.WriteLine("it was not successfull");
            }
        }
        public static void update()
        {
            SqlCommand insert = new SqlCommand("update employee set id=@this.id, cid=@this.cid, Ctype=@this.Ctype, firstName=@this.firstName, lastname=@this.lastname, email=@this.email, pass=@this.pass, phone=@this.phone,worktime=@this.worktime,payment=@this.payment where id=@this.id");
        }
        public static void Delete()
        {
            SqlCommand insert = new SqlCommand("DELETE FROM employee where id=@this.id");

        }
        public static List<employee> list() {
            List<employee> LP = new List<employee>();
            string query = "SELECT * FROM employee";
            DataTable ans = new DataTable();
            //DBAccess.readDatathroughAdapter(query, ans);
            return LP;
        }
        public static employee search() {
            //search in database and replace it
            employee emp = new employee();
            return emp;
        }

    }
}
