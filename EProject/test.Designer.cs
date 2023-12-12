using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EProject
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class test : Form
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
            TextBox1 = new TextBox();
            DateTimePicker1 = new DateTimePicker();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(146, 33);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(100, 20);
            TextBox1.TabIndex = 0;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Format = DateTimePickerFormat.Short;
            DateTimePicker1.Location = new Point(295, 33);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(101, 20);
            DateTimePicker1.TabIndex = 1;
            // 
            // Button1
            // 
            Button1.Location = new Point(329, 126);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 2;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 412);
            Controls.Add(Button1);
            Controls.Add(DateTimePicker1);
            Controls.Add(TextBox1);
            Name = "test";
            Text = "test";
            ResumeLayout(false);
            PerformLayout();

        }
        internal TextBox TextBox1;
        internal DateTimePicker DateTimePicker1;
        internal Button Button1;
    }
}