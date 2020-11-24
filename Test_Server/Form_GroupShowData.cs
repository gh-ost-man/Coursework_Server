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
    public partial class Form_GroupShowData : Form
    {
        GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        TypeEntity typeEntity = TypeEntity.Default;
        int id = -1;
        public Form_GroupShowData()
        {
            InitializeComponent();
            FillComboBox(comboBox1);
        }

        public Form_GroupShowData(TypeEntity type)
        {
            InitializeComponent();

            this.typeEntity = type;
            FillComboBox(comboBox1);
        }

        private void FillComboBox(ComboBox combo)
        {
            IGenericRepository<Group> repGroup = work.Repository<Group>();

            var res = repGroup.GetAll().ToList();
            foreach (var item in res)
            {
                combo.Items.Add(item.NameGroup);
            }

        }
       
        private void GetUsersGroup(string groupName)
        {
            IGenericRepository<Group> repGroup = work.Repository<Group>();
            var res = repGroup.FindAll(x => x.NameGroup == groupName).Select(w => w.Users.Select(x => new
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Login = x.Login

            }).ToList()).FirstOrDefault();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = res;
        }

        private void GetTestsGroup(string groupName)
        {
            IGenericRepository<Group> repGroup = work.Repository<Group>();
            var res = repGroup.FindAll(x => x.NameGroup == groupName).Select(w => w.Tests.Select(x => new
            {
                Id = x.Id,
                Author = x.Author,
                Title = x.Title,
                Time = x.Time

            }).ToList()).FirstOrDefault();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = res;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 ||comboBox1.SelectedItem.ToString()==String.Empty) return;

            if (typeEntity == TypeEntity.Tests) GetTestsGroup(comboBox1.SelectedItem.ToString());
            if (typeEntity == TypeEntity.Users) GetUsersGroup(comboBox1.SelectedItem.ToString());

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0|| comboBox1.SelectedItem.ToString() == string.Empty) return;

            id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

            if (typeEntity==TypeEntity.Users)
            {
                IGenericRepository<User> rep = work.Repository<User>();
                IGenericRepository<Group> repGroup = work.Repository<Group>();


                var user = rep.FindById(id);

                repGroup.FindAll(x => x.NameGroup == comboBox1.SelectedItem.ToString()).FirstOrDefault().Users.Remove(user);

                work.SaveChanges();

                comboBox1_SelectedIndexChanged(sender, e);
            }

            if(typeEntity==TypeEntity.Tests)
            {
                IGenericRepository<Test> repTest = work.Repository<Test>();
                IGenericRepository<Group> repGroup = work.Repository<Group>();

                var test = repTest.FindById(id);

                repGroup.FindAll(x => x.NameGroup == comboBox1.SelectedItem.ToString()).FirstOrDefault().Tests.Remove(test);

                work.SaveChanges();

                comboBox1_SelectedIndexChanged(sender, e);
            }
       
        }
    }
}
