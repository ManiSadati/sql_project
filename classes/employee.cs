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
        public static DBAccess dbaccess = new DBAccess();
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
            SqlCommand insert = new SqlCommand("insert into employee(id,cid,Ctype,firstName,lastname,email,pass,phone,worktime,payment) values(@id,@cid,@Ctype,@firstName,@lastname,@email,@pass,@phone,@worktime,@payment)");
            insert.Parameters.AddWithValue("@firstname", this.firstname);
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@cid", this.CID);
            insert.Parameters.AddWithValue("@Ctype", this.Ctype);
            insert.Parameters.AddWithValue("@lastname", this.lastname);
            insert.Parameters.AddWithValue("@email", this.email);
            insert.Parameters.AddWithValue("@pass", this.pass);
            insert.Parameters.AddWithValue("@phone", this.phone);
            insert.Parameters.AddWithValue("@worktime", this.worktime);
            insert.Parameters.AddWithValue("@payment", this.payment);
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
        public void update()
        {
            SqlCommand insert = new SqlCommand("update employee set id=@id, cid=@cid, Ctype=@Ctype, firstName=@firstName, lastname=@lastname, email=@email, pass=@pass, phone=@phone,worktime=@worktime,payment=@payment where id=@id");
            insert.Parameters.AddWithValue("@firstname", this.firstname);
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@cid", this.CID);
            insert.Parameters.AddWithValue("@Ctype", this.Ctype);
            insert.Parameters.AddWithValue("@lastname", this.lastname);
            insert.Parameters.AddWithValue("@email", this.email);
            insert.Parameters.AddWithValue("@pass", this.pass);
            insert.Parameters.AddWithValue("@phone", this.phone);
            insert.Parameters.AddWithValue("@worktime", this.worktime);
            insert.Parameters.AddWithValue("@payment", this.payment);
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
        public void Delete()
        {
            SqlCommand insert = new SqlCommand("DELETE FROM employee where id=@id");
            insert.Parameters.AddWithValue("@id", this.ID);
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
        public static List<employee> list() {
            List<employee> LP = new List<employee>();
            string query = "SELECT * FROM employee";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                employee emp = new employee();
                emp.firstname = dataRow["firstname"].ToString();
                emp.lastname = dataRow["lastname"].ToString();
                emp.email = dataRow["email"].ToString();
                emp.ID = Convert.ToInt32(dataRow["ID"].ToString());
                emp.CID = Convert.ToInt32(dataRow["CID"].ToString());
                emp.Ctype = dataRow["Ctype"].ToString();
                emp.pass = dataRow["pass"].ToString();
                emp.worktime = Convert.ToInt32(dataRow["worktime"].ToString());
                emp.payment = Convert.ToInt32(dataRow["payment"].ToString());
                emp.phone = dataRow["phone"].ToString();
                LP.Add(emp);
            }
            return LP;
        }
        public static employee search() {
            //search in database and replace it
            employee emp = new employee();
            return emp;
        }
        public static void test() {
            employee emp = new employee(0, 0, "player", "mohammad0", "shahidzade", "mohamm@", "0", "0912", 5, 10);
            employee emp1 = new employee(1, 1, "manage", "mohammad1", "shahidzade", "mohamm@", "0", "0912", 5, 10);
            employee emp2 = new employee(2, 2, "coach", "mohammad2", "shahidzade", "mohamm@", "0", "0912", 5, 10);
            employee emp3 = new employee(3, 3, "Doctor", "mohammad3", "shahidzade", "mohamm@", "0", "0912", 5, 10);
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<employee> LP = new List<employee>();
            LP = employee.list();
            foreach (employee emplo in LP) {
                Console.WriteLine(emplo.firstname);
            }
            emp.firstname = "ali";
            emp.update();
            LP = employee.list();
            Console.WriteLine("second line");
            foreach (employee emplo in LP)
            {
                Console.WriteLine(emplo.firstname);
            }
            emp1.Delete();
            LP = employee.list();
            Console.WriteLine("third line");
            foreach (employee emplo in LP)
            {
                Console.WriteLine(emplo.firstname);
            }
        }

    }
}
