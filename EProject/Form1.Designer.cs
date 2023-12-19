using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EProject
{
   [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LoginForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Label2 = new System.Windows.Forms.Label();
            this.txtpas = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Yellow;
            this.Label2.Location = new System.Drawing.Point(294, 197);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 26);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Password:";
            // 
            // txtpas
            // 
            this.txtpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpas.Location = new System.Drawing.Point(423, 201);
            this.txtpas.Name = "txtpas";
            this.txtpas.Size = new System.Drawing.Size(166, 22);
            this.txtpas.TabIndex = 2;
            this.txtpas.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Yellow;
            this.Label1.Location = new System.Drawing.Point(287, 150);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(107, 26);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Username:";
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(423, 156);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(166, 20);
            this.txtun.TabIndex = 0;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Yellow;
            this.btnlogin.Location = new System.Drawing.Point(351, 312);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(92, 37);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(479, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(295, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "UserType:";
            // 
            // txtcmb
            // 
            this.txtcmb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmb.FormattingEnabled = true;
            this.txtcmb.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.txtcmb.Location = new System.Drawing.Point(423, 251);
            this.txtcmb.Name = "txtcmb";
            this.txtcmb.Size = new System.Drawing.Size(166, 23);
            this.txtcmb.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightBlue;
            this.label7.Location = new System.Drawing.Point(329, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 42);
            this.label7.TabIndex = 32;
            this.label7.Text = "🔒 User Auth 🔐";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtpas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Label Label2;
        internal TextBox txtpas;
        internal Label Label1;
        internal TextBox txtun;
        internal Button btnlogin;
        internal Button button1;
        internal Label label3;
        private ComboBox txtcmb;
        private Label label7;
    }
}