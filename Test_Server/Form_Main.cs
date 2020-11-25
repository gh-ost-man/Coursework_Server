using DALServerDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Server
{
    public partial class Form_Main : Form
    {
        User admin;
        Form activeForm = null;

        public Form_Main()
        {
            InitializeComponent();
        }
        public Form_Main(User user)
        {
            InitializeComponent();
            admin = user;
            customizeDesign();

            label_UserName.Text = $"{admin.FirstName} {admin.LastName}";
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void customizeDesign()
        {
            panel_Groups_SubMenu.Visible = false;
            panel_Users_SubMenu.Visible = false;
            panel_Test_SubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panel_Users_SubMenu.Visible == true) panel_Users_SubMenu.Visible = false;
            if (panel_Groups_SubMenu.Visible == true) panel_Groups_SubMenu.Visible = false;
            if (panel_Test_SubMenu.Visible == true) panel_Test_SubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            panel_Main.BringToFront();
            childForm.Show();
        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Groups_SubMenu);
            label_Menu.Text = "Groups";
        }

        private void btn_Groups_Show_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Groups));
            label_Menu.Text = "Show all Groups";
        }

        private void btn_Groups_Add_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_Group(TypeOfCRUT.Add));
            label_Menu.Text = "Add new Group";
        }

        private void btn_Groups_Update_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_Group(TypeOfCRUT.Update));
            label_Menu.Text = "Update of Groups";

        }

        private void btn_Users_Show_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Users));
            label_Menu.Text = "Show all Users";
        }

        private void btn_Users_Add_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_User(TypeOfCRUT.Add));
        }

        private void btn_Users_Update_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_User(TypeOfCRUT.Update));
            label_Menu.Text = "Update Users";
        }

        private void btn_GroupShowUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GroupShowData(TypeEntity.Users));
            label_Menu.Text = "Show all users of group";
        }

        private void btn_GroupAddUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GroupAddUser());
            label_Menu.Text = "Add new user to group";
        }

        private void btn_Tests_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Test_SubMenu);
            label_Menu.Text = "Tests";
        }

        private void btn_LoadTest_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_LoadTest());
            label_Menu.Text = "Load Test";

        }

        private void btn_Tests_ShowAll_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Tests));
            label_Menu.Text = "Show all Tests";
        }

        private void btn_AsignesTest_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_AsignesTest());
            label_Menu.Text = "Asignes test to group";
        }

        private void btn_Test_ShowTestsGroups_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GroupShowData(TypeEntity.Tests));
            label_Menu.Text = "Show tests of group";
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Users_SubMenu);
            label_Menu.Text = "Users";
        }

        private void btn_Test_ShowResultTests_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Results));
            label_Menu.Text = "Results";
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {

        }
    }
}
