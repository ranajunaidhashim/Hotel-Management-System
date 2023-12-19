namespace EProject
{
    partial class UsersRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUR = new System.Windows.Forms.DataGridView();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.txtcmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpas = new System.Windows.Forms.TextBox();
            this.txtun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button5 = new System.Windows.Forms.Button();
            this.Btn = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUR)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users Record";
            // 
            // dgvUR
            // 
            this.dgvUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUR.Location = new System.Drawing.Point(177, 319);
            this.dgvUR.Name = "dgvUR";
            this.dgvUR.Size = new System.Drawing.Size(527, 156);
            this.dgvUR.TabIndex = 1;
            this.dgvUR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUR_CellContentClick);
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox3.Controls.Add(this.txtID);
            this.GroupBox3.Controls.Add(this.label6);
            this.GroupBox3.Controls.Add(this.Button3);
            this.GroupBox3.Controls.Add(this.txtcmb);
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Controls.Add(this.label3);
            this.GroupBox3.Controls.Add(this.txtpas);
            this.GroupBox3.Controls.Add(this.txtun);
            this.GroupBox3.Controls.Add(this.label2);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(114, 75);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(331, 227);
            this.GroupBox3.TabIndex = 31;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "To Update Record";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(117, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(166, 22);
            this.txtID.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(50, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "User ID:";
            // 
            // Button3
            // 
            this.Button3.ForeColor = System.Drawing.Color.Maroon;
            this.Button3.Location = new System.Drawing.Point(117, 178);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 30);
            this.Button3.TabIndex = 30;
            this.Button3.Text = "Update";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtcmb
            // 
            this.txtcmb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmb.FormattingEnabled = true;
            this.txtcmb.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.txtcmb.Location = new System.Drawing.Point(117, 140);
            this.txtcmb.Name = "txtcmb";
            this.txtcmb.Size = new System.Drawing.Size(166, 23);
            this.txtcmb.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(33, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "UserType:";
            // 
            // txtpas
            // 
            this.txtpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpas.Location = new System.Drawing.Point(117, 101);
            this.txtpas.Name = "txtpas";
            this.txtpas.Size = new System.Drawing.Size(166, 22);
            this.txtpas.TabIndex = 34;
            this.txtpas.UseSystemPasswordChar = true;
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(117, 66);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(166, 22);
            this.txtun.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Username:";
            // 
            // Button5
            // 
            this.Button5.ForeColor = System.Drawing.Color.Maroon;
            this.Button5.Location = new System.Drawing.Point(629, 272);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 30);
            this.Button5.TabIndex = 32;
            this.Button5.Text = "Back";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Btn
            // 
            this.Btn.ForeColor = System.Drawing.Color.Maroon;
            this.Btn.Location = new System.Drawing.Point(217, 66);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(75, 29);
            this.Btn.TabIndex = 29;
            this.Btn.Text = "Delete";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtsun);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.Button4);
            this.GroupBox1.Controls.Add(this.Btn);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(484, 75);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(332, 122);
            this.GroupBox1.TabIndex = 30;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search By Username :";
            // 
            // txtsun
            // 
            this.txtsun.Location = new System.Drawing.Point(116, 30);
            this.txtsun.Name = "txtsun";
            this.txtsun.Size = new System.Drawing.Size(176, 22);
            this.txtsun.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(29, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Username:";
            // 
            // Button4
            // 
            this.Button4.ForeColor = System.Drawing.Color.Maroon;
            this.Button4.Location = new System.Drawing.Point(116, 65);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 29);
            this.Button4.TabIndex = 31;
            this.Button4.Text = "Search";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // UsersRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 487);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dgvUR);
            this.Controls.Add(this.label1);
            this.Name = "UsersRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Record";
            this.Load += new System.EventHandler(this.UsersRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUR)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUR;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Btn;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button4;
        private System.Windows.Forms.ComboBox txtcmb;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtun;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtpas;
        internal System.Windows.Forms.TextBox txtsun;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label label6;
    }
}