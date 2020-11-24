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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));

            IGenericRepository<User> rep = work.Repository<User>();
            if(String.IsNullOrEmpty(textBox_Login.Text) || String.IsNullOrEmpty(textBox_Password.Text))
            {
                MessageBox.Show("Enter login and password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            User user = rep.FindAll(x => x.Login == textBox_Login.Text && x.Password == textBox_Password.Text).FirstOrDefault();

            if (user != null && user.IsAdmin)
            {
                Form_Main main = new Form_Main(user);
                this.Hide();
                main.ShowDialog();
                this.Dispose();
            }





        }
    }
}
