namespace Test_Server
{
    partial class Form_AsignesTest
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
            this.dataGridView_GroupTests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView_Tests = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GroupTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GroupTests
            // 
            this.dataGridView_GroupTests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.dataGridView_GroupTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GroupTests.Location = new System.Drawing.Point(12, 33);
            this.dataGridView_GroupTests.Name = "dataGridView_GroupTests";
            this.dataGridView_GroupTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_GroupTests.Size = new System.Drawing.Size(738, 125);
            this.dataGridView_GroupTests.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView_Tests
            // 
            this.dataGridView_Tests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.dataGridView_Tests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tests.Location = new System.Drawing.Point(12, 177);
            this.dataGridView_Tests.Name = "dataGridView_Tests";
            this.dataGridView_Tests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Tests.Size = new System.Drawing.Size(738, 132);
            this.dataGridView_Tests.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tests";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(9, 315);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Form_AsignesTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(762, 367);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Tests);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_GroupTests);
            this.Name = "Form_AsignesTest";
            this.Text = "Form_AsignesTest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GroupTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GroupTests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView_Tests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
    }
}