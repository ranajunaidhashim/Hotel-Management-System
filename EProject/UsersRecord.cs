using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EProject
{
    public partial class UsersRecord : Form
    {
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
    }
}
