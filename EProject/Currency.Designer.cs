using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EProject
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Currency : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Currency));
            GroupBox1 = new GroupBox();
            Label2 = new Label();
            TextBox1 = new TextBox();
            Label1 = new Label();
            Button1 = new Button();
            Button3 = new Button();
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.WhiteSmoke;
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(TextBox1);
            GroupBox1.ForeColor = Color.Maroon;
            GroupBox1.Location = new Point(114, 109);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(595, 155);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Currency Info.";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(84, 69);
            Label2.Name = "Label2";
            Label2.Size = new Size(64, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Currency:";
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox1.Location = new Point(159, 64);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(323, 24);
            TextBox1.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(34, 18);
            Label1.Name = "Label1";
            Label1.Size = new Size(134, 33);
            Label1.TabIndex = 1;
            Label1.Text = "Currency";
            // 
            // Button1
            // 
            Button1.Location = new Point(239, 319);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 2;
            Button1.Text = "New";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(460, 319);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 4;
            Button3.Text = "Update";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.Location = new Point(351, 319);
            Button4.Name = "Button4";
            Button4.Size = new Size(75, 23);
            Button4.TabIndex = 5;
            Button4.Text = "Delete";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Currency
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 590);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button1);
            Controls.Add(Label1);
            Controls.Add(GroupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Currency";
            Text = "Currency";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        internal GroupBox GroupBox1;
        internal Label Label2;
        internal TextBox TextBox1;
        internal Label Label1;
        internal Button Button1;
        internal Button Button3;
        internal Button Button4;
    }
}