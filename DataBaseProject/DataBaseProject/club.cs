using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseProject
{
    class club
    {
        public static DBAccess dbaccess = new DBAccess();
        public int ID { set; get; }
        public string dname { set; get; }
        public int twork { set; get; }
        public int income { set; get; }
        public int val { set; get; }
        public club(int id, string dname,int twork,int income,int vlaue)
        {
            this.ID = id;
            this.dname = dname;
            this.twork = twork;
            this.income = income;
            this.val = val;
        }
        public club()
        {
            this.ID = 0;
            this.dname = "";
            this.twork = 0;
            this.income = 0;
            this.val = 0;
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into club(id,dname,twork,income,val) values(@id,@dname,@twork,@income,@val)");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@twork", this.twork);
            insert.Parameters.AddWithValue("@income", this.income);
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
        public void update()
        {
            SqlCommand insert = new SqlCommand("update club set id=@id, dname=@dname, twork=@twork,income=@income,val=@val where id=@id");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@twork", this.twork);
            insert.Parameters.AddWithValue("@income", this.income);
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
        public void Delete()
        {
            SqlCommand insert = new SqlCommand("DELETE FROM club where id=@id");
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
        public static List<club> list()
        {
            List<club> LP = new List<club>();
            string query = "SELECT * FROM club";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                club emp = new club();
                emp.ID = Convert.ToInt32(dataRow["id"].ToString());
                emp.dname = dataRow["dname"].ToString();
                emp.twork = Convert.ToInt32(dataRow["twork"].ToString());
                emp.income = Convert.ToInt32(dataRow["income"].ToString());
                emp.val = Convert.ToInt32(dataRow["val"].ToString());
                LP.Add(emp);
            }
            return LP;
        }
        public static club search()
        {
            //search in database and replace it
            club emp = new club();
            return emp;
        }
        public static void test()
        {
            club emp = new club(0,"barca",10,20,30);
            club emp1 = new club(1, "barca1", 11, 21, 31);
            club emp2 = new club(2, "barca2", 12, 22, 32);
            club emp3 = new club(3, "barca3", 13, 23, 33);
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<club> LP = new List<club>();
            LP = club.list();
            foreach (club emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp.dname = "ali";
            emp.update();
            LP = club.list();
            Console.WriteLine("second line");
            foreach (club emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp1.Delete();
            LP = club.list();
            Console.WriteLine("third line");
            foreach (club emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
        }

    }
}
