using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EProject
{
    public partial class UsersRecord : Form
    {
        loginUser i = new loginUser();
        public UsersRecord()
        {
            InitializeComponent();
        }
        void dispRecord()
        {
            loginUser cs = new loginUser();
            dgvUR.DataSource = cs.getUsers();
            dgvUR.Refresh();
            dgvUR.ReadOnly = true;

        }
        private void UsersRecord_Load(object sender, EventArgs e)
        {
            dispRecord();
        }

        private void dgvUR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (txtID.Text ==""|| string.IsNullOrEmpty(txtun.Text) || string.IsNullOrEmpty(txtpas.Text) || string.IsNullOrEmpty(txtcmb.Text))
            {
                MessageBox.Show("Please Enter Each Field");
                return;
            }

            if (i.UpdateUsers(txtID.Text,txtun.Text, txtpas.Text, txtcmb.Text))
            {
                txtID.Clear();
                txtun.Clear();
                txtpas.Clear();
                txtcmb.ResetText();
                dispRecord();
                MessageBox.Show("User Updated Successfully");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsun.Text))
            {
                MessageBox.Show("Please Enter Username");
                return;
            }
            string username = txtsun.Text;
            DataTable dt = i.searchByUsername(username);
            dgvUR.DataSource = dt;
            dgvUR.Refresh();
            dgvUR.ReadOnly = true;
            txtsun.Clear();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Record not found");
                dispRecord();
                return;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Mainform mainform = new Mainform();
            this.Hide();
            mainform.Show();
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtsun.Text))
            {
                MessageBox.Show("Please Enter Username");
                return;
            }

            if (i.delUser(txtsun.Text))
            {
                txtsun.Clear();
                dispRecord();

                MessageBox.Show("User Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Username Not Found!");
                dispRecord();
            }
        }
    }
}
