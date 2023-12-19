using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EProject
{/// <summary>
/// 
/// </summary>
    public partial class Mainform
    {/// <summary>
     /// 
     /// </summary>
     /// 
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestaurantInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BilingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            resources.ApplyResources(this.MenuStrip1, "MenuStrip1");
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntryToolStripMenuItem,
            this.UserToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.BilingToolStripMenuItem,
            this.ReportsToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuStrip1.Name = "MenuStrip1";
            // 
            // EntryToolStripMenuItem
            // 
            this.EntryToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestaurantInfoToolStripMenuItem,
            this.CurrencyToolStripMenuItem,
            this.CategoryToolStripMenuItem});
            resources.ApplyResources(this.EntryToolStripMenuItem, "EntryToolStripMenuItem");
            this.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem";
            // 
            // RestaurantInfoToolStripMenuItem
            // 
            this.RestaurantInfoToolStripMenuItem.Name = "RestaurantInfoToolStripMenuItem";
            resources.ApplyResources(this.RestaurantInfoToolStripMenuItem, "RestaurantInfoToolStripMenuItem");
            this.RestaurantInfoToolStripMenuItem.Click += new System.EventHandler(this.RestaurantInfoToolStripMenuItem_Click);
            // 
            // CurrencyToolStripMenuItem
            // 
            this.CurrencyToolStripMenuItem.Name = "CurrencyToolStripMenuItem";
            resources.ApplyResources(this.CurrencyToolStripMenuItem, "CurrencyToolStripMenuItem");
            this.CurrencyToolStripMenuItem.Click += new System.EventHandler(this.CurrencyToolStripMenuItem_Click);
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            resources.ApplyResources(this.CategoryToolStripMenuItem, "CategoryToolStripMenuItem");
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            resources.ApplyResources(this.UserToolStripMenuItem, "UserToolStripMenuItem");
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Click += new System.EventHandler(this.UserToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            resources.ApplyResources(this.loginToolStripMenuItem, "loginToolStripMenuItem");
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // logoutToolStripMenuItem
            // 
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            resources.ApplyResources(this.CustomerToolStripMenuItem, "CustomerToolStripMenuItem");
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // BilingToolStripMenuItem
            // 
            resources.ApplyResources(this.BilingToolStripMenuItem, "BilingToolStripMenuItem");
            this.BilingToolStripMenuItem.Name = "BilingToolStripMenuItem";
            this.BilingToolStripMenuItem.Click += new System.EventHandler(this.BilingToolStripMenuItem_Click);
            // 
            // ReportsToolStripMenuItem
            // 
            resources.ApplyResources(this.ReportsToolStripMenuItem, "ReportsToolStripMenuItem");
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculatorToolStripMenuItem,
            this.NotepadToolStripMenuItem});
            resources.ApplyResources(this.ToolsToolStripMenuItem, "ToolsToolStripMenuItem");
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            // 
            // CalculatorToolStripMenuItem
            // 
            this.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem";
            resources.ApplyResources(this.CalculatorToolStripMenuItem, "CalculatorToolStripMenuItem");
            this.CalculatorToolStripMenuItem.Click += new System.EventHandler(this.CalculatorToolStripMenuItem_Click);
            // 
            // NotepadToolStripMenuItem
            // 
            this.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem";
            resources.ApplyResources(this.NotepadToolStripMenuItem, "NotepadToolStripMenuItem");
            this.NotepadToolStripMenuItem.Click += new System.EventHandler(this.NotepadToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RestaurantInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restaurantinfo ca = new Restaurantinfo();
            ca.MdiParent = this;
            ca.Show();
        }

        private void CurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Currency ca = new Currency();
            ca.MdiParent = this;
            ca.Show();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Customers ca = new Customers();
            ca.MdiParent = this;
            ca.Show();
        }

        private void CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void NotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            item ca = new item();
            ca.MdiParent = this;
            ca.Show();
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
           ///////// loginUser lu = new loginUser();
            //
            LoginForm ca = new LoginForm();
         // ca.MdiParent = this;
            ca.Show();
            this.Hide();

        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Customers ca = new Customers();
            ca.MdiParent = this;
            ca.Show();
        }
        public void SetLoggedInUser(string username)
        {
            // Assuming toolStripStatusLabel1 is your toolstrip label
            UserToolStripMenuItem.Text =  username;
        }
        public void DisableLogin()
        {
            loginToolStripMenuItem.Enabled = false;
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Reset the logged-in username
            // UserSession.LoggedInUsername = null;
            UserToolStripMenuItem.Text = "User";
            // Enable the Login menu item
            loginToolStripMenuItem.Enabled = true;
            MessageBox.Show("Session LoggedOut \n Please Login Again" );

        }
        public void EnableLogout()
        {
            logoutToolStripMenuItem.Enabled = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            UsersRecord u = new UsersRecord();
            u.MdiParent = this;
            u.Show();
        }

        private void BilingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            item ca = new item();
            ca.MdiParent = this;
            ca.Show();
        }
    }
}