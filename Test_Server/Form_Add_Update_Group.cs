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
    public partial class Form_Add_Update_Group : Form
    {
        TypeOfCRUT crut = TypeOfCRUT.Default;
        GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        int id = -1;
        int index = -1;
        public Form_Add_Update_Group()
        {
            InitializeComponent();
        }
        public Form_Add_Update_Group(TypeOfCRUT type)
        {
            InitializeComponent();

            this.crut = type;

            GetGroups();
        }
        private bool Check_Group(Group group, TypeOfCRUT type)
        {
            IGenericRepository<Group> rep = work.Repository<Group>();

            if (type == TypeOfCRUT.Add)
            {
                var res = rep.FindAll(x => x.NameGroup == group.NameGroup).FirstOrDefault();
                if (res != null) return true;
            }

            if (type == TypeOfCRUT.Update)
            {
                var res = rep.FindAll(x => x.NameGroup == group.NameGroup).ToList();

                if (res.Count() >= 1) return true;
            }

            return false;
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (crut == TypeOfCRUT.Update)
            {
                try
                {
                    id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    textBox_Name.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = string.Empty;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Name.Text)) return;
            IGenericRepository<Group> rep = work.Repository<Group>();


            if (crut == TypeOfCRUT.Add)
            {
                try
                {
                    Group group = new Group();
                    group.NameGroup = textBox_Name.Text;

                    if (Check_Group(group, crut)) throw new Exception($"< {group.NameGroup} > is exists");

                    rep.Add(group);

                    GetGroups();

                    btn_Cancel_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            if (crut == TypeOfCRUT.Update)
            {
                try
                {
                    Group group = rep.FindById(id);
                    if (group.NameGroup == textBox_Name.Text) return;

                    group.NameGroup = textBox_Name.Text;


                    if (Check_Group(group, crut)) throw new Exception($"< {group.NameGroup} > is exists");
                    rep.Update(group);

                    GetGroups();

                    btn_Cancel_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            }
        }
    }
}
