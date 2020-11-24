namespace Test_Server
{
    partial class Form_LoadTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.numericUpDown_Minute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Hour = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_QtyQuestions = new System.Windows.Forms.TextBox();
            this.textBox_NameTest = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labe_QtyQuestions = new System.Windows.Forms.Label();
            this.label_NameTest = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.btn_File = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.numericUpDown_Minute);
            this.groupBox1.Controls.Add(this.numericUpDown_Hour);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_QtyQuestions);
            this.groupBox1.Controls.Add(this.textBox_NameTest);
            this.groupBox1.Controls.Add(this.textBox_Author);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labe_QtyQuestions);
            this.groupBox1.Controls.Add(this.label_NameTest);
            this.groupBox1.Controls.Add(this.label_Author);
            this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Cancel.Location = new System.Drawing.Point(220, 170);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Save.Location = new System.Drawing.Point(95, 170);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // numericUpDown_Minute
            // 
            this.numericUpDown_Minute.Location = new System.Drawing.Point(208, 124);
            this.numericUpDown_Minute.Name = "numericUpDown_Minute";
            this.numericUpDown_Minute.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_Minute.TabIndex = 10;
            // 
            // numericUpDown_Hour
            // 
            this.numericUpDown_Hour.Location = new System.Drawing.Point(95, 124);
            this.numericUpDown_Hour.Name = "numericUpDown_Hour";
            this.numericUpDown_Hour.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_Hour.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Minute";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hour";
            // 
            // textBox_QtyQuestions
            // 
            this.textBox_QtyQuestions.Location = new System.Drawing.Point(95, 77);
            this.textBox_QtyQuestions.Name = "textBox_QtyQuestions";
            this.textBox_QtyQuestions.ReadOnly = true;
            this.textBox_QtyQuestions.Size = new System.Drawing.Size(65, 20);
            this.textBox_QtyQuestions.TabIndex = 6;
            // 
            // textBox_NameTest
            // 
            this.textBox_NameTest.Location = new System.Drawing.Point(95, 51);
            this.textBox_NameTest.Name = "textBox_NameTest";
            this.textBox_NameTest.ReadOnly = true;
            this.textBox_NameTest.Size = new System.Drawing.Size(200, 20);
            this.textBox_NameTest.TabIndex = 5;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(95, 25);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.ReadOnly = true;
            this.textBox_Author.Size = new System.Drawing.Size(200, 20);
            this.textBox_Author.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // labe_QtyQuestions
            // 
            this.labe_QtyQuestions.AutoSize = true;
            this.labe_QtyQuestions.Location = new System.Drawing.Point(6, 80);
            this.labe_QtyQuestions.Name = "labe_QtyQuestions";
            this.labe_QtyQuestions.Size = new System.Drawing.Size(83, 13);
            this.labe_QtyQuestions.TabIndex = 2;
            this.labe_QtyQuestions.Text = "Qty of questions";
            // 
            // label_NameTest
            // 
            this.label_NameTest.AutoSize = true;
            this.label_NameTest.Location = new System.Drawing.Point(6, 54);
            this.label_NameTest.Name = "label_NameTest";
            this.label_NameTest.Size = new System.Drawing.Size(71, 13);
            this.label_NameTest.TabIndex = 1;
            this.label_NameTest.Text = "Name of Test";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(6, 28);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(38, 13);
            this.label_Author.TabIndex = 0;
            this.label_Author.Text = "Author";
            // 
            // btn_File
            // 
            this.btn_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_File.ForeColor = System.Drawing.Color.Aqua;
            this.btn_File.Location = new System.Drawing.Point(12, 12);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(75, 23);
            this.btn_File.TabIndex = 1;
            this.btn_File.Text = "File";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // Form_LoadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(762, 367);
            this.Controls.Add(this.btn_File);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_LoadTest";
            this.Text = "Form_LoadTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.NumericUpDown numericUpDown_Minute;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_QtyQuestions;
        private System.Windows.Forms.TextBox textBox_NameTest;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labe_QtyQuestions;
        private System.Windows.Forms.Label label_NameTest;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Button btn_File;
    }
}