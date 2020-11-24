using DALServerDB;
using Repository;
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
    public partial class Form_Add_Update_User : Form
    {
        TypeOfCRUT crut = TypeOfCRUT.Default;
        GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        int id = -1;
        public Form_Add_Update_User()
        {
            InitializeComponent();
        }

        public Form_Add_Update_User(TypeOfCRUT type)
        {
            InitializeComponent();
            
            crut = type;

            GetUsers();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            textBox_FName.Text = string.Empty;
            textBox_LName.Text = string.Empty;
            textBox_Login.Text = string.Empty;
            textBox_Password.Text = string.Empty;
            textBox_Confirm.Text = string.Empty;
            checkBox_IsAdmin.Checked = false;
        }

        private void GetUsers()
        {
            IGenericRepository<User> repUsers = work.Repository<User>();

            var users = repUsers.GetAll().Select(x => new
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Login = x.Login,
                Password = x.Password,
                IsAdmin = x.IsAdmin
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_FName.Text) || String.IsNullOrEmpty(textBox_LName.Text) || String.IsNullOrEmpty(textBox_Login.Text) ||
                String.IsNullOrEmpty(textBox_Password.Text) || String.IsNullOrEmpty(textBox_Confirm.Text))
            {
                MessageBox.Show("Fill all fields","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            IGenericRepository<User> rep = work.Repository<User>();

            if(crut==TypeOfCRUT.Add)
            {
                try
                {
                    User user = new User();
                    user.FirstName = textBox_FName.Text;
                    user.LastName = textBox_LName.Text;
                    user.Login = textBox_Login.Text;
                    user.Password = textBox_Password.Text;
                    user.IsAdmin = checkBox_IsAdmin.Checked;



                    if (textBox_Password.Text != textBox_Confirm.Text) throw new Exception("Password do not match");

                    if (Check_Login(user, crut)) throw new Exception($"< {user.Login} is exists>");

                    rep.Add(user);

                    GetUsers();
                    btn_Cancel_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            if(crut==TypeOfCRUT.Update)
            {
                try
                {
                    User user = rep.FindById(id);
                    user.FirstName = textBox_FName.Text;
                    user.LastName = textBox_LName.Text;
                    user.Login = textBox_Login.Text;
                    user.Password = textBox_Password.Text;
                    user.IsAdmin = checkBox_IsAdmin.Checked;

                    if (textBox_Password.Text != textBox_Confirm.Text) throw new Exception("Password do not match");

                    if (Check_Login(user, crut)) throw new Exception($"< {user.Login} is exists>");

                    rep.Update(user);

                    GetUsers();
                    btn_Cancel_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }

        private bool Check_Login(User user,TypeOfCRUT type)
        {
            IGenericRepository<User> rep = work.Repository<User>();

            if (type == TypeOfCRUT.Add)
            {
                var res = rep.FindAll(x => x.Login == user.Login).FirstOrDefault();
                if (res != null) return true;
            }
            if (type == TypeOfCRUT.Update)
            {
                var res = rep.FindAll(x => x.Login == user.Login).ToList();
                if (res.Count > 1) return true;
            }

            return false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(crut==TypeOfCRUT.Update)
            {
                try
                {
                    id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    textBox_FName.Text= dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                    textBox_LName.Text= dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                    textBox_Login.Text= dataGridView1.CurrentRow.Cells["Login"].Value.ToString();
                    textBox_Password.Text= dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
                    checkBox_IsAdmin.Checked = (bool)dataGridView1.CurrentRow.Cells["IsAdmin"].Value;
                }
                catch { }
            }
          
        }
    }
}
