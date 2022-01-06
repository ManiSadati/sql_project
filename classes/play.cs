using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    class play
    {
        public static DBAccess dbaccess = new DBAccess();
        public int playerid { set; get; }
        public string gameid { set; get; }
        public int ngoal { set; get; }
        public int tplayed { set; get; }
        public int npass { set; get; }
        public int grade { set; get; }
        public int ncpass { set; get; }
        public int nscore { set; get; }
        public int sscore { set; get; }
        public play(int playerid,string gameid,int ngoal,int tplayed,int npass,int grade,int ncpass,int nscore,int sscore)
        {
            this.playerid = playerid;
            this.gameid = gameid;
            this.ngoal = ngoal;
            this.tplayed = tplayed;
            this.npass = npass;
            this.grade = grade;
            this.ncpass = ncpass;
            this.sscore = sscore;
            this.nscore = nscore;
        }
        public play()
        {
            this.playerid = 0;
            this.gameid = "";
            this.ngoal = 0;
            this.tplayed = 0;
            this.npass = 0;
            this.grade = 0;
            this.ncpass = 0;
            this.sscore = 0;
            this.nscore = 0;
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into play(playerid,gameid,ngoal,tplayed,npass,grade,ncpass,nscore,sscore) values(@playerid,@gameid,@ngoal,@tplayed,@npass,@grade,@ncpass,@nscore,@sscore)");
            insert.Parameters.AddWithValue("@playerid", this.playerid);
            insert.Parameters.AddWithValue("@gameid", this.gameid);
            insert.Parameters.AddWithValue("@ngoal", this.ngoal);
            insert.Parameters.AddWithValue("@tplayed", this.tplayed);
            insert.Parameters.AddWithValue("@npass", this.npass);
            insert.Parameters.AddWithValue("@grade", this.grade);
            insert.Parameters.AddWithValue("@ncpass", this.ncpass);
            insert.Parameters.AddWithValue("@nscore", this.nscore);
            insert.Parameters.AddWithValue("@sscore", this.sscore);
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
            SqlCommand insert = new SqlCommand("update play set ngoal=@ngoal,tplayed=@tplayed,npass=@npass,grade=@grade,ncpass=@ncpass,nscore=@nscore,sscore=@sscore where playerid=@playerid and gameid=@gameid");
            insert.Parameters.AddWithValue("@playerid", this.playerid);
            insert.Parameters.AddWithValue("@gameid", this.gameid);
            insert.Parameters.AddWithValue("@ngoal", this.ngoal);
            insert.Parameters.AddWithValue("@tplayed", this.tplayed);
            insert.Parameters.AddWithValue("@npass", this.npass);
            insert.Parameters.AddWithValue("@grade", this.grade);
            insert.Parameters.AddWithValue("@ncpass", this.ncpass);
            insert.Parameters.AddWithValue("@nscore", this.nscore);
            insert.Parameters.AddWithValue("@sscore", this.sscore);
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
            SqlCommand insert = new SqlCommand("DELETE FROM play where playerid=@playerid and gameid=@gameid");
            insert.Parameters.AddWithValue("@playerid", this.playerid);
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
        public static List<play> list()
        {
            List<play> LP = new List<play>();
            string query = "SELECT * FROM play";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                play emp = new play();
                emp.playerid = Convert.ToInt32(dataRow["playerid"].ToString());
                emp.gameid = dataRow["gameid"].ToString();
                emp.ngoal = Convert.ToInt32(dataRow["ngoal"].ToString());
                emp.npass = Convert.ToInt32(dataRow["npass"].ToString());
                emp.ncpass = Convert.ToInt32(dataRow["ncpass"].ToString());
                emp.tplayed = Convert.ToInt32(dataRow["tplayed"].ToString());
                emp.grade = Convert.ToInt32(dataRow["grade"].ToString());
                emp.nscore = Convert.ToInt32(dataRow["nscore"].ToString());
                emp.sscore = Convert.ToInt32(dataRow["sscore"].ToString());
                LP.Add(emp);
            }
            return LP;
        }
        public static play search()
        {
            //search in database and replace it
            play emp = new play();
            return emp;
        }
        public static void test()
        {
            play emp = new play(0, "3/9/79", 10,10,10,90,10,0,10);
            play emp1 = new play(2, "5/9/79", 14, 10, 90, 90, 10, 0, 0);
            play emp2 = new play(2, "3/9/79", 13, 10, 17, 90, 9, 0, 0);
            play emp3 = new play(3, "3/9/79", 15, 15, 10, 90, 10, 0, 0);
            emp.insert();
            Console.WriteLine("first inserted");
            emp1.insert();
            Console.WriteLine("second inserted");
            emp2.insert();
            Console.WriteLine("third inserted");
            emp3.insert();
            Console.WriteLine("fourth inserted");
            Console.WriteLine("first line");
            List<play> LP = new List<play>();
            LP = play.list();
            foreach (play emplo in LP)
            {
                Console.WriteLine(emplo.ngoal);
            }
            emp.ngoal = 100;
            emp.update();
            LP = play.list();
            Console.WriteLine("second line");
            foreach (play emplo in LP)
            {
                Console.WriteLine(emplo.ngoal);
            }
            emp1.Delete();
            LP = play.list();
            Console.WriteLine("third line");
            foreach (play emplo in LP)
            {
                Console.WriteLine(emplo.ngoal);
            }
        }

    }
}
