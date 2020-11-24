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
            //panel_S_SubMenu.Visible = false;
            //panel_SPJ_SubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panel_Users_SubMenu.Visible == true) panel_Users_SubMenu.Visible = false;
            if (panel_Groups_SubMenu.Visible == true) panel_Groups_SubMenu.Visible = false;
            //if (panel_S_SubMenu.Visible == true) panel_S_SubMenu.Visible = false;
            //if (panel_SPJ_SubMenu.Visible == true) panel_SPJ_SubMenu.Visible = false;
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
        }

        private void btn_Groups_Show_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Groups));
        }

        private void btn_Groups_Add_Click(object sender, EventArgs e)
        {
             openChildForm(new Form_Add_Update_Group(TypeOfCRUT.Add));
        }

        private void btn_Groups_Update_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_Group(TypeOfCRUT.Update));

        }

        private void btn_Users_Show_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Users));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Users_SubMenu);
        }

        private void btn_Users_Add_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_User(TypeOfCRUT.Add));
        }

        private void btn_Users_Update_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_User(TypeOfCRUT.Update));
        }

        private void btn_GroupShowUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GroupUsersShow());
        }

        private void btn_GroupAddUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GroupAddUser());
        }
    }
}
