using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    class Coach:employee
    {
        public static new DBAccess dbaccess = new DBAccess();
        public int id { set; get; }
        public int pid { set; get; }
        public int Ngame { set; get; }
        public int Ngoal { set; get; }
        public int Nwin { set; get; }
        public int val { set; get; }
        public Coach(int id, int cid, string Ctype, string firstName, string lastname, string email, string pass, string phone, int worktime, int payment, int Ngame, int Ngoal, int Nwin,int val) : base(id, cid, Ctype, firstName, lastname, email, pass, phone, worktime, payment)
        {
            this.id = cid;
            this.pid = id;
            this.Ngame = Ngame;
            this.Ngoal = Ngoal;
            this.Nwin = Nwin;
            this.val = val;
        }
        public Coach()
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
            this.Ngame = 0;
            this.Ngoal = 0;
            this.Nwin = 0;
            this.val = 0;
        }
        public new void insert()
        {
            base.insert();
            SqlCommand insert = new SqlCommand("insert into Coach(id,pid,Ngame,Ngoal,Nwin,val) values(@id,@pid,@Ngame,@Ngoal,@Nwin,@val)");
            insert.Parameters.AddWithValue("@id", this.id);
            insert.Parameters.AddWithValue("@pid", this.pid);
            insert.Parameters.AddWithValue("@Ngame", this.Ngame);
            insert.Parameters.AddWithValue("@Ngoal", this.Ngoal);
            insert.Parameters.AddWithValue("@Nwin", this.Nwin);
            insert.Parameters.AddWithValue("@val", this.val);
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
            SqlCommand insert = new SqlCommand("update Coach set id=@id,pid=@pid,Ngame=@Ngame,Ngoal=@Ngoal,Nwin=@Nwin,val=@val where id=@id");
            insert.Parameters.AddWithValue("@id", this.id);
            insert.Parameters.AddWithValue("@pid", this.pid);
            insert.Parameters.AddWithValue("@Ngame", this.Ngame);
            insert.Parameters.AddWithValue("@Ngoal", this.Ngoal);
            insert.Parameters.AddWithValue("@Nwin", this.Nwin);
            insert.Parameters.AddWithValue("@val", this.val);
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
            SqlCommand insert = new SqlCommand("DELETE FROM Coach where id=@id");
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
        public new static List<Coach> list()
        {
            List<Coach> LP = new List<Coach>();
            string query = "SELECT * FROM Coach,employee where Coach.id=employee.id";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                Coach emp = new Coach();
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
                emp.Ngame = Convert.ToInt32(dataRow["Ngame"].ToString());
                emp.Ngoal = Convert.ToInt32(dataRow["Ngoal"].ToString());
                emp.Nwin = Convert.ToInt32(dataRow["Nwin"].ToString());
                emp.val = Convert.ToInt32(dataRow["val"].ToString());
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
            Coach emp = new Coach(0, 0, "Coach", "mohammad0", "shahidzade", "mohamm@", "0", "0912", 5, 10, 0, 0, 0, 0);
            Coach emp1 = new Coach(1, 1, "manage", "mohammad1", "shahidzade", "mohamm@", "0", "0912", 5, 10, 0, 0, 0, 0);
            Coach emp2 = new Coach(2, 2, "Coach", "mohammad2", "shahidzade", "mohamm@", "0", "0912", 5, 10, 0, 0, 0, 0);
            Coach emp3 = new Coach(3, 3, "Doctor", "mohammad3", "shahidzade", "mohamm@", "0", "0912", 5, 10, 0, 0, 0, 0);
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<Coach> LP = new List<Coach>();
            LP = Coach.list();
            foreach (Coach emplo in LP)
            {
                Console.WriteLine(emplo.firstname);
            }
            emp.firstname = "ali";
            emp.update();
            LP = Coach.list();
            Console.WriteLine("second line");
            foreach (Coach emplo in LP)
            {
                Console.WriteLine(emplo.firstname);
            }
            emp1.Delete();
            LP = Coach.list();
            Console.WriteLine("third line");
            foreach (Coach emplo in LP)
            {
                Console.WriteLine(emplo.firstname);
            }
        }
    }
}
