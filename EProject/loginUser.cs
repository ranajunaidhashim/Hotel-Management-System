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
    }
}
