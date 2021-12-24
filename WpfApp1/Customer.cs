using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    public class Customer
    {

        public string ID { set; get; }
        public string name { set; get; }
        public string NID { set; get; }
        public string email { set; get; }
        public string password { set; get; }
        public string address { set; get; }
        public string credit { set; get; }

        public Customer(string id, string name, string nid, string email, string password, string address, string credit)
        {
            this.ID = id;
            this.name = name;
            this.NID = nid;
            this.email = email;
            this.password = password;
            this.address = address;
            this.credit = credit;
        }
        public static int insert(string Costumername, string CostumerNID, string CostumerEmail, string CostumerPassword, string CostumerAddress, string costumercredit)
        {
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Costumer(Name, NID, email, password, Address, Credit)" +
                    " values(@Costumername, @CostumerNID, @CostumerEmail, @CostumerPassword, @CostumerAddress, @credit)");

            insertCommand.Parameters.AddWithValue("@Costumername", Costumername);
            insertCommand.Parameters.AddWithValue("@CostumerNID", CostumerNID);
            insertCommand.Parameters.AddWithValue("@CostumerEmail", CostumerEmail);
            insertCommand.Parameters.AddWithValue("@CostumerPassword", CostumerPassword);
            insertCommand.Parameters.AddWithValue("@CostumerAddress", CostumerAddress);
            insertCommand.Parameters.AddWithValue("@credit", costumercredit);

            DBAccess objDBAcess = new DBAccess();
            int row = objDBAcess.executeQuery(insertCommand);
            objDBAcess.closeConn();
            return row;
        }
        public static Customer find(string email, string password)
        {
            DBAccess objDBAcess = new DBAccess();
            DataTable dtCustomer = new DataTable();
            string query = "SELECT * FROM customer WHERE Email= '" + email + "' AND Password = '" + password + "'";
            objDBAcess.readDatathroughAdapter(query, dtCustomer);

            if (dtCustomer.Rows.Count == 1)
            {
                string id = dtCustomer.Rows[0]["ID"].ToString();
                string Name = dtCustomer.Rows[0]["Name"].ToString();
                string NID = dtCustomer.Rows[0]["NID"].ToString();
                string Address = dtCustomer.Rows[0]["address"].ToString();
                string credit = dtCustomer.Rows[0]["credit"].ToString();

                Customer customer = new Customer(id, Name, NID, email, password, Address, credit);
                objDBAcess.closeConn();
                return customer;
            }
            else
            {
                return null;
            }

        }
    }
}
