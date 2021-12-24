using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    class Doctor:employee
    {

        public static new DBAccess dbaccess = new DBAccess();
        public int id { set; get; }
        public int pid { set; get; }
        public string major { set; get; }
        public Doctor(int id, int cid, string Ctype, string firstName, string lastname, string email, string pass, string phone, int worktime, int payment, string major) : base(id, cid, Ctype, firstName, lastname, email, pass, phone, worktime, payment)
        {
            this.id = cid;
            this.pid = id;
            this.major = major;
        }
        public Doctor()
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
            this.id = 0;
            this.pid = 0;
            this.major = major;
        }
        public new void insert()
        {
            base.insert();
            SqlCommand insert = new SqlCommand("insert into Doctor(id,pid,major) values(@id,@pid,@major)");
            insert.Parameters.AddWithValue("@id", this.id);
            insert.Parameters.AddWithValue("@pid", this.pid);
            insert.Parameters.AddWithValue("@major", this.major);
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
        public new void update()
        {
            base.update();
            SqlCommand insert = new SqlCommand("update Doctor set id=@id,pid=@pid,major=@major where id=@id");
            insert.Parameters.AddWithValue("@id", this.id);
            insert.Parameters.AddWithValue("@pid", this.pid);
            insert.Parameters.AddWithValue("@major", this.major);
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
        public new void Delete()
        {
            base.Delete();
            SqlCommand insert = new SqlCommand("DELETE FROM Doctor where id=@id");
            insert.Parameters.AddWithValue("@id", this.id);
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
        public new static List<Doctor> list()
        {
            List<Doctor> LP = new List<Doctor>();
            string query = "SELECT * FROM Doctor,employee where Doctor.id=employee.id";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                Doctor emp = new Doctor();
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
                emp.pid = Convert.ToInt32(dataRow["PID"].ToString());
                emp.major = dataRow["major"].ToString();
                LP.Add(emp);
                //foreach (var item in dataRow.ItemArray)
                //Console.WriteLine(item);
            }
            return LP;
        }
        public new static employee search()
        {
            //search in database and replace it
            employee emp = new employee();
            return emp;
        }
        public new static void test()
        {
            Doctor emp = new Doctor(0, 0, "Doctor", "mohammad0", "shahidzade", "mohamm@", "0", "0912", 5, 10, "leg");
            Doctor emp1 = new Doctor(1, 1, "manage", "mohammad1", "shahidzade", "mohamm@", "0", "0912", 5, 10, "hart");
            Doctor emp2 = new Doctor(2, 2, "Doctor", "mohammad2", "shahidzade", "mohamm@", "0", "0912", 5, 10, "hamestring");
            Doctor emp3 = new Doctor(3, 3, "Doctor", "mohammad3", "shahidzade", "mohamm@", "0", "0912", 5, 10, "head");
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<Doctor> LP = new List<Doctor>();
            LP = Doctor.list();
            foreach (Doctor emplo in LP)
            {
                Console.WriteLine("{0},{1}",emplo.firstname,emplo.major);
            }
            emp.firstname = "ali";
            emp.major = "koft";
            emp.update();
            LP = Doctor.list();
            Console.WriteLine("second line");
            foreach (Doctor emplo in LP)
            {
                Console.WriteLine("{0},{1}", emplo.firstname, emplo.major);
            }
            emp1.Delete();
            LP = Doctor.list();
            Console.WriteLine("third line");
            foreach (Doctor emplo in LP)
            {
                Console.WriteLine("{0},{1}", emplo.firstname, emplo.major);
            }
        }
    }
}
