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
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BilingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntryToolStripMenuItem,
            this.UserToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.BilingToolStripMenuItem,
            this.ReportsToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1028, 28);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // EntryToolStripMenuItem
            // 
            this.EntryToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestaurantInfoToolStripMenuItem,
            this.CurrencyToolStripMenuItem,
            this.CategoryToolStripMenuItem,
            this.ProductToolStripMenuItem});
            this.EntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EntryToolStripMenuItem.Image")));
            this.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem";
            this.EntryToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.EntryToolStripMenuItem.Text = "Entry";
            // 
            // RestaurantInfoToolStripMenuItem
            // 
            this.RestaurantInfoToolStripMenuItem.Name = "RestaurantInfoToolStripMenuItem";
            this.RestaurantInfoToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.RestaurantInfoToolStripMenuItem.Text = "Restaurant Info";
            this.RestaurantInfoToolStripMenuItem.Click += new System.EventHandler(this.RestaurantInfoToolStripMenuItem_Click);
            // 
            // CurrencyToolStripMenuItem
            // 
            this.CurrencyToolStripMenuItem.Name = "CurrencyToolStripMenuItem";
            this.CurrencyToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.CurrencyToolStripMenuItem.Text = "Currency";
            this.CurrencyToolStripMenuItem.Click += new System.EventHandler(this.CurrencyToolStripMenuItem_Click);
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.CategoryToolStripMenuItem.Text = "Category";
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.ProductToolStripMenuItem.Text = "Items";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.UserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UserToolStripMenuItem.Image")));
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.UserToolStripMenuItem.Text = "User";
            this.UserToolStripMenuItem.Click += new System.EventHandler(this.UserToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Enabled = false;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CustomerToolStripMenuItem.Image")));
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.CustomerToolStripMenuItem.Text = "Customers";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // BilingToolStripMenuItem
            // 
            this.BilingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BilingToolStripMenuItem.Image")));
            this.BilingToolStripMenuItem.Name = "BilingToolStripMenuItem";
            this.BilingToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.BilingToolStripMenuItem.Text = "Biling";
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReportsToolStripMenuItem.Image")));
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.ReportsToolStripMenuItem.Text = "Reports";
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculatorToolStripMenuItem,
            this.NotepadToolStripMenuItem});
            this.ToolsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ToolsToolStripMenuItem.Image")));
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // CalculatorToolStripMenuItem
            // 
            this.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem";
            this.CalculatorToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.CalculatorToolStripMenuItem.Text = "Calculator";
            this.CalculatorToolStripMenuItem.Click += new System.EventHandler(this.CalculatorToolStripMenuItem_Click);
            // 
            // NotepadToolStripMenuItem
            // 
            this.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem";
            this.NotepadToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.NotepadToolStripMenuItem.Text = "Notepad";
            this.NotepadToolStripMenuItem.Click += new System.EventHandler(this.NotepadToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem4.Text = "Users Record";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // Mainform
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 574);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Restaurant Form";
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
    }
}