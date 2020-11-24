namespace Test_Server
{
    partial class Form_Add_Update_User
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.textBox_LName = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Confirm = new System.Windows.Forms.Label();
            this.textBox_Confirm = new System.Windows.Forms.TextBox();
            this.checkBox_IsAdmin = new System.Windows.Forms.CheckBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_OK);
            this.groupBox1.Controls.Add(this.checkBox_IsAdmin);
            this.groupBox1.Controls.Add(this.textBox_Confirm);
            this.groupBox1.Controls.Add(this.label_Confirm);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.textBox_Login);
            this.groupBox1.Controls.Add(this.textBox_LName);
            this.groupBox1.Controls.Add(this.textBox_FName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(416, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(103, 20);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(194, 20);
            this.textBox_FName.TabIndex = 5;
            // 
            // textBox_LName
            // 
            this.textBox_LName.Location = new System.Drawing.Point(103, 46);
            this.textBox_LName.Name = "textBox_LName";
            this.textBox_LName.Size = new System.Drawing.Size(194, 20);
            this.textBox_LName.TabIndex = 6;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(103, 72);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(194, 20);
            this.textBox_Login.TabIndex = 7;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(103, 98);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(194, 20);
            this.textBox_Password.TabIndex = 8;
            // 
            // label_Confirm
            // 
            this.label_Confirm.AutoSize = true;
            this.label_Confirm.Location = new System.Drawing.Point(7, 127);
            this.label_Confirm.Name = "label_Confirm";
            this.label_Confirm.Size = new System.Drawing.Size(90, 13);
            this.label_Confirm.TabIndex = 9;
            this.label_Confirm.Text = "Confirm password";
            // 
            // textBox_Confirm
            // 
            this.textBox_Confirm.Location = new System.Drawing.Point(103, 124);
            this.textBox_Confirm.Name = "textBox_Confirm";
            this.textBox_Confirm.Size = new System.Drawing.Size(194, 20);
            this.textBox_Confirm.TabIndex = 10;
            // 
            // checkBox_IsAdmin
            // 
            this.checkBox_IsAdmin.AutoSize = true;
            this.checkBox_IsAdmin.Location = new System.Drawing.Point(103, 151);
            this.checkBox_IsAdmin.Name = "checkBox_IsAdmin";
            this.checkBox_IsAdmin.Size = new System.Drawing.Size(55, 17);
            this.checkBox_IsAdmin.TabIndex = 11;
            this.checkBox_IsAdmin.Text = "Admin";
            this.checkBox_IsAdmin.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_OK.Location = new System.Drawing.Point(103, 187);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 12;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancel.Location = new System.Drawing.Point(222, 187);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form_Add_Update_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Add_Update_User";
            this.Text = "Form_Add_Update_User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.CheckBox checkBox_IsAdmin;
        private System.Windows.Forms.TextBox textBox_Confirm;
        private System.Windows.Forms.Label label_Confirm;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_LName;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}