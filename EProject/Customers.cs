using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace EProject
{
    public partial class Customers
    {
        CustomersInfo cs = new CustomersInfo();
        public Customers()
        {
            InitializeComponent();
        }
        void dispRecord()
        {
            dataGridView1.DataSource = cs.getRecord();
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;

        }


        private void Button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Txtcid.Text) || string.IsNullOrEmpty(txtn.Text) || string.IsNullOrEmpty(txtadr.Text) || txte.Text == "" || txtcn.Text == "" || txtnotes.Text == "")
            {
                MessageBox.Show("Please Enter Each Field");
                return;
            }

            if (cs.InsertInfo(Txtcid.Text, txtn.Text, txtadr.Text, txtcn.Text, txte.Text, dtpcs.Value , txtnotes.Text))
            {
                Txtcid.Clear();
                txtn.Clear();
                txtcn.Clear();
                txtadr.Clear();
                txte.Clear();
                dtpcs.ResetText();
                txtnotes.Clear();
                dispRecord();
                MessageBox.Show("Record Successfully");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtcid.Text))
            {
                MessageBox.Show("Please Enter ID");
                return;
            }

            if (cs.delInfo(Txtcid.Text))
            {
                Txtcid.Clear();
                dispRecord();

                MessageBox.Show("Record Deleted Successfully");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtcid.Text) || string.IsNullOrEmpty(txtn.Text) || string.IsNullOrEmpty(txtadr.Text) || txte.Text == "" || txtcn.Text == "" || txtnotes.Text == "")
            {
                MessageBox.Show("Please Enter Each Field");
                return;
            }
            if (cs.UpdateInfo(Txtcid.Text, txtn.Text, txtadr.Text, txtcn.Text, txte.Text, dtpcs.Value, txtnotes.Text))
            {
                Txtcid.Clear();
                txtn.Clear();
                txtcn.Clear();
                txtadr.Clear();
                txte.Clear();
                dtpcs.ResetText();
                txtnotes.Clear();
                    
                MessageBox.Show("Record Updated Successfully");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Txtcid.Text == "")
            {
                MessageBox.Show("Enter ID");
                return;
            }
            string id = Txtcid.Text;
            DataTable dt = cs.searchById(id);
            if (dt.Rows.Count > 0)
            {
                dispRecord();
                Txtcid.Text = Conversions.ToString(dt.Rows[0][0]);
                txtn.Text = Conversions.ToString(dt.Rows[0][1]);
                txtadr.Text = Conversions.ToString(dt.Rows[0][2]);
                txtcn.Text = Conversions.ToString(dt.Rows[0][3]);
               // dtpcs.Value = Conversions.ToDate(dt.Rows[0][5]);
                txte.Text = Conversions.ToString(dt.Rows[0][4]);
                txtnotes.Text = Conversions.ToString(dt.Rows[0][6]);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Record not found");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.Mainform.Show();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            dispRecord();
        }
    }
}