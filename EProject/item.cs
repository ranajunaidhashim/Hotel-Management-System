using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EProject
{
    public partial class item
    {
        public item()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var con = new OleDbConnection();
            var cmd = new OleDbCommand();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dell\Documents\HMS.mdb";
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Items values (@n,@a,@v,@c,@e)";
            cmd.Parameters.AddWithValue("n", TextBox1.Text);
            cmd.Parameters.AddWithValue("a", txtItemName.Text);
            cmd.Parameters.AddWithValue("v", cmbCategory.Text);
            cmd.Parameters.AddWithValue("c", txtRate.Text);
            cmd.Parameters.AddWithValue("e", txtDiscount.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfuly");
            con.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var con = new OleDbConnection();
            var cmd = new OleDbCommand();
            var da = new OleDbDataAdapter();
            var dt = new DataTable();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dell\Documents\HMS.mdb";
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Items where ID=@n";
            cmd.Parameters.AddWithValue("n", TextBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            con.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var con = new OleDbConnection();
            var cmd = new OleDbCommand();
            var da = new OleDbDataAdapter();
            var dt = new DataTable();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dell\Documents\HMS.mdb";
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Items SET ID=@i,IName=@a,Category=@c,Rate=@e,Discount=@t where ID=@i";
            // 
            cmd.Parameters.AddWithValue("@i", TextBox1.Text);
            cmd.Parameters.AddWithValue("@a", txtItemName.Text);
            cmd.Parameters.AddWithValue("@c", cmbCategory.Text);
            cmd.Parameters.AddWithValue("@e", txtRate.Text);
            cmd.Parameters.AddWithValue("@t", txtDiscount.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfuly");
            con.Close();
        }

        private void Btnshow_Click(object sender, EventArgs e)
        {
            var con = new OleDbConnection();
            var cmd = new OleDbCommand();
            var da = new OleDbDataAdapter();
            var dt = new DataTable();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dell\Documents\HMS.mdb";
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Items";
            da.SelectCommand = cmd;
            da.Fill(dt);
            DataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.Mainform.Show();
        }
    }
}