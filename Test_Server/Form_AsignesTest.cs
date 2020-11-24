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
    public partial class Form_AsignesTest : Form
    {
        GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        int id = -1;
        public Form_AsignesTest()
        {
            InitializeComponent();
            FillComboBox(comboBox1);
            GetTests();
        }
        private void FillComboBox(ComboBox combo)
        {
            IGenericRepository<Group> repGroup = work.Repository<Group>();

            var res = repGroup.GetAll().ToList();
            foreach (var item in res)
                combo.Items.Add(item.NameGroup);
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
            dataGridView_Tests.DataSource = null;
            dataGridView_Tests.DataSource = tests;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;

            IGenericRepository<Group> repGroup = work.Repository<Group>();
            var res = repGroup.FindAll(x => x.NameGroup == comboBox1.SelectedItem.ToString()).Select(w => w.Tests.Select(x => new
            {
                Id = x.Id,
                Author = x.Author,
                Title = x.Title,
                Time = x.Time
            }).ToList()).FirstOrDefault();

            dataGridView_GroupTests.DataSource = null;
            dataGridView_GroupTests.DataSource = res;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || comboBox1.SelectedItem.ToString() == string.Empty ||dataGridView_Tests.Rows.Count==0) return;

            try
            {
                IGenericRepository<Group> repGroup = work.Repository<Group>();
                IGenericRepository<Test> repTest = work.Repository<Test>();

                Group res = repGroup.FindAll(x => x.NameGroup == comboBox1.SelectedItem.ToString()).FirstOrDefault();


                id = (int)dataGridView_Tests.CurrentRow.Cells["Id"].Value;
                Test test = repTest.FindById(id);

                var r = res.Tests.Where(x => x.Id == test.Id).FirstOrDefault();

                if (r != null) throw new Exception("The test is already in the group");

                res.Tests.Add(test);

                work.SaveChanges();

                comboBox1_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Warning);}
           

        }
    }
}
