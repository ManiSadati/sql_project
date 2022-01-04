using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    class tournament
    {
        public static DBAccess dbaccess = new DBAccess();
        public int ID { set; get; }
        public string dname { set; get; }
        public string wteam { set; get; }
        public int drank { set; get; }
        public string prise { set; get; }
        public int point { set; get; }
        public tournament(int id, string dname,string wteam,int drank,string prise,int point )
        {
            this.ID = id;
            this.dname = dname;
            this.wteam = wteam;
            this.drank = drank;
            this.prise = prise;
            this.point = point;
        }
        public tournament()
        {
            this.ID = 0;
            this.dname = "";
            this.wteam = "";
            this.drank = 0;
            this.prise = "";
            this.point = 0;
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into tournament(id,dname,wteam,drank,prise,point) values(@id,@dname,@wteam,@drank,@prise,@point)");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@wteam", this.wteam);
            insert.Parameters.AddWithValue("@drank", this.drank);
            insert.Parameters.AddWithValue("@prise", this.prise);
            insert.Parameters.AddWithValue("@point", this.point);
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
            SqlCommand insert = new SqlCommand("update tournament set id=@id,dname=@dname,wteam=@wteam,drank=@drank,prise=@prise,point=@point where id=@id");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@wteam", this.wteam);
            insert.Parameters.AddWithValue("@drank", this.drank);
            insert.Parameters.AddWithValue("@prise", this.prise);
            insert.Parameters.AddWithValue("@point", this.point);
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
            SqlCommand insert = new SqlCommand("DELETE FROM tournament where id=@id");
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
        public static List<tournament> list()
        {
            List<tournament> LP = new List<tournament>();
            string query = "SELECT * FROM tournament";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                tournament emp = new tournament();
                emp.ID = Convert.ToInt32(dataRow["id"].ToString());
                emp.dname = dataRow["dname"].ToString();
                emp.wteam = dataRow["wteam"].ToString();
                emp.drank = Convert.ToInt32(dataRow["drank"].ToString());
                emp.prise = dataRow["prise"].ToString();
                emp.point = Convert.ToInt32(dataRow["point"].ToString());
                LP.Add(emp);
            }
            return LP;
        }
        public static tournament search()
        {
            //search in database and replace it
            tournament emp = new tournament();
            return emp;
        }
        public static void test()
        {
            tournament emp = new tournament(0,"t1","barca1",1,"huge money",30);
            tournament emp1 = new tournament(1, "t2", "barca2", 1, "huge money1", 30);
            tournament emp2 = new tournament(2, "t3", "barca3", 2, "huge money2", 20);
            tournament emp3 = new tournament(3, "t4", "barca4", 3, "huge money3", 10);
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<tournament> LP = new List<tournament>();
            LP = tournament.list();
            foreach (tournament emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp.dname = "champions league";
            emp.update();
            LP = tournament.list();
            Console.WriteLine("second line");
            foreach (tournament emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp1.Delete();
            LP = tournament.list();
            Console.WriteLine("third line");
            foreach (tournament emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
        }

    }
}
