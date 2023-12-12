using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EProject
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Customers : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.Txtcid = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtadr = new System.Windows.Forms.TextBox();
            this.txte = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.dtpcs = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtcid
            // 
            this.Txtcid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Txtcid.Location = new System.Drawing.Point(355, 93);
            this.Txtcid.Name = "Txtcid";
            this.Txtcid.Size = new System.Drawing.Size(149, 20);
            this.Txtcid.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.ForeColor = System.Drawing.Color.Maroon;
            this.Button1.Location = new System.Drawing.Point(255, 363);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Save";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(264, 96);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 14);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Customer ID:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(520, 97);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 14);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Name:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(290, 129);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 14);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Address:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(268, 163);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(78, 14);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Contact No.:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(528, 161);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(37, 14);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Date:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(301, 200);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(45, 14);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Email:";
            // 
            // txtn
            // 
            this.txtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtn.Location = new System.Drawing.Point(574, 93);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(149, 20);
            this.txtn.TabIndex = 10;
            // 
            // txtadr
            // 
            this.txtadr.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtadr.Location = new System.Drawing.Point(355, 125);
            this.txtadr.Name = "txtadr";
            this.txtadr.Size = new System.Drawing.Size(364, 20);
            this.txtadr.TabIndex = 11;
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(355, 196);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(294, 20);
            this.txte.TabIndex = 14;
            // 
            // Button2
            // 
            this.Button2.ForeColor = System.Drawing.Color.Maroon;
            this.Button2.Location = new System.Drawing.Point(589, 363);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 17;
            this.Button2.Text = "Delete";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.ForeColor = System.Drawing.Color.Maroon;
            this.Button3.Location = new System.Drawing.Point(474, 363);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 18;
            this.Button3.Text = "Update";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(387, 24);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(227, 39);
            this.Label8.TabIndex = 20;
            this.Label8.Text = "Customers Info.";
            // 
            // Button4
            // 
            this.Button4.ForeColor = System.Drawing.Color.Maroon;
            this.Button4.Location = new System.Drawing.Point(368, 363);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 23);
            this.Button4.TabIndex = 21;
            this.Button4.Text = "Search";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.ForeColor = System.Drawing.Color.Maroon;
            this.Button5.Location = new System.Drawing.Point(703, 363);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 23);
            this.Button5.TabIndex = 22;
            this.Button5.Text = "Back";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // txtcn
            // 
            this.txtcn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtcn.Location = new System.Drawing.Point(355, 159);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(149, 20);
            this.txtcn.TabIndex = 12;
            // 
            // dtpcs
            // 
            this.dtpcs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcs.Location = new System.Drawing.Point(574, 157);
            this.dtpcs.Name = "dtpcs";
            this.dtpcs.Size = new System.Drawing.Size(149, 20);
            this.dtpcs.TabIndex = 23;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(304, 238);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(42, 14);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Notes:";
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(355, 234);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnotes.Size = new System.Drawing.Size(294, 103);
            this.txtnotes.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 403);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 148);
            this.dataGridView1.TabIndex = 24;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpcs);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.txtcn);
            this.Controls.Add(this.txtadr);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Txtcid);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal TextBox Txtcid;
        internal Button Button1;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal TextBox txtn;
        internal TextBox txtadr;
        internal TextBox txte;
        internal Button Button2;
        internal Button Button3;
        internal Label Label8;
        internal Button Button4;
        internal Button Button5;
        internal TextBox txtcn;
        internal DateTimePicker dtpcs;
        internal Label Label7;
        internal TextBox txtnotes;
        private DataGridView dataGridView1;
    }
}