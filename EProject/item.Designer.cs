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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchByDish = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Btn = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.Btnshow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TextBox1);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.cmbCategory);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.txtRate);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.txtDiscount);
            this.GroupBox2.Controls.Add(this.txtItemName);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Location = new System.Drawing.Point(171, 55);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(410, 171);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Item Details";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(112, 28);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 30;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(21, 31);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(47, 13);
            this.Label7.TabIndex = 304;
            this.Label7.Text = "Item ID :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Drinks",
            "Fast Food"});
            this.cmbCategory.Location = new System.Drawing.Point(112, 84);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(285, 21);
            this.cmbCategory.TabIndex = 2;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(21, 143);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(66, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Discount % :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(21, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Item Name :";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.White;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(112, 116);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(74, 21);
            this.txtRate.TabIndex = 5;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(21, 116);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(36, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Rate :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(112, 143);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(74, 21);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.Text = "0.00";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(112, 57);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(285, 21);
            this.txtItemName.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Category :";
            // 
            // dgvItems
            // 
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(171, 385);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(628, 150);
            this.dgvItems.TabIndex = 2;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtSearchByDish);
            this.GroupBox1.Controls.Add(this.Button4);
            this.GroupBox1.Location = new System.Drawing.Point(173, 232);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(408, 85);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search By Item Name :";
            // 
            // txtSearchByDish
            // 
            this.txtSearchByDish.BackColor = System.Drawing.Color.White;
            this.txtSearchByDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByDish.Location = new System.Drawing.Point(110, 19);
            this.txtSearchByDish.Name = "txtSearchByDish";
            this.txtSearchByDish.Size = new System.Drawing.Size(285, 21);
            this.txtSearchByDish.TabIndex = 0;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Btnshow);
            this.GroupBox3.Controls.Add(this.Button5);
            this.GroupBox3.Controls.Add(this.Button3);
            this.GroupBox3.Controls.Add(this.Btn);
            this.GroupBox3.Controls.Add(this.btnsave);
            this.GroupBox3.Location = new System.Drawing.Point(171, 323);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(567, 52);
            this.GroupBox3.TabIndex = 29;
            this.GroupBox3.TabStop = false;
            // 
            // Button5
            // 
            this.Button5.ForeColor = System.Drawing.Color.Maroon;
            this.Button5.Location = new System.Drawing.Point(471, 15);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 23);
            this.Button5.TabIndex = 32;
            this.Button5.Text = "Back";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.ForeColor = System.Drawing.Color.Maroon;
            this.Button4.Location = new System.Drawing.Point(109, 46);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 21);
            this.Button4.TabIndex = 31;
            this.Button4.Text = "Search";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.ForeColor = System.Drawing.Color.Maroon;
            this.Button3.Location = new System.Drawing.Point(243, 15);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 30;
            this.Button3.Text = "Update";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Btn
            // 
            this.Btn.ForeColor = System.Drawing.Color.Maroon;
            this.Btn.Location = new System.Drawing.Point(131, 15);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(75, 23);
            this.Btn.TabIndex = 29;
            this.Btn.Text = "Delete";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.Maroon;
            this.btnsave.Location = new System.Drawing.Point(23, 15);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 28;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Btnshow
            // 
            this.Btnshow.ForeColor = System.Drawing.Color.Maroon;
            this.Btnshow.Location = new System.Drawing.Point(359, 15);
            this.Btnshow.Name = "Btnshow";
            this.Btnshow.Size = new System.Drawing.Size(75, 23);
            this.Btnshow.TabIndex = 30;
            this.Btnshow.Text = "Show All";
            this.Btnshow.UseVisualStyleBackColor = true;
            this.Btnshow.Click += new System.EventHandler(this.Btnshow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 30;
            this.label1.Text = "Items Details";
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.GroupBox2);
            this.Name = "item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "item";
            this.Load += new System.EventHandler(this.item_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        internal DataGridView dgvItems;
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
        private Label label1;
    }
}