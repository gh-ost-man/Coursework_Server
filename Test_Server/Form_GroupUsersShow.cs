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
    public partial class Form_GroupUsersShow : Form
    {
        GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));

        int id = -1;
        public Form_GroupUsersShow()
        {
            InitializeComponent();
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
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;
           
            IGenericRepository<Group> repGroup = work.Repository<Group>();
            var res = repGroup.FindAll(x => x.NameGroup == comboBox1.SelectedItem.ToString()).Select(w => w.Users.Select(x=>new 
            {
                Id=x.Id,
                FirstName=x.FirstName,
                LastName=x.LastName,
                Login=x.Login
            
            }).ToList()).FirstOrDefault();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = res;

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0|| comboBox1.SelectedItem.ToString() == string.Empty) return;

            id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
           
            IGenericRepository<User> rep = work.Repository<User>();
            IGenericRepository<Group> repGroup = work.Repository<Group>();


            var user = rep.FindById(id);

            repGroup.FindAll(x => x.NameGroup == comboBox1.SelectedItem.ToString()).FirstOrDefault().Users.Remove(user);

            work.SaveChanges();

            comboBox1_SelectedIndexChanged(sender, e);
        }
    }
}
