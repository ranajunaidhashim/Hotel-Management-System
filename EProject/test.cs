using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EProject
{
    public partial class test
    {
        public test()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var con = new OleDbConnection();
            var cmd = new OleDbCommand();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\adnan\Documents\Database2.mdb";
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Table1 set Tdate=@td where ID=@i";
            cmd.Parameters.AddWithValue("td", DateTimePicker1.Value);
            cmd.Parameters.AddWithValue("i", TextBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("success");
        }
    }
}