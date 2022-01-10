using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject
{
    class product
    {
        public static DBAccess dbaccess = new DBAccess();
        public string ID { set; get; }
        public int price { set; get; }
        public string dname { set; get; }
        public int size { set; get; }
        public int remain { set; get; }
        public string date_time { set; get; }
        public int nsell { set; get; }
        public product(string id, int price, string dname, int size, int remain, string date_time, int nsell)
        {
            this.ID = id;
            this.price = price;
            this.dname = dname;
            this.size = size;
            this.remain = remain;
            this.date_time = date_time;
            this.nsell = nsell;
        }
        public product()
        {
            this.ID = "";
            this.price = 0;
            this.dname = "";
            this.size = 0;
            this.remain = 0;
            this.nsell = 0;
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into product(id,price,dname,size,remain,date_time,nsell) values(@id,@price,@dname,@size,@remain,@date_time,@nsell)");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@price", this.price);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@size", this.size);
            insert.Parameters.AddWithValue("@remain", this.remain);
            insert.Parameters.AddWithValue("@date_time", this.date_time);
            insert.Parameters.AddWithValue("@nsell", this.nsell);
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
        public string buy(int number, customer cs)
        {
            if (number > remain || cs.credit < number * this.price)
            {
                return "not enough";
            }
            else
            {
                this.remain -= number;
                this.nsell += number;
                List<club> LP = new List<club>();
                LP = club.list();
                foreach (club clb in LP)
                {
                    clb.income += number * this.price;
                    clb.update();
                }
                this.update();
                if (this.dname == "ticket")
                {
                    game g = game.find_by_date(this.date_time);
                    g.nfans += number;
                    g.update();
                }
                cs.credit -= number * this.price;
                cs.update();
                return "successful";
            }
        }
        public int total_price(int number)
        {
            return number * this.price;
        }
        public void update()
        {
            SqlCommand insert = new SqlCommand("update product set id=@id,price=@price,dname=@dname,size=@size,remain=@remain,date_time=@date_time,nsell=@nsell where id=@id");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@price", this.price);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@size", this.size);
            insert.Parameters.AddWithValue("@remain", this.remain);
            insert.Parameters.AddWithValue("@date_time", this.date_time);
            insert.Parameters.AddWithValue("@nsell", this.nsell);
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
            SqlCommand insert = new SqlCommand("DELETE FROM product where id=@id");
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
        public static List<product> list()
        {
            List<product> LP = new List<product>();
            string query = "SELECT * FROM product";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            foreach (DataRow dataRow in ans.Rows)
            {
                product emp = new product();
                emp.ID = dataRow["id"].ToString();
                emp.price = Convert.ToInt32(dataRow["price"].ToString());
                emp.dname = dataRow["dname"].ToString();
                emp.size = Convert.ToInt32(dataRow["size"].ToString());
                emp.remain = Convert.ToInt32(dataRow["remain"].ToString());
                emp.date_time = dataRow["date_time"].ToString();
                emp.nsell = Convert.ToInt32(dataRow["nsell"].ToString());
                LP.Add(emp);
            }
            return LP;
        }
        public static product find(string name, string date_time = "")
        {
            string query = "SELECT * FROM product where dname='" + name + "' and date_time='" + date_time + "'";
            DataTable ans = new DataTable();
            dbaccess.readDatathroughAdapter(query, ans);
            product emp = new product();
            if (ans.Rows.Count > 0)
            {
                emp.ID = ans.Rows[0]["id"].ToString();
                emp.price = Convert.ToInt32(ans.Rows[0]["price"].ToString());
                emp.dname = ans.Rows[0]["dname"].ToString();
                emp.size = Convert.ToInt32(ans.Rows[0]["size"].ToString());
                emp.remain = Convert.ToInt32(ans.Rows[0]["remain"].ToString());
                emp.date_time = ans.Rows[0]["date_time"].ToString();
                emp.nsell = Convert.ToInt32(ans.Rows[0]["nsell"].ToString());
                return emp;
            }
            return null;
        }
        public static product search()
        {
            //search in database and replace it
            product emp = new product();
            return emp;
        }
        public static void test()
        {
            product emp = new product("0", 20, "short", 2, 5, "farda", 0);
            product emp1 = new product("1", 20, "short1", 2, 5, "farda", 0);
            product emp2 = new product("2", 20, "short2", 2, 5, "pasfarda", 0);
            product emp3 = new product("3", 20, "short3", 2, 5, "2 roz dige", 0);
            emp.insert();
            emp1.insert();
            emp2.insert();
            emp3.insert();
            Console.WriteLine("first line");
            List<product> LP = new List<product>();
            LP = product.list();
            foreach (product emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp.dname = "cap";
            emp.update();
            LP = product.list();
            Console.WriteLine("second line");
            foreach (product emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
            emp1.Delete();
            LP = product.list();
            Console.WriteLine("third line");
            foreach (product emplo in LP)
            {
                Console.WriteLine(emplo.dname);
            }
        }

    }
}
