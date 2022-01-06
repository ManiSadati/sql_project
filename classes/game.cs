using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    class game
    {
        public static DBAccess dbaccess = new DBAccess();
        public string date_time { set; get; }
        public string wteam { set; get; }
        public string referee { set; get; }
        public int nfans { set; get; }
        public string opponent { set; get; }
        public int tourid { set; get; }
        public game(string date_time, string wteam,string referee,int nfans,string opponent,int tourid)
        {
            this.date_time = date_time;
            this.wteam = wteam;
            this.referee = referee;
            this.nfans = nfans;
            this.opponent = opponent;
            this.tourid = tourid;
        }
        public game()
        {
            this.date_time = "";
            this.wteam = "";
            this.referee = "";
            this.nfans = 0;
            this.opponent = "";
            this.tourid = 0;
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into game(date_time,wteam,referee,nfans,opponent,tourid) values(@date_time,@wteam,@referee,@nfans,@opponent,@tourid)");
            insert.Parameters.AddWithValue("@date_time", this.date_time);
            insert.Parameters.AddWithValue("@wteam", this.wteam);
            insert.Parameters.AddWithValue("@referee", this.referee);
            insert.Parameters.AddWithValue("@nfans", this.nfans);
            insert.Parameters.AddWithValue("@opponent", this.opponent);
            insert.Parameters.AddWithValue("@tourid", this.tourid);
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
            SqlCommand insert = new SqlCommand("update game set date_time=@date_time,wteam=@wteam,referee=@referee,nfans=@nfans,opponent=@opponent,tourid=@tourid where date_time=@date_time");
            insert.Parameters.AddWithValue("@date_time", this.date_time);
            insert.Parameters.AddWithValue("@wteam", this.wteam);
            insert.Parameters.AddWithValue("@referee", this.referee);
            insert.Parameters.AddWithValue("@nfans", this.nfans);
            insert.Parameters.AddWithValue("@opponent", this.opponent);
            insert.Parameters.AddWithValue("@tourid", this.tourid);
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
            SqlCommand insert = new SqlCommand("DELETE FROM game where date_time=@date_time");
            insert.Parameters.AddWithValue("@date_time", this.date_time);
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
        public static game find_by_date(string date_time)
        {
            List<game> LP = new List<game>();
            string query = "SELECT * FROM game where date_time="+date_time;
            //insert.Parameters.AddWithValue("@date_time", this.date_time);
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            game emp = new game();
            foreach (DataRow dataRow in ans.Rows)
            {
                emp.date_time = dataRow["date_time"].ToString();
                emp.wteam = dataRow["wteam"].ToString();
                emp.referee = dataRow["referee"].ToString();
                emp.nfans = Convert.ToInt32(dataRow["nfans"].ToString());
                emp.opponent = dataRow["opponent"].ToString();
                emp.tourid = Convert.ToInt32(dataRow["tourid"].ToString());
            }
            return emp;
        }
        public static List<player> player_list(string date_time)
        {
            List<play> LP = new List<play>();
            List<player> LP1 = new List<player>();
            string query = "SELECT * FROM play where date_time="+date_time;
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                int id = Convert.ToInt32(dataRow["playerid"].ToString());
                player p = player.find(id);
                LP1.Add(p);
            }
            return LP1;
        }
        public static player score_player(string date_time,string name,int score)
        {
            List<play> LP = new List<play>();
            string query = "SELECT * FROM play where date_time=" + date_time;
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            play emp = new play();
            player p = new player();
            foreach (DataRow dataRow in ans.Rows)
            {
                int id = Convert.ToInt32(dataRow["playerid"].ToString());
                p = player.find(id);
                if (p.firstname == name)
                {
                    emp.playerid = Convert.ToInt32(dataRow["playerid"].ToString());
                    emp.gameid = dataRow["gameid"].ToString();
                    emp.ngoal = Convert.ToInt32(dataRow["ngoal"].ToString());
                    emp.npass = Convert.ToInt32(dataRow["npass"].ToString());
                    emp.ncpass = Convert.ToInt32(dataRow["ncpass"].ToString());
                    emp.tplayed = Convert.ToInt32(dataRow["tplayed"].ToString());
                    emp.grade = Convert.ToInt32(dataRow["grade"].ToString());
                    emp.nscore = Convert.ToInt32(dataRow["nscore"].ToString());
                    emp.sscore = Convert.ToInt32(dataRow["sscore"].ToString());
                    break;
                }
            }
            emp.nscore += 1;
            emp.sscore += score;
            emp.update();
            return p;
        }
        public static player tournoment_performance(int tourid, int playerid)
        {
            List<play> LP = new List<play>();
            string query = "SELECT AVG(ngoal) as \"ngoal\",AVG(tplayed) as \"tplayed\",AVG(npass) as \"npass\",AVG(grade) as \"grade\",AVG(ncpass) as \"ncpass\",SUM(nscore) as \"nscore\",SUM(sscore) as \"sscore\" FROM play where gameid in(SELECT date_time from game where tourid="+Convert.ToString(tourid)+" ) and playerid=" + Convert.ToString(playerid);
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            play emp = new play();
            player p = new player();
            if (ans.Rows.Count > 0)
            {
                emp.ngoal = Convert.ToInt32(ans.Rows[0]["ngoal"].ToString());
                emp.npass = Convert.ToInt32(ans.Rows[0]["npass"].ToString());
                emp.ncpass = Convert.ToInt32(ans.Rows[0]["ncpass"].ToString());
                emp.tplayed = Convert.ToInt32(ans.Rows[0]["tplayed"].ToString());
                emp.grade = Convert.ToInt32(ans.Rows[0]["grade"].ToString());
                emp.nscore = Convert.ToInt32(ans.Rows[0]["nscore"].ToString());
                emp.sscore = Convert.ToInt32(ans.Rows[0]["sscore"].ToString());
            }
            return p;
        }
        public static List<game> list()
        {
            List<game> LP = new List<game>();
            string query = "SELECT * FROM game";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                game emp = new game();
                emp.date_time = dataRow["date_time"].ToString();
                emp.wteam = dataRow["wteam"].ToString();
                emp.referee = dataRow["referee"].ToString();
                emp.nfans = Convert.ToInt32(dataRow["nfans"].ToString());
                emp.opponent = dataRow["opponent"].ToString();
                emp.tourid = Convert.ToInt32(dataRow["tourid"].ToString());
                LP.Add(emp);
            }
            return LP;
        }
        public static game search()
        {
            //search in database and replace it
            game emp = new game();
            return emp;
        }
        public static void test()
        {
            game emp = new game("3/9/79","barca","ali",10,"atletico",1);
            game emp1 = new game("4/9/79", "barca1", "ali1", 11, "atletico1", 1);
            game emp2 = new game("5/9/79", "barca2", "ali2", 12, "atletico2", 1);
            game emp3 = new game("6/9/79", "barca3", "ali3", 13, "atletico3", 1);
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<game> LP = new List<game>();
            LP = game.list();
            foreach (game emplo in LP)
            {
                Console.WriteLine(emplo.wteam);
            }
            emp.wteam = "real";
            emp.update();
            LP = game.list();
            Console.WriteLine("second line");
            foreach (game emplo in LP)
            {
                Console.WriteLine(emplo.wteam);
            }
            emp1.Delete();
            LP = game.list();
            Console.WriteLine("third line");
            foreach (game emplo in LP)
            {
                Console.WriteLine(emplo.wteam);
            }
        }

    }
}
