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
            this.btn_Server = new System.Windows.Forms.Button();
            this.panel_Test_SubMenu = new System.Windows.Forms.Panel();
            this.btn_Test_ShowResultTests = new System.Windows.Forms.Button();
            this.btn_Test_ShowTestsGroups = new System.Windows.Forms.Button();
            this.btn_AsignesTest = new System.Windows.Forms.Button();
            this.btn_Tests_ShowAll = new System.Windows.Forms.Button();
            this.btn_LoadTest = new System.Windows.Forms.Button();
            this.btn_Tests = new System.Windows.Forms.Button();
            this.panel_Users_SubMenu = new System.Windows.Forms.Panel();
            this.btn_Users_Update = new System.Windows.Forms.Button();
            this.btn_Users_Add = new System.Windows.Forms.Button();
            this.btn_Users_Show = new System.Windows.Forms.Button();
            this.btn_Users = new System.Windows.Forms.Button();
            this.panel_Groups_SubMenu = new System.Windows.Forms.Panel();
            this.btn_GroupShowUsers = new System.Windows.Forms.Button();
            this.btn_GroupAddUser = new System.Windows.Forms.Button();
            this.btn_Groups_Update = new System.Windows.Forms.Button();
            this.btn_Groups_Add = new System.Windows.Forms.Button();
            this.btn_Groups_Show = new System.Windows.Forms.Button();
            this.btn_S = new System.Windows.Forms.Button();
            this.panel_Server = new System.Windows.Forms.Panel();
            this.label_UserName = new System.Windows.Forms.Label();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.label_Menu = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel_Test_SubMenu.SuspendLayout();
            this.panel_Users_SubMenu.SuspendLayout();
            this.panel_Groups_SubMenu.SuspendLayout();
            this.panel_Server.SuspendLayout();
            this.panel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.AutoScroll = true;
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.panel_Menu.Controls.Add(this.btn_Server);
            this.panel_Menu.Controls.Add(this.panel_Test_SubMenu);
            this.panel_Menu.Controls.Add(this.btn_Tests);
            this.panel_Menu.Controls.Add(this.panel_Users_SubMenu);
            this.panel_Menu.Controls.Add(this.btn_Users);
            this.panel_Menu.Controls.Add(this.panel_Groups_SubMenu);
            this.panel_Menu.Controls.Add(this.btn_S);
            this.panel_Menu.Controls.Add(this.panel_Server);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(179, 450);
            this.panel_Menu.TabIndex = 0;
            // 
            // btn_Server
            // 
            this.btn_Server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.btn_Server.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Server.FlatAppearance.BorderSize = 0;
            this.btn_Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Server.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Server.Location = new System.Drawing.Point(0, 514);
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Server.Size = new System.Drawing.Size(162, 33);
            this.btn_Server.TabIndex = 9;
            this.btn_Server.Text = "Server";
            this.btn_Server.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Server.UseVisualStyleBackColor = false;
            // 
            // panel_Test_SubMenu
            // 
            this.panel_Test_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel_Test_SubMenu.Controls.Add(this.btn_Test_ShowResultTests);
            this.panel_Test_SubMenu.Controls.Add(this.btn_Test_ShowTestsGroups);
            this.panel_Test_SubMenu.Controls.Add(this.btn_AsignesTest);
            this.panel_Test_SubMenu.Controls.Add(this.btn_Tests_ShowAll);
            this.panel_Test_SubMenu.Controls.Add(this.btn_LoadTest);
            this.panel_Test_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Test_SubMenu.Location = new System.Drawing.Point(0, 395);
            this.panel_Test_SubMenu.Name = "panel_Test_SubMenu";
            this.panel_Test_SubMenu.Size = new System.Drawing.Size(162, 119);
            this.panel_Test_SubMenu.TabIndex = 8;
            // 
            // btn_Test_ShowResultTests
            // 
            this.btn_Test_ShowResultTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Test_ShowResultTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Test_ShowResultTests.FlatAppearance.BorderSize = 0;
            this.btn_Test_ShowResultTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Test_ShowResultTests.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Test_ShowResultTests.Location = new System.Drawing.Point(0, 92);
            this.btn_Test_ShowResultTests.Name = "btn_Test_ShowResultTests";
            this.btn_Test_ShowResultTests.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Test_ShowResultTests.Size = new System.Drawing.Size(162, 23);
            this.btn_Test_ShowResultTests.TabIndex = 4;
            this.btn_Test_ShowResultTests.Text = "Show result tests";
            this.btn_Test_ShowResultTests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Test_ShowResultTests.UseVisualStyleBackColor = false;
            this.btn_Test_ShowResultTests.Click += new System.EventHandler(this.btn_Test_ShowResultTests_Click);
            // 
            // btn_Test_ShowTestsGroups
            // 
            this.btn_Test_ShowTestsGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Test_ShowTestsGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Test_ShowTestsGroups.FlatAppearance.BorderSize = 0;
            this.btn_Test_ShowTestsGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Test_ShowTestsGroups.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Test_ShowTestsGroups.Location = new System.Drawing.Point(0, 69);
            this.btn_Test_ShowTestsGroups.Name = "btn_Test_ShowTestsGroups";
            this.btn_Test_ShowTestsGroups.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Test_ShowTestsGroups.Size = new System.Drawing.Size(162, 23);
            this.btn_Test_ShowTestsGroups.TabIndex = 3;
            this.btn_Test_ShowTestsGroups.Text = "Show tests of groups";
            this.btn_Test_ShowTestsGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Test_ShowTestsGroups.UseVisualStyleBackColor = false;
            this.btn_Test_ShowTestsGroups.Click += new System.EventHandler(this.btn_Test_ShowTestsGroups_Click);
            // 
            // btn_AsignesTest
            // 
            this.btn_AsignesTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_AsignesTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AsignesTest.FlatAppearance.BorderSize = 0;
            this.btn_AsignesTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AsignesTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AsignesTest.Location = new System.Drawing.Point(0, 46);
            this.btn_AsignesTest.Name = "btn_AsignesTest";
            this.btn_AsignesTest.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_AsignesTest.Size = new System.Drawing.Size(162, 23);
            this.btn_AsignesTest.TabIndex = 2;
            this.btn_AsignesTest.Text = "Asignes Test";
            this.btn_AsignesTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AsignesTest.UseVisualStyleBackColor = false;
            this.btn_AsignesTest.Click += new System.EventHandler(this.btn_AsignesTest_Click);
            // 
            // btn_Tests_ShowAll
            // 
            this.btn_Tests_ShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Tests_ShowAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Tests_ShowAll.FlatAppearance.BorderSize = 0;
            this.btn_Tests_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tests_ShowAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Tests_ShowAll.Location = new System.Drawing.Point(0, 23);
            this.btn_Tests_ShowAll.Name = "btn_Tests_ShowAll";
            this.btn_Tests_ShowAll.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Tests_ShowAll.Size = new System.Drawing.Size(162, 23);
            this.btn_Tests_ShowAll.TabIndex = 1;
            this.btn_Tests_ShowAll.Text = "Show all";
            this.btn_Tests_ShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tests_ShowAll.UseVisualStyleBackColor = false;
            this.btn_Tests_ShowAll.Click += new System.EventHandler(this.btn_Tests_ShowAll_Click);
            // 
            // btn_LoadTest
            // 
            this.btn_LoadTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_LoadTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LoadTest.FlatAppearance.BorderSize = 0;
            this.btn_LoadTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_LoadTest.Location = new System.Drawing.Point(0, 0);
            this.btn_LoadTest.Name = "btn_LoadTest";
            this.btn_LoadTest.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_LoadTest.Size = new System.Drawing.Size(162, 23);
            this.btn_LoadTest.TabIndex = 0;
            this.btn_LoadTest.Text = "Load Test";
            this.btn_LoadTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoadTest.UseVisualStyleBackColor = false;
            this.btn_LoadTest.Click += new System.EventHandler(this.btn_LoadTest_Click);
            // 
            // btn_Tests
            // 
            this.btn_Tests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.btn_Tests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Tests.FlatAppearance.BorderSize = 0;
            this.btn_Tests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tests.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Tests.Location = new System.Drawing.Point(0, 362);
            this.btn_Tests.Name = "btn_Tests";
            this.btn_Tests.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Tests.Size = new System.Drawing.Size(162, 33);
            this.btn_Tests.TabIndex = 7;
            this.btn_Tests.Text = "Tests";
            this.btn_Tests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tests.UseVisualStyleBackColor = false;
            this.btn_Tests.Click += new System.EventHandler(this.btn_Tests_Click);
            // 
            // panel_Users_SubMenu
            // 
            this.panel_Users_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel_Users_SubMenu.Controls.Add(this.btn_Users_Update);
            this.panel_Users_SubMenu.Controls.Add(this.btn_Users_Add);
            this.panel_Users_SubMenu.Controls.Add(this.btn_Users_Show);
            this.panel_Users_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Users_SubMenu.Location = new System.Drawing.Point(0, 288);
            this.panel_Users_SubMenu.Name = "panel_Users_SubMenu";
            this.panel_Users_SubMenu.Size = new System.Drawing.Size(162, 74);
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
            this.btn_Users_Update.Size = new System.Drawing.Size(162, 23);
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
            this.btn_Users_Add.Size = new System.Drawing.Size(162, 23);
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
            this.btn_Users_Show.Size = new System.Drawing.Size(162, 23);
            this.btn_Users_Show.TabIndex = 0;
            this.btn_Users_Show.Text = "Show";
            this.btn_Users_Show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users_Show.UseVisualStyleBackColor = false;
            this.btn_Users_Show.Click += new System.EventHandler(this.btn_Users_Show_Click);
            // 
            // btn_Users
            // 
            this.btn_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.btn_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Users.FlatAppearance.BorderSize = 0;
            this.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Users.Location = new System.Drawing.Point(0, 255);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Users.Size = new System.Drawing.Size(162, 33);
            this.btn_Users.TabIndex = 5;
            this.btn_Users.Text = "Users";
            this.btn_Users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users.UseVisualStyleBackColor = false;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // panel_Groups_SubMenu
            // 
            this.panel_Groups_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel_Groups_SubMenu.Controls.Add(this.btn_GroupShowUsers);
            this.panel_Groups_SubMenu.Controls.Add(this.btn_GroupAddUser);
            this.panel_Groups_SubMenu.Controls.Add(this.btn_Groups_Update);
            this.panel_Groups_SubMenu.Controls.Add(this.btn_Groups_Add);
            this.panel_Groups_SubMenu.Controls.Add(this.btn_Groups_Show);
            this.panel_Groups_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Groups_SubMenu.Location = new System.Drawing.Point(0, 133);
            this.panel_Groups_SubMenu.Name = "panel_Groups_SubMenu";
            this.panel_Groups_SubMenu.Size = new System.Drawing.Size(162, 122);
            this.panel_Groups_SubMenu.TabIndex = 4;
            // 
            // btn_GroupShowUsers
            // 
            this.btn_GroupShowUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_GroupShowUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GroupShowUsers.FlatAppearance.BorderSize = 0;
            this.btn_GroupShowUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GroupShowUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_GroupShowUsers.Location = new System.Drawing.Point(0, 92);
            this.btn_GroupShowUsers.Name = "btn_GroupShowUsers";
            this.btn_GroupShowUsers.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_GroupShowUsers.Size = new System.Drawing.Size(162, 23);
            this.btn_GroupShowUsers.TabIndex = 4;
            this.btn_GroupShowUsers.Text = "Show Users";
            this.btn_GroupShowUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GroupShowUsers.UseVisualStyleBackColor = false;
            this.btn_GroupShowUsers.Click += new System.EventHandler(this.btn_GroupShowUsers_Click);
            // 
            // btn_GroupAddUser
            // 
            this.btn_GroupAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_GroupAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GroupAddUser.FlatAppearance.BorderSize = 0;
            this.btn_GroupAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GroupAddUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_GroupAddUser.Location = new System.Drawing.Point(0, 69);
            this.btn_GroupAddUser.Name = "btn_GroupAddUser";
            this.btn_GroupAddUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_GroupAddUser.Size = new System.Drawing.Size(162, 23);
            this.btn_GroupAddUser.TabIndex = 3;
            this.btn_GroupAddUser.Text = "Add user";
            this.btn_GroupAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GroupAddUser.UseVisualStyleBackColor = false;
            this.btn_GroupAddUser.Click += new System.EventHandler(this.btn_GroupAddUser_Click);
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
            this.btn_Groups_Update.Size = new System.Drawing.Size(162, 23);
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
            this.btn_Groups_Add.Size = new System.Drawing.Size(162, 23);
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
            this.btn_Groups_Show.Size = new System.Drawing.Size(162, 23);
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
            this.btn_S.Size = new System.Drawing.Size(162, 33);
            this.btn_S.TabIndex = 3;
            this.btn_S.Text = "Groups";
            this.btn_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_S.UseVisualStyleBackColor = false;
            this.btn_S.Click += new System.EventHandler(this.btn_S_Click);
            // 
            // panel_Server
            // 
            this.panel_Server.Controls.Add(this.label_UserName);
            this.panel_Server.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Server.Location = new System.Drawing.Point(0, 0);
            this.panel_Server.Name = "panel_Server";
            this.panel_Server.Size = new System.Drawing.Size(162, 100);
            this.panel_Server.TabIndex = 0;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.Color.Aqua;
            this.label_UserName.Location = new System.Drawing.Point(12, 33);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(116, 25);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "User name";
            // 
            // panel_Info
            // 
            this.panel_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_Info.Controls.Add(this.label_Menu);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Info.Location = new System.Drawing.Point(179, 0);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(778, 44);
            this.panel_Info.TabIndex = 1;
            // 
            // label_Menu
            // 
            this.label_Menu.AutoSize = true;
            this.label_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Menu.ForeColor = System.Drawing.Color.Aqua;
            this.label_Menu.Location = new System.Drawing.Point(6, 9);
            this.label_Menu.Name = "label_Menu";
            this.label_Menu.Size = new System.Drawing.Size(0, 25);
            this.label_Menu.TabIndex = 1;
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(179, 44);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(778, 406);
            this.panel_Main.TabIndex = 2;
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
            this.panel_Test_SubMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Panel panel_Groups_SubMenu;
        private System.Windows.Forms.Button btn_Groups_Update;
        private System.Windows.Forms.Button btn_Groups_Add;
        private System.Windows.Forms.Button btn_Groups_Show;
        private System.Windows.Forms.Button btn_S;
        private System.Windows.Forms.Panel panel_Server;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button btn_GroupShowUsers;
        private System.Windows.Forms.Button btn_GroupAddUser;
        private System.Windows.Forms.Panel panel_Test_SubMenu;
        private System.Windows.Forms.Button btn_Tests_ShowAll;
        private System.Windows.Forms.Button btn_LoadTest;
        private System.Windows.Forms.Button btn_Tests;
        private System.Windows.Forms.Button btn_AsignesTest;
        private System.Windows.Forms.Button btn_Test_ShowTestsGroups;
        private System.Windows.Forms.Label label_Menu;
        private System.Windows.Forms.Button btn_Test_ShowResultTests;
        private System.Windows.Forms.Button btn_Server;
    }
}