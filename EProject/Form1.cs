using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace EProject
{
    public partial class LoginForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            loginUser st = new loginUser();
        /*    if (txtun.Text == "" || txtpas.Text == "" || txtcmb.Text == "")
            {
                MessageBox.Show("Please Enter Each Field");
                return;
            }*/
            if (string.IsNullOrEmpty(txtun.Text) || string.IsNullOrEmpty(txtpas.Text) || string.IsNullOrEmpty(txtcmb.Text))
            {
                MessageBox.Show("Please Enter Each Field");
                return;
            }

            if (st.SearchUser(txtun.Text, txtpas.Text, txtcmb.Text))
            {
                MessageBox.Show("Login Successfully");
                Mainform ca = new Mainform();
                // ca.MdiParent = this;
                ca.SetLoggedInUser(txtun.Text);
                ca.DisableLogin();
                ca.EnableLogout();
                ca.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            DbConnection.close();
        }
    }
}