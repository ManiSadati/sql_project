using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseProject
{
    class participate
    {
        public static DBAccess dbaccess = new DBAccess();
        public string gameid { set; get; }
        public int nrgoal { set; get; }
        public int nsgoal { set; get; }
        public int ncpass  { set; get; }
        public int ngattempt { set; get; }
        public int phball { set; get; }
        public participate(string gameid,int nrgoal,int nsgoal,int ncpass,int ngattempt,int phball)
        {
            this.gameid = gameid;
            this.nrgoal = nrgoal;
            this.nsgoal = nsgoal;
            this.ncpass = ncpass;
            this.ngattempt = ngattempt;
            this.phball = phball;
        }
        public participate()
        {
            this.gameid = "";
            this.nrgoal = 0;
            this.nsgoal = 0;
            this.ncpass = 0;
            this.ngattempt = 0;
            this.phball = 0;
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into participate(gameid,nrgoal,nsgoal,ncpass,ngattempt,phball) values(@gameid,@nrgoal,@nsgoal,@ncpass,@ngattempt,@phball)");
            insert.Parameters.AddWithValue("@gameid", this.gameid);
            insert.Parameters.AddWithValue("@nrgoal", this.nrgoal);
            insert.Parameters.AddWithValue("@nsgoal", this.nsgoal);
            insert.Parameters.AddWithValue("@ncpass", this.ncpass);
            insert.Parameters.AddWithValue("@ngattempt", this.ngattempt);
            insert.Parameters.AddWithValue("@phball", this.phball);
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
            SqlCommand insert = new SqlCommand("update participate set gameid=@gameid,nrgoal=@nrgoal,nsgoal=@nsgoal,ncpass=@ncpass,ngattempt=@ngattempt,phball=@phball where gameid=@gameid");
            insert.Parameters.AddWithValue("@gameid", this.gameid);
            insert.Parameters.AddWithValue("@nrgoal", this.nrgoal);
            insert.Parameters.AddWithValue("@nsgoal", this.nsgoal);
            insert.Parameters.AddWithValue("@ncpass", this.ncpass);
            insert.Parameters.AddWithValue("@ngattempt", this.ngattempt);
            insert.Parameters.AddWithValue("@phball", this.phball);
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
            SqlCommand insert = new SqlCommand("DELETE FROM participate where gameid=@gameid");
            insert.Parameters.AddWithValue("@gameid", this.gameid);
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
        public static List<participate> list()
        {
            List<participate> LP = new List<participate>();
            string query = "SELECT * FROM participate";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                participate emp = new participate();
                emp.gameid = dataRow["gameid"].ToString();
                emp.nrgoal = Convert.ToInt32(dataRow["nrgoal"].ToString());
                emp.nsgoal = Convert.ToInt32(dataRow["nsgoal"].ToString());
                emp.ncpass = Convert.ToInt32(dataRow["ncpass"].ToString());
                emp.ngattempt = Convert.ToInt32(dataRow["ngattempt"].ToString());
                emp.phball = Convert.ToInt32(dataRow["phball"].ToString());
                LP.Add(emp);
            }
            return LP;
        }
        public static participate search()
        {
            //search in database and replace it
            participate emp = new participate();
            return emp;
        }
        public static void test()
        {
            participate emp = new participate("0",1,2,100,12,50);
            participate emp1 = new participate("1", 2, 2, 100, 12, 50);
            participate emp2 = new participate("2", 3, 2, 100, 12, 50);
            participate emp3 = new participate("3", 4, 2, 100, 12, 50);
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<participate> LP = new List<participate>();
            LP = participate.list();
            foreach (participate emplo in LP)
            {
                Console.WriteLine(emplo.nrgoal);
            }
            emp.nrgoal = 100;
            emp.update();
            LP = participate.list();
            Console.WriteLine("second line");
            foreach (participate emplo in LP)
            {
                Console.WriteLine(emplo.nrgoal);
            }
            emp1.Delete();
            LP = participate.list();
            Console.WriteLine("third line");
            foreach (participate emplo in LP)
            {
                Console.WriteLine(emplo.nrgoal);
            }
        }

    }
}
