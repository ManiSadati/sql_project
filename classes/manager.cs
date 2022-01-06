using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    class manager
    {
        public static DBAccess dbaccess = new DBAccess();
        public int ID { set; get; }
        public string dname { set; get; }
        public string experience { set; get; }
        public string task { set; get; }
        public manager(int id, string dname,string experience,string task)
        {
            this.ID = id;
            this.dname = dname;
            this.experience = experience;
            this.task = task;
        }
        public manager()
        {
            this.ID = 0;
            this.dname = "";
            this.experience = "";
            this.task = "";
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into manager(id,dname,experience,task) values(@id,@dname,@experience,@task)");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@experience", this.experience);
            insert.Parameters.AddWithValue("@task", this.task);
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
            SqlCommand insert = new SqlCommand("update manager set id=@id,dname=@dname,experience=@experience,task=@task where id=@id");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@experience", this.experience);
            insert.Parameters.AddWithValue("@task", this.task);
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
            SqlCommand insert = new SqlCommand("DELETE FROM manager where id=@id");
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
        public static List<manager> list()
        {
            List<manager> LP = new List<manager>();
            string query = "SELECT * FROM manager";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                manager emp = new manager();
                emp.ID = Convert.ToInt32(dataRow["id"].ToString());
                emp.dname = dataRow["dname"].ToString();
                emp.experience = dataRow["experience"].ToString();
                emp.task = dataRow["task"].ToString();
                LP.Add(emp);
            }
            return LP;
        }
        public static manager search()
        {
            //search in database and replace it
            manager emp = new manager();
            return emp;
        }
        public static void test()
        {
            manager emp = new manager(0, "mohammad","very good manager worked at some where good","manager");
            manager emp1 = new manager(1, "mohammad1", "very good manager worked at some where good", "buy");
            manager emp2 = new manager(2, "mohammad2", "very good manager worked at some where good", "sel");
            manager emp3 = new manager(3, "mohammad3", "very good manager worked at some where good", "money");
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<manager> LP = new List<manager>();
            LP = manager.list();
            foreach (manager emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp.dname = "ali";
            emp.update();
            LP = manager.list();
            Console.WriteLine("second line");
            foreach (manager emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp1.Delete();
            LP = manager.list();
            Console.WriteLine("third line");
            foreach (manager emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
        }

    }
}
