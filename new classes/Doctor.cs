using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseProject
{
    class Doctor:employee
    {

        public static new DBAccess dbaccess = new DBAccess();
        public string id { set; get; }
        public string major { set; get; }
        public Doctor(string id, string Ctype, string firstName, string lastname, string email, string pass, string phone, int worktime, int payment, string major) : base(id, Ctype, firstName, lastname, email, pass, phone, worktime, payment)
        {
            this.id = id;
            this.major = major;
        }
        public Doctor()
        {
            this.firstname = "";
            this.lastname = "";
            this.email = "";
            this.ID = "";
            this.Ctype = "";
            this.pass = "";
            this.worktime = 0;
            this.payment = 0;
            this.phone = "";
            this.id = "";
            this.major = major;
        }
        public new void insert()
        {
            base.insert();
            SqlCommand insert = new SqlCommand("insert into Doctor(id,major) values(@id,@major)");
            insert.Parameters.AddWithValue("@id", this.id);
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
            SqlCommand insert = new SqlCommand("update Doctor set id=@id,major=@major where id=@id");
            insert.Parameters.AddWithValue("@id", this.id);
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
                emp.ID = dataRow["ID"].ToString();
                emp.Ctype = dataRow["Ctype"].ToString();
                emp.pass = dataRow["pass"].ToString();
                emp.worktime = Convert.ToInt32(dataRow["worktime"].ToString());
                emp.payment = Convert.ToInt32(dataRow["payment"].ToString());
                emp.phone = dataRow["phone"].ToString();
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
        public static Doctor find(int id)
        {
            string query = "SELECT * FROM doctor,employee where doctor.id=employee.id and doctor.id='" + Convert.ToString(id)+"'";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            Doctor emp = new Doctor();
            if (ans.Rows.Count > 0)
            {
                emp.firstname = ans.Rows[0]["firstname"].ToString();
                emp.lastname = ans.Rows[0]["lastname"].ToString();
                emp.email = ans.Rows[0]["email"].ToString();
                emp.ID = ans.Rows[0]["ID"].ToString();
                emp.Ctype = ans.Rows[0]["Ctype"].ToString();
                emp.pass = ans.Rows[0]["pass"].ToString();
                emp.worktime = Convert.ToInt32(ans.Rows[0]["worktime"].ToString());
                emp.payment = Convert.ToInt32(ans.Rows[0]["payment"].ToString());
                emp.phone = ans.Rows[0]["phone"].ToString();
                emp.major = ans.Rows[0]["major"].ToString();
            }
            return emp;
        }
        public new static void test()
        {
            Doctor emp = new Doctor("4",  "Doctor", "mohammad0", "shahidzade", "mohamm@", "0", "0912", 5, 10, "leg");
            Doctor emp1 = new Doctor("5", "manage", "mohammad1", "shahidzade", "mohamm@", "0", "0912", 5, 10, "hart");
            Doctor emp2 = new Doctor("6", "Doctor", "mohammad2", "shahidzade", "mohamm@", "0", "0912", 5, 10, "hamestring");
            Doctor emp3 = new Doctor("7",  "Doctor", "mohammad3", "shahidzade", "mohamm@", "0", "0912", 5, 10, "head");
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
