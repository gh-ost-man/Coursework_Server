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
            if (type == TypeEntity.Users) { }
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
            GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));

            IGenericRepository<User> repUsers = work.Repository<User>();

            var users = repUsers.GetAll().ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repUsers;
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
        }
    }
}
