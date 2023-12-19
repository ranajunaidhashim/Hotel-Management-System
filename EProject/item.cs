using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EProject
{
    public partial class item
    {
        Items i = new Items();
        public item()
        {
            InitializeComponent();
        }
        public DataTable getItems()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Items";
            SqlDataAdapter da = new SqlDataAdapter(query, DbConnection.GetCon());
            try
            {
                da.Fill(dt);
                dgvItems.DataSource = dt;
                dgvItems.Refresh();
                dgvItems.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(cmbCategory.Text) || txtRate.Text == "" || txtDiscount.Text == "")
            {
                MessageBox.Show("Please Enter Each Field");
                return;
            }

            if (i.InsertItems(TextBox1.Text, txtItemName.Text, cmbCategory.Text, txtRate.Text, txtDiscount.Text))
            {
                TextBox1.Clear();
                txtItemName.Clear();
                cmbCategory.ResetText();
                txtRate.Clear();
                txtDiscount.Clear();
                getItems();
                MessageBox.Show("Items Saved Successfully");
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

                if (string.IsNullOrEmpty(TextBox1.Text))
                {
                    MessageBox.Show("Please Enter ID");
                    return;
                }

                if (i.delItem(TextBox1.Text))
                {
                TextBox1.Clear();
                getItems();

                    MessageBox.Show("Record Deleted Successfully");
                }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(cmbCategory.Text) || txtRate.Text == "" || txtDiscount.Text == "")
            {
                MessageBox.Show("Please Enter Each Field");
                return;
            }
            if (i.UpdateItems(TextBox1.Text, txtItemName.Text, cmbCategory.Text, txtRate.Text, txtDiscount.Text))
            {
                TextBox1.Clear();
                txtItemName.Clear();
                cmbCategory.ResetText();
                txtRate.Clear();
                txtDiscount.Clear();
                getItems();
                MessageBox.Show("Item Updated Successfully");
            }
        }

        private void Btnshow_Click(object sender, EventArgs e)
        {
            getItems();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.Mainform.Show();
        }

        private void item_Load(object sender, EventArgs e)
        {
            //dispRecord();
            getItems();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtSearchByDish.Text == "")
            {
                MessageBox.Show("Enter Item Name");
                return;
            }
            string name = txtSearchByDish.Text;
            DataTable dt = i.searchByName(name);
            dgvItems.DataSource = dt;
            dgvItems.ReadOnly = true;
            dgvItems.Refresh();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Record not found");
            }
        }
    }
}