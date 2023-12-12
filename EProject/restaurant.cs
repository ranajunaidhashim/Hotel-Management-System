using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EProject
{
    internal class restaurant
    {
        public bool saveInfo(string id,string name, string address, string contact, string email, DateTime date)
        {
            string query = "Insert into RestInfo(ID,Name, Address, Contact, Email,Date)  values (@id,@n,@a,@c,@e,@d)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbConnection.GetCon();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@a", address);
            cmd.Parameters.AddWithValue("@c", contact);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@d", date.Year);
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
            string query = "Delete from RestInfo where ID=@id";
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
        public bool UpdateInfo(string id, string name, string address, string contact, string email, DateTime date)
        {
            string query = "UPDATE RestInfo SET Name=@n,Address=@a,Contact=@c,Email=@e,Date=@d where ID=@id";
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
            string query = "select * from RestInfo where ID=@myid";
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
    }
}
