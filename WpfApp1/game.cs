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
        public int ID { set; get; }
        public string wteam { set; get; }
        public string referee { set; get; }
        public int nfans { set; get; }
        public string opponent { set; get; }
        public game(int id, string wteam,string referee,int nfans,string opponent)
        {
            this.ID = id;
            this.wteam = wteam;
            this.referee = referee;
            this.nfans = nfans;
            this.opponent = opponent;
        }
        public game()
        {
            this.ID = 0;
            this.wteam = "";
            this.referee = "";
            this.nfans = 0;
            this.opponent = "";
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into game(id,wteam,referee,nfans,opponent) values(@id,@wteam,@referee,@nfans,@opponent)");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@wteam", this.wteam);
            insert.Parameters.AddWithValue("@referee", this.referee);
            insert.Parameters.AddWithValue("@nfans", this.nfans);
            insert.Parameters.AddWithValue("@opponent", this.opponent);
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
            SqlCommand insert = new SqlCommand("update game set id=@id,wteam=@wteam,referee=@referee,nfans=@nfans,opponent=@opponent where id=@id");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@wteam", this.wteam);
            insert.Parameters.AddWithValue("@referee", this.referee);
            insert.Parameters.AddWithValue("@nfans", this.nfans);
            insert.Parameters.AddWithValue("@opponent", this.opponent);
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
            SqlCommand insert = new SqlCommand("DELETE FROM game where id=@id");
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
        public static List<game> list()
        {
            List<game> LP = new List<game>();
            string query = "SELECT * FROM game";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                game emp = new game();
                emp.ID = Convert.ToInt32(dataRow["id"].ToString());
                emp.wteam = dataRow["wteam"].ToString();
                emp.referee = dataRow["referee"].ToString();
                emp.nfans = Convert.ToInt32(dataRow["nfans"].ToString());
                emp.opponent = dataRow["opponent"].ToString();
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
            game emp = new game(0,"barca","ali",10,"atletico");
            game emp1 = new game(1, "barca1", "ali1", 11, "atletico1");
            game emp2 = new game(2, "barca2", "ali2", 12, "atletico2");
            game emp3 = new game(3, "barca3", "ali3", 13, "atletico3");
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
