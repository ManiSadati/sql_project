using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class customer
    {
        public static DBAccess dbaccess = new DBAccess();
        public int ID { set; get; }
        public string dname { set; get; }
        public string email { set; get; }
        public string pass { set; get; }
        public string addres { set; get; }
        public int credit { set; get; }

        public customer(int id, string dname,  string email, string pass, string addres, int credit)
        {
            this.ID = id;
            this.dname = dname;
            this.email = email;
            this.pass = pass;
            this.addres = addres;
            this.credit = credit;
        }

        public customer()
        {
            this.ID = 0;
            this.dname = "";
            this.email = "";
            this.pass = "";
            this.addres = "";
            this.credit = 0;
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into customer(dname, id, email, pass, addres, credit) values(@dname, @id, @email, @pass, @addres, @credit)");
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@email", this.email);
            insert.Parameters.AddWithValue("@pass", this.pass);
            insert.Parameters.AddWithValue("@addres", this.addres);
            insert.Parameters.AddWithValue("@credit", this.credit);
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
            SqlCommand insert = new SqlCommand("update customer set dname=@dname, id=@id, email=@email, pass=@pass, addres=@addres, credit=@credit where id=@id");
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@email", this.email);
            insert.Parameters.AddWithValue("@pass", this.pass);
            insert.Parameters.AddWithValue("@addres", this.addres);
            insert.Parameters.AddWithValue("@credit", this.credit);
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
            SqlCommand insert = new SqlCommand("DELETE FROM customer where id=@id");
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
        public static List<customer> list()
        {
            List<customer> LP = new List<customer>();
            string query = "SELECT * FROM customer";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                customer emp = new customer();
                emp.ID = Convert.ToInt32(dataRow["id"].ToString());
                emp.dname = dataRow["dname"].ToString();
                emp.email = dataRow["email"].ToString();
                emp.pass = dataRow["pass"].ToString();
                emp.addres = dataRow["addres"].ToString();
                emp.credit = Convert.ToInt32(dataRow["credit"].ToString());
                LP.Add(emp);
            }
            return LP;
        }
        public static customer find(string email, string pass)
        {
            string query = "SELECT * FROM customer where email="+email+" pass="+pass;
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            if (ans.Rows.Count > 0)
            {
                customer emp = new customer();
                emp.ID = Convert.ToInt32(ans.Rows[0]["id"].ToString());
                emp.dname = ans.Rows[0]["dname"].ToString();
                emp.email = ans.Rows[0]["email"].ToString();
                emp.pass = ans.Rows[0]["pass"].ToString();
                emp.addres = ans.Rows[0]["addres"].ToString();
                emp.credit = Convert.ToInt32(ans.Rows[0]["credit"].ToString());
                return emp;
            }
            return null;
        }
        public static customer search()
        {
            //search in database and replace it
            customer emp = new customer();
            return emp;
        }
        
        public static void test()
        {
            customer emp = new customer(0,"mohamad","m@s","sdfasdf","some where",10);
            customer emp1 = new customer(1, "mohamad1", "m@s", "sdfasdf", "some where", 10);
            customer emp2 = new customer(2, "mohamad2", "m@s", "sdfasdf", "some where", 10);
            customer emp3 = new customer(3, "mohamad3", "m@s", "sdfasdf", "some where", 10);
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<customer> LP = new List<customer>();
            LP = customer.list();
            foreach (customer emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp.dname = "ali";
            emp.update();
            LP = customer.list();
            Console.WriteLine("second line");
            foreach (customer emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp1.Delete();
            LP = customer.list();
            Console.WriteLine("third line");
            foreach (customer emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
        }
        

    }
}
