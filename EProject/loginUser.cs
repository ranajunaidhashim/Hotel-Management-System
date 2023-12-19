using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EProject
{
    public class loginUser
    {
        public bool SearchUser(string username, string password, string type)
        {
            string query = "SELECT * FROM Users WHERE username=@myun AND password=@pass AND userType=@mytype";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DbConnection.GetCon();
            cmd.Parameters.AddWithValue("@myun", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@mytype", type);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bool success = false;
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count == 1)
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
        public DataTable getUsers()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Users";
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
        public bool UpdateUsers(string myid, string username, string password, string type)
        {
            string query = "UPDATE Users SET username=@myun,password=@pass,userType=@mytype where userid=@id";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DbConnection.GetCon();
            cmd.Parameters.AddWithValue("@id", myid);
            cmd.Parameters.AddWithValue("@myun", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@mytype", type);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bool success = false;
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count == 1)
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
        public DataTable searchByUsername(string name)
        {
            string query = "select * from Users where username='" + name + "' ";
            SqlDataAdapter da = new SqlDataAdapter(query, DbConnection.GetCon());
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
        public bool delUser(string username)
        {
            string query = "Delete from Users where username=@un";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbConnection.GetCon();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@un", username);
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
    }
}
