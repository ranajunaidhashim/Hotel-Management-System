
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EProject
{
    /// 
    
    public class DbConnection
    {
        private static SqlConnection con;
        static DbConnection()
        {
            string str = "Data Source=LAPTOP-JUNAID;Initial Catalog=HMS;Integrated Security=True";
            con = new SqlConnection(str);

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// 
        public static void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        /// 
        public static SqlConnection GetCon()
        {
            return con;
        }
    }
}
