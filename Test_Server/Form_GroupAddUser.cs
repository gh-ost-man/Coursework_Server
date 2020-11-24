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
    public partial class Form_GroupAddUser : Form
    {
        GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));

        int idUser = -1;
        int idGroup = -1;
        public Form_GroupAddUser()
        {
            InitializeComponent();
            FillComboBox(comboBox1);
            GetUsers();
        }
        private void FillComboBox(ComboBox combo)
        {
            IGenericRepository<Group> repGroup = work.Repository<Group>();

            var res = repGroup.GetAll().ToList();
            foreach (var item in res)
                combo.Items.Add(item.NameGroup);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;

            IGenericRepository<Group> repGroup = work.Repository<Group>();
            var res = repGroup.FindAll(x => x.NameGroup == comboBox1.SelectedItem.ToString()).Select(w => w.Users.Select(x => new
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Login = x.Login

            }).ToList()).FirstOrDefault();

            dataGridView_Groups.DataSource = null;
            dataGridView_Groups.DataSource = res;

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
                IsAdmin = x.IsAdmin
            }).ToList();

            dataGridView_Users.DataSource = null;
            dataGridView_Users.DataSource = users;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString()==string.Empty || dataGridView_Users.Rows.Count == 0) return;

            try
            {
                IGenericRepository<User> repUsers = work.Repository<User>();
                IGenericRepository<Group> repGroups = work.Repository<Group>();

                idUser = (int)dataGridView_Users.CurrentRow.Cells["Id"].Value;
                

                User user = repUsers.FindById(idUser);
                Group group = repGroups.FindAll(x => x.NameGroup == comboBox1.SelectedItem.ToString()).FirstOrDefault() ;

                if (group.Users.Where(x => x.Login == user.Login).FirstOrDefault() != null) throw new Exception("User is already in the group");

                group.Users.Add(user);

                work.SaveChanges();

                comboBox1_SelectedIndexChanged(sender, e);
            
           }
            catch (Exception ex) { MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);}
        }
    }
}
