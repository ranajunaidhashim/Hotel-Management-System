using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace EProject
{
    public partial class Restaurantinfo
    {
        restaurant st = new restaurant();
        /// <summary>
        /// 
        /// </summary>
        public Restaurantinfo()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {  restaurant st = new restaurant();
            if (string.IsNullOrEmpty(txtrn.Text) || string.IsNullOrEmpty(txtads.Text) || string.IsNullOrEmpty(txtcn.Text) || txtemail.Text == "" || txtId.Text=="")
            {
                MessageBox.Show("Please Enter Each Field");
                return;
            }

            if (st.saveInfo(txtId.Text, txtrn.Text, txtads.Text, txtcn.Text, txtemail.Text, txtdate.Value))
            {
                txtId.Clear();
                txtads.Clear();
                txtcn.Clear();
                txtrn.Clear();
                txtemail.Clear();

                MessageBox.Show("Added Successfully");
               // Mainform ca = new Mainform();
                // ca.MdiParent = this;
               // this.Hide();
               // ca.Show();
            }
          //  string query = "insert into restinfo values (@n,@a,@c,@e,@t,@s,@d,@p)";
            // 
  /*          cmd.Parameters.AddWithValue("n", txtrn.Text);
            cmd.Parameters.AddWithValue("a", txtads.Text);
            cmd.Parameters.AddWithValue("c", txtcn.Text);
            cmd.Parameters.AddWithValue("e", txtemail.Text);
            cmd.Parameters.AddWithValue("t", txttin.Text);
            cmd.Parameters.AddWithValue("s", txtst.Text);
            cmd.Parameters.AddWithValue("d", txtdate.Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfuly");
            con.Close();*/
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Mainform.Show();
            Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtrn.Text) || string.IsNullOrEmpty(txtads.Text) || string.IsNullOrEmpty(txtcn.Text) || txtemail.Text == "" || txtId.Text == "")
            {
                MessageBox.Show("Please Enter Each Field");
                return;
            }
            if (st.UpdateInfo(txtId.Text, txtrn.Text, txtads.Text, txtcn.Text, txtemail.Text, txtdate.Value))
            {
                txtId.Clear();
                txtads.Clear();
                txtcn.Clear();
                txtrn.Clear();
                txtemail.Clear();
                MessageBox.Show("Record Updated Successfully");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Enter ID");
                return;
            }
            string id = txtId.Text;
            DataTable dt = st.searchById(id);
            if(dt.Rows.Count > 0)
            {
                txtrn.Text = Conversions.ToString(dt.Rows[0][1]);
                txtads.Text = Conversions.ToString(dt.Rows[0][2]);
                txtcn.Text = Conversions.ToString(dt.Rows[0][3]);
                txtemail.Text = Conversions.ToString(dt.Rows[0][4]);
                // txtdate.Value = Conversions.ToDate(dt.Rows[0][5]);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Record not found");
            }
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            restaurant st = new restaurant();
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please Enter ID");
                return;
            }

            if (st.delInfo(txtId.Text))
            {
                txtId.Clear();
                MessageBox.Show("Record Deleted Successfully");
                // Mainform ca = new Mainform();
                // ca.MdiParent = this;
                // this.Hide();
                // ca.Show();
            }
            /*   var con = new OleDbConnection();
               var cmd = new OleDbCommand();
               var da = new OleDbDataAdapter();
               var dt = new DataTable();
               con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dell\Documents\HMS.mdb";
               con.Open();
               cmd.Connection = con;
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "delete from Restinfo where Tin=@t";
               cmd.Parameters.AddWithValue("t", txttin.Text);
               cmd.ExecuteNonQuery();
               MessageBox.Show("Record Deleted Successfully");
               con.Close();*/
        }

        private void btnchose_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
            PictureBox1.Image = Image.FromFile(ofd.FileName);
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}