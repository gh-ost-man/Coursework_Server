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
    public partial class Form_ShowData : Form
    {
        TypeEntity typeEntity = TypeEntity.Default;
        GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        int id = -1;
        public Form_ShowData()
        {
            InitializeComponent();
        }

        public Form_ShowData(TypeEntity type)
        {
            InitializeComponent();
            this.typeEntity = type;
            ShowData(type);
        }


        private void ShowData(TypeEntity type)
        {
            if (type == TypeEntity.Groups) GetGroups();
            if (type == TypeEntity.Users) GetUsers();
            if (type == TypeEntity.Tests) GetTests();
            if (type == TypeEntity.Results) GetResults();
        }

        private void GetGroups()
        {
            IGenericRepository<Group> repGroup = work.Repository<Group>();

            var groups = repGroup.GetAll().Select(x => new
            {
                Id = x.Id,
                Name = x.NameGroup,
                QtyOfUsers = x.Users.Count,
                QtyOfTests = x.Tests.Count

            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = groups;
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

        private void GetResults()
        {
            IGenericRepository<Result> rep = work.Repository<Result>();

            var res = rep.GetAll().ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = res;
        }

        private void GetTests()
        {
            IGenericRepository<Test> repTest = work.Repository<Test>();

            var tests = repTest.GetAll().Select(x => new
            {
                Id = x.Id,
                Auhtor = x.Author,
                Title = x.Title,
                Time = x.Time
            }).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tests;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;


            if (typeEntity == TypeEntity.Groups)
            {
                try
                {
                    IGenericRepository<Group> repGroups = work.Repository<Group>();
                    id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

                    var res = repGroups.FindById(id);

                    res.Users.Clear();

                    repGroups.Remove(res);

                    GetGroups();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            if (typeEntity == TypeEntity.Users)
            {
                try
                {
                    IGenericRepository<User> repUsers = work.Repository<User>();
                    id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

                    var res = repUsers.FindById(id);

                    repUsers.Remove(res);

                    GetUsers();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            if (typeEntity == TypeEntity.Tests)
            {
                try
                {
                    IGenericRepository<Test> repTest = work.Repository<Test>();
                    id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

                    var test = repTest.FindById(id);
                    test.Questions.Clear();
                    work.SaveChanges();

                    repTest.Remove(test);

                    GetTests();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }
    }
}
