using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EProject
{
    public class CustomersInfo
    {
        public bool InsertInfo(string id, string name, string address, string contact, string email, DateTime date ,string notes)
        {
            string query = "Insert into Customers(ID,Name, Address, Contact, Email,Date,Notes)  values (@id,@n,@a,@c,@e,@d,@nt)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbConnection.GetCon();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@a", address);
            cmd.Parameters.AddWithValue("@c", contact);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@nt", notes);
            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        public bool delInfo(string id)
        {
            string query = "Delete from Customers where ID=@id";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbConnection.GetCon();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);

            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        public bool UpdateInfo(string id, string name, string address, string contact, string email, DateTime date, string notes)
        {
            string query = "UPDATE Customers SET Name=@n,Address=@a,Contact=@c,Email=@e,Date=@d,Notes=@nt where ID=@id";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbConnection.GetCon();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@a", address);
            cmd.Parameters.AddWithValue("@c", contact);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@nt", notes);

            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public DataTable searchById(string id)
        {
            string query = "select * from Customers where ID=@myid";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DbConnection.GetCon();
            cmd.Parameters.AddWithValue("@myid", id);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable getRecord()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Customers";
            SqlDataAdapter da = new SqlDataAdapter(query, DbConnection.GetCon());
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
