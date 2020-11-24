namespace Test_Server
{
    partial class Form_Main
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Users_SubMenu = new System.Windows.Forms.Panel();
            this.btn_Users_Update = new System.Windows.Forms.Button();
            this.btn_Users_Add = new System.Windows.Forms.Button();
            this.btn_Users_Show = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_Groups_SubMenu = new System.Windows.Forms.Panel();
            this.btn_Groups_Update = new System.Windows.Forms.Button();
            this.btn_Groups_Add = new System.Windows.Forms.Button();
            this.btn_Groups_Show = new System.Windows.Forms.Button();
            this.btn_S = new System.Windows.Forms.Button();
            this.panel_Server = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.label_UserName = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.panel_Users_SubMenu.SuspendLayout();
            this.panel_Groups_SubMenu.SuspendLayout();
            this.panel_Server.SuspendLayout();
            this.panel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.panel_Menu.Controls.Add(this.panel_Users_SubMenu);
            this.panel_Menu.Controls.Add(this.button5);
            this.panel_Menu.Controls.Add(this.panel_Groups_SubMenu);
            this.panel_Menu.Controls.Add(this.btn_S);
            this.panel_Menu.Controls.Add(this.panel_Server);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(179, 450);
            this.panel_Menu.TabIndex = 0;
            // 
            // panel_Users_SubMenu
            // 
            this.panel_Users_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel_Users_SubMenu.Controls.Add(this.btn_Users_Update);
            this.panel_Users_SubMenu.Controls.Add(this.btn_Users_Add);
            this.panel_Users_SubMenu.Controls.Add(this.btn_Users_Show);
            this.panel_Users_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Users_SubMenu.Location = new System.Drawing.Point(0, 294);
            this.panel_Users_SubMenu.Name = "panel_Users_SubMenu";
            this.panel_Users_SubMenu.Size = new System.Drawing.Size(179, 77);
            this.panel_Users_SubMenu.TabIndex = 6;
            // 
            // btn_Users_Update
            // 
            this.btn_Users_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Users_Update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Users_Update.FlatAppearance.BorderSize = 0;
            this.btn_Users_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Users_Update.Location = new System.Drawing.Point(0, 46);
            this.btn_Users_Update.Name = "btn_Users_Update";
            this.btn_Users_Update.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Users_Update.Size = new System.Drawing.Size(179, 23);
            this.btn_Users_Update.TabIndex = 2;
            this.btn_Users_Update.Text = "Update";
            this.btn_Users_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users_Update.UseVisualStyleBackColor = false;
            this.btn_Users_Update.Click += new System.EventHandler(this.btn_Users_Update_Click);
            // 
            // btn_Users_Add
            // 
            this.btn_Users_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Users_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Users_Add.FlatAppearance.BorderSize = 0;
            this.btn_Users_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Users_Add.Location = new System.Drawing.Point(0, 23);
            this.btn_Users_Add.Name = "btn_Users_Add";
            this.btn_Users_Add.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Users_Add.Size = new System.Drawing.Size(179, 23);
            this.btn_Users_Add.TabIndex = 1;
            this.btn_Users_Add.Text = "Add";
            this.btn_Users_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users_Add.UseVisualStyleBackColor = false;
            this.btn_Users_Add.Click += new System.EventHandler(this.btn_Users_Add_Click);
            // 
            // btn_Users_Show
            // 
            this.btn_Users_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Users_Show.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Users_Show.FlatAppearance.BorderSize = 0;
            this.btn_Users_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users_Show.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Users_Show.Location = new System.Drawing.Point(0, 0);
            this.btn_Users_Show.Name = "btn_Users_Show";
            this.btn_Users_Show.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Users_Show.Size = new System.Drawing.Size(179, 23);
            this.btn_Users_Show.TabIndex = 0;
            this.btn_Users_Show.Text = "Show";
            this.btn_Users_Show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users_Show.UseVisualStyleBackColor = false;
            this.btn_Users_Show.Click += new System.EventHandler(this.btn_Users_Show_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(0, 261);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(179, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Users";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel_Groups_SubMenu
            // 
            this.panel_Groups_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel_Groups_SubMenu.Controls.Add(this.button2);
            this.panel_Groups_SubMenu.Controls.Add(this.button1);
            this.panel_Groups_SubMenu.Controls.Add(this.btn_Groups_Update);
            this.panel_Groups_SubMenu.Controls.Add(this.btn_Groups_Add);
            this.panel_Groups_SubMenu.Controls.Add(this.btn_Groups_Show);
            this.panel_Groups_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Groups_SubMenu.Location = new System.Drawing.Point(0, 133);
            this.panel_Groups_SubMenu.Name = "panel_Groups_SubMenu";
            this.panel_Groups_SubMenu.Size = new System.Drawing.Size(179, 128);
            this.panel_Groups_SubMenu.TabIndex = 4;
            // 
            // btn_Groups_Update
            // 
            this.btn_Groups_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Groups_Update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Groups_Update.FlatAppearance.BorderSize = 0;
            this.btn_Groups_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Groups_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Groups_Update.Location = new System.Drawing.Point(0, 46);
            this.btn_Groups_Update.Name = "btn_Groups_Update";
            this.btn_Groups_Update.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Groups_Update.Size = new System.Drawing.Size(179, 23);
            this.btn_Groups_Update.TabIndex = 2;
            this.btn_Groups_Update.Text = "Update";
            this.btn_Groups_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Groups_Update.UseVisualStyleBackColor = false;
            this.btn_Groups_Update.Click += new System.EventHandler(this.btn_Groups_Update_Click);
            // 
            // btn_Groups_Add
            // 
            this.btn_Groups_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Groups_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Groups_Add.FlatAppearance.BorderSize = 0;
            this.btn_Groups_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Groups_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Groups_Add.Location = new System.Drawing.Point(0, 23);
            this.btn_Groups_Add.Name = "btn_Groups_Add";
            this.btn_Groups_Add.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Groups_Add.Size = new System.Drawing.Size(179, 23);
            this.btn_Groups_Add.TabIndex = 1;
            this.btn_Groups_Add.Text = "Add";
            this.btn_Groups_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Groups_Add.UseVisualStyleBackColor = false;
            this.btn_Groups_Add.Click += new System.EventHandler(this.btn_Groups_Add_Click);
            // 
            // btn_Groups_Show
            // 
            this.btn_Groups_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Groups_Show.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Groups_Show.FlatAppearance.BorderSize = 0;
            this.btn_Groups_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Groups_Show.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Groups_Show.Location = new System.Drawing.Point(0, 0);
            this.btn_Groups_Show.Name = "btn_Groups_Show";
            this.btn_Groups_Show.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Groups_Show.Size = new System.Drawing.Size(179, 23);
            this.btn_Groups_Show.TabIndex = 0;
            this.btn_Groups_Show.Text = "Show";
            this.btn_Groups_Show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Groups_Show.UseVisualStyleBackColor = false;
            this.btn_Groups_Show.Click += new System.EventHandler(this.btn_Groups_Show_Click);
            // 
            // btn_S
            // 
            this.btn_S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.btn_S.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_S.FlatAppearance.BorderSize = 0;
            this.btn_S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_S.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_S.Location = new System.Drawing.Point(0, 100);
            this.btn_S.Name = "btn_S";
            this.btn_S.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_S.Size = new System.Drawing.Size(179, 33);
            this.btn_S.TabIndex = 3;
            this.btn_S.Text = "Groups";
            this.btn_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_S.UseVisualStyleBackColor = false;
            this.btn_S.Click += new System.EventHandler(this.btn_S_Click);
            // 
            // panel_Server
            // 
            this.panel_Server.Controls.Add(this.label1);
            this.panel_Server.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Server.Location = new System.Drawing.Point(0, 0);
            this.panel_Server.Name = "panel_Server";
            this.panel_Server.Size = new System.Drawing.Size(179, 100);
            this.panel_Server.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // panel_Info
            // 
            this.panel_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_Info.Controls.Add(this.label_UserName);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Info.Location = new System.Drawing.Point(179, 0);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(778, 44);
            this.panel_Info.TabIndex = 1;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_UserName.Location = new System.Drawing.Point(6, 19);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(58, 13);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "User name";
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(179, 44);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(778, 406);
            this.panel_Main.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 69);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add user";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 92);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show Users";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_Menu);
            this.MinimumSize = new System.Drawing.Size(973, 489);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Users_SubMenu.ResumeLayout(false);
            this.panel_Groups_SubMenu.ResumeLayout(false);
            this.panel_Server.ResumeLayout(false);
            this.panel_Server.PerformLayout();
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Panel panel_Users_SubMenu;
        private System.Windows.Forms.Button btn_Users_Update;
        private System.Windows.Forms.Button btn_Users_Add;
        private System.Windows.Forms.Button btn_Users_Show;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel_Groups_SubMenu;
        private System.Windows.Forms.Button btn_Groups_Update;
        private System.Windows.Forms.Button btn_Groups_Add;
        private System.Windows.Forms.Button btn_Groups_Show;
        private System.Windows.Forms.Button btn_S;
        private System.Windows.Forms.Panel panel_Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}