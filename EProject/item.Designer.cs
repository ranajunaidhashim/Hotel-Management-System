using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EProject
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class item : Form
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
            GroupBox2 = new GroupBox();
            Label7 = new Label();
            cmbCategory = new ComboBox();
            Label6 = new Label();
            Label3 = new Label();
            txtRate = new TextBox();
            Label4 = new Label();
            txtDiscount = new TextBox();
            txtItemName = new TextBox();
            Label2 = new Label();
            DataGridView1 = new DataGridView();
            GroupBox1 = new GroupBox();
            txtSearchByDish = new TextBox();
            GroupBox3 = new GroupBox();
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Button4 = new Button();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Btn = new Button();
            Btn.Click += new EventHandler(Btn_Click);
            btnsave = new Button();
            btnsave.Click += new EventHandler(btnsave_Click);
            TextBox1 = new TextBox();
            Btnshow = new Button();
            Btnshow.Click += new EventHandler(Btnshow_Click);
            GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            GroupBox1.SuspendLayout();
            GroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(TextBox1);
            GroupBox2.Controls.Add(Label7);
            GroupBox2.Controls.Add(cmbCategory);
            GroupBox2.Controls.Add(Label6);
            GroupBox2.Controls.Add(Label3);
            GroupBox2.Controls.Add(txtRate);
            GroupBox2.Controls.Add(Label4);
            GroupBox2.Controls.Add(txtDiscount);
            GroupBox2.Controls.Add(txtItemName);
            GroupBox2.Controls.Add(Label2);
            GroupBox2.Location = new Point(24, 24);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(410, 171);
            GroupBox2.TabIndex = 1;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Item Details";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(21, 31);
            Label7.Name = "Label7";
            Label7.Size = new Size(47, 13);
            Label7.TabIndex = 304;
            Label7.Text = "Item ID :";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Drinks", "Fast Food" });
            cmbCategory.Location = new Point(112, 84);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(285, 21);
            cmbCategory.TabIndex = 2;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(21, 143);
            Label6.Name = "Label6";
            Label6.Size = new Size(66, 13);
            Label6.TabIndex = 10;
            Label6.Text = "Discount % :";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(21, 57);
            Label3.Name = "Label3";
            Label3.Size = new Size(64, 13);
            Label3.TabIndex = 0;
            Label3.Text = "Item Name :";
            // 
            // txtRate
            // 
            txtRate.BackColor = Color.White;
            txtRate.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRate.Location = new Point(112, 116);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(74, 21);
            txtRate.TabIndex = 5;
            txtRate.TextAlign = HorizontalAlignment.Right;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(21, 116);
            Label4.Name = "Label4";
            Label4.Size = new Size(36, 13);
            Label4.TabIndex = 6;
            Label4.Text = "Rate :";
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = Color.White;
            txtDiscount.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(112, 143);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(74, 21);
            txtDiscount.TabIndex = 6;
            txtDiscount.Text = "0.00";
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.White;
            txtItemName.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(112, 57);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(285, 21);
            txtItemName.TabIndex = 1;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(21, 84);
            Label2.Name = "Label2";
            Label2.Size = new Size(55, 13);
            Label2.TabIndex = 5;
            Label2.Text = "Category :";
            // 
            // DataGridView1
            // 
            DataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(24, 350);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(628, 150);
            DataGridView1.TabIndex = 2;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(txtSearchByDish);
            GroupBox1.Location = new Point(26, 201);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(202, 68);
            GroupBox1.TabIndex = 28;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Search By Item Name :";
            // 
            // txtSearchByDish
            // 
            txtSearchByDish.BackColor = Color.White;
            txtSearchByDish.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchByDish.Location = new Point(22, 29);
            txtSearchByDish.Name = "txtSearchByDish";
            txtSearchByDish.Size = new Size(172, 21);
            txtSearchByDish.TabIndex = 0;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(Button5);
            GroupBox3.Controls.Add(Button4);
            GroupBox3.Controls.Add(Button3);
            GroupBox3.Controls.Add(Btn);
            GroupBox3.Controls.Add(btnsave);
            GroupBox3.Location = new Point(26, 275);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(567, 52);
            GroupBox3.TabIndex = 29;
            GroupBox3.TabStop = false;
            // 
            // Button5
            // 
            Button5.ForeColor = Color.Maroon;
            Button5.Location = new Point(471, 15);
            Button5.Name = "Button5";
            Button5.Size = new Size(75, 23);
            Button5.TabIndex = 32;
            Button5.Text = "Back";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.ForeColor = Color.Maroon;
            Button4.Location = new Point(356, 15);
            Button4.Name = "Button4";
            Button4.Size = new Size(75, 23);
            Button4.TabIndex = 31;
            Button4.Text = "Search";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.ForeColor = Color.Maroon;
            Button3.Location = new Point(242, 15);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 30;
            Button3.Text = "Update";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Btn
            // 
            Btn.ForeColor = Color.Maroon;
            Btn.Location = new Point(131, 15);
            Btn.Name = "Btn";
            Btn.Size = new Size(75, 23);
            Btn.TabIndex = 29;
            Btn.Text = "Delete";
            Btn.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.ForeColor = Color.Maroon;
            btnsave.Location = new Point(23, 15);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 23);
            btnsave.TabIndex = 28;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(112, 28);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(100, 20);
            TextBox1.TabIndex = 30;
            // 
            // Btnshow
            // 
            Btnshow.ForeColor = Color.Maroon;
            Btnshow.Location = new Point(497, 246);
            Btnshow.Name = "Btnshow";
            Btnshow.Size = new Size(75, 23);
            Btnshow.TabIndex = 30;
            Btnshow.Text = "Show All";
            Btnshow.UseVisualStyleBackColor = true;
            // 
            // item
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 516);
            Controls.Add(Btnshow);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox1);
            Controls.Add(DataGridView1);
            Controls.Add(GroupBox2);
            Name = "item";
            Text = "item";
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox3.ResumeLayout(false);
            ResumeLayout(false);

        }
        internal GroupBox GroupBox2;
        internal Label Label7;
        internal ComboBox cmbCategory;
        internal Label Label6;
        internal Label Label3;
        internal TextBox txtRate;
        internal Label Label4;
        internal TextBox txtDiscount;
        internal TextBox txtItemName;
        internal Label Label2;
        internal DataGridView DataGridView1;
        internal GroupBox GroupBox1;
        internal TextBox txtSearchByDish;
        internal GroupBox GroupBox3;
        internal Button Button5;
        internal Button Button4;
        internal Button Button3;
        internal Button Btn;
        internal Button btnsave;
        internal TextBox TextBox1;
        internal Button Btnshow;
    }
}