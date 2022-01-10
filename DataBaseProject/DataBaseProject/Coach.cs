using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseProject
{
    class Coach:employee
    {
        public static new DBAccess dbaccess = new DBAccess();
        public string id { set; get; }
        public int Ngame { set; get; }
        public int Ngoal { set; get; }
        public int Nwin { set; get; }
        public int val { set; get; }
        public Coach(string id, string Ctype, string firstName, string lastname, string email, string pass, string phone, int worktime, int payment, int Ngame, int Ngoal, int Nwin,int val) : base(id, Ctype, firstName, lastname, email, pass, phone, worktime, payment)
        {
            this.id = id;
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
            this.ID = "";
            this.Ctype = "";
            this.pass = "";
            this.worktime = 0;
            this.payment = 0;
            this.phone = "";
            this.id = "";
            this.Ngame = 0;
            this.Ngoal = 0;
            this.Nwin = 0;
            this.val = 0;
        }
        public new void insert()
        {
            base.insert();
            SqlCommand insert = new SqlCommand("insert into Coach(id,Ngame,Ngoal,Nwin,val) values(@id,@Ngame,@Ngoal,@Nwin,@val)");
            insert.Parameters.AddWithValue("@id", this.id);
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
            SqlCommand insert = new SqlCommand("update Coach set id=@id,Ngame=@Ngame,Ngoal=@Ngoal,Nwin=@Nwin,val=@val where id=@id");
            insert.Parameters.AddWithValue("@id", this.id);
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
                emp.ID = dataRow["ID"].ToString();
                emp.Ctype = dataRow["Ctype"].ToString();
                emp.pass = dataRow["pass"].ToString();
                emp.worktime = Convert.ToInt32(dataRow["worktime"].ToString());
                emp.payment = Convert.ToInt32(dataRow["payment"].ToString());
                emp.phone = dataRow["phone"].ToString();
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
        public static Coach find(int id)
        {
            string query = "SELECT * FROM coach,employee where coach.id=employee.id and player.id='" + Convert.ToString(id)+"'";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            Coach emp = new Coach();
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
                emp.Ngame = Convert.ToInt32(ans.Rows[0]["Ngame"].ToString());
                emp.Ngoal = Convert.ToInt32(ans.Rows[0]["Ngoal"].ToString());
                emp.Nwin = Convert.ToInt32(ans.Rows[0]["Nwin"].ToString());
                emp.val = Convert.ToInt32(ans.Rows[0]["val"].ToString());
            }
            return emp;
        }
        public new static void test()
        {
            Coach emp = new Coach("0", "Coach", "mohammad0", "shahidzade", "mohamm@", "0", "0912", 5, 10, 0, 0, 0, 0);
            Coach emp1 = new Coach("1", "manage", "mohammad1", "shahidzade", "mohamm@", "0", "0912", 5, 10, 0, 0, 0, 0);
            Coach emp2 = new Coach("2", "Coach", "mohammad2", "shahidzade", "mohamm@", "0", "0912", 5, 10, 0, 0, 0, 0);
            Coach emp3 = new Coach("3", "Doctor", "mohammad3", "shahidzade", "mohamm@", "0", "0912", 5, 10, 0, 0, 0, 0);
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
