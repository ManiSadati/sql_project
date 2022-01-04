using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class product
    {
        public static DBAccess dbaccess = new DBAccess();
        public int ID { set; get; }
        public int price { set; get; }
        public string dname { set; get; }
        public int size { set; get; }
        public int remain { set; get; }
        public product(int id,int price,string dname,int size,int remain)
        {
            this.ID = id;
            this.price = price;
            this.dname = dname;
            this.size = size;
            this.remain = remain;
        }
        public product()
        {
            this.ID = 0;
            this.price = 0;
            this.dname = "";
            this.size = 0;
            this.remain = 0;
        }

        public void insert()
        {
            SqlCommand insert = new SqlCommand("insert into product(id,price,dname,size,remain) values(@id,@price,@dname,@size,@remain)");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@price", this.price);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@size", this.size);
            insert.Parameters.AddWithValue("@remain", this.remain);
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
            SqlCommand insert = new SqlCommand("update product set id=@id,price=@price,dname=@dname,size=@size,remain=@remain where id=@id");
            insert.Parameters.AddWithValue("@id", this.ID);
            insert.Parameters.AddWithValue("@price", this.price);
            insert.Parameters.AddWithValue("@dname", this.dname);
            insert.Parameters.AddWithValue("@size", this.size);
            insert.Parameters.AddWithValue("@remain", this.remain);
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
                emp.ID = Convert.ToInt32(dataRow["id"].ToString());
                emp.price = Convert.ToInt32(dataRow["price"].ToString());
                emp.dname = dataRow["dname"].ToString();
                emp.size = Convert.ToInt32(dataRow["size"].ToString());
                emp.remain = Convert.ToInt32(dataRow["remain"].ToString());
                LP.Add(emp);
            }
            return LP;
        }
        public static product search()
        {
            //search in database and replace it
            product emp = new product();
            return emp;
        }
        public static void test()
        {
            product emp = new product(0,20,"short",2,5);
            product emp1 = new product(1, 20, "short1", 2, 5);
            product emp2 = new product(2, 20, "short2", 2, 5);
            product emp3 = new product(3, 20, "short3", 2, 5);
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
