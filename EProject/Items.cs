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
    internal class Items
    {
        public bool InsertItems(string id, string name, string category, string rate, string discount)
        {
            string query = "Insert into Items(ID,Name, Category, Rate, Discount)  values (@id,@n,@a,@c,@e)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbConnection.GetCon();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@a", category);
            cmd.Parameters.AddWithValue("@c", rate);
            cmd.Parameters.AddWithValue("@e", discount);
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
        public bool delItem(string id)
        {
            string query = "Delete from Items where ID=@id";
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
        public bool UpdateItems(string id, string name, string category, string rate, string discount)
        {
            string query = "UPDATE Items SET Name=@n,Category=@a,Rate=@c,Discount=@e where ID=@id";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbConnection.GetCon();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@a", category);
            cmd.Parameters.AddWithValue("@c", rate);
            cmd.Parameters.AddWithValue("@e", discount);

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
        public DataTable searchByName(string name)
        {
            string query = "select * from Items where Name='" + name + "' ";
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

    }
}
