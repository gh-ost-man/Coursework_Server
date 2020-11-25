using DALServerDB;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestLib;

namespace Test_Server
{
    public partial class Form_LoadTest : Form
    {
        GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));

        OpenFileDialog open;
        XmlSerializer xs = new XmlSerializer(typeof(TestLib.Test), new XmlRootAttribute("Test"));

        TestLib.Test test;
        public Form_LoadTest()
        {
            InitializeComponent();
            btn_Save.Enabled = false;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            textBox_Author.Text = string.Empty;
            textBox_NameTest.Text = string.Empty;
            textBox_QtyQuestions.Text = string.Empty;
            numericUpDown_Hour.Value = 0;
            numericUpDown_Minute.Value = 0;
            test = null;
            btn_Save.Enabled = false;

        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "*.xml|*.xml";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(open.FileName, FileMode.OpenOrCreate))
                    {
                        test = (TestLib.Test)xs.Deserialize(fs);
                    }

                    textBox_Author.Text = test.Author;
                    textBox_NameTest.Text = test.TestName;
                    textBox_QtyQuestions.Text = test.Qty_questions.ToString();
                    btn_Save.Enabled = true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); btn_Cancel_Click(sender, e); }

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (test == null ) return;

            if(numericUpDown_Minute.Value == 0 && numericUpDown_Hour.Value == 0)
            {
                MessageBox.Show("Enter time for test");
                return;
            }
            IGenericRepository<DALServerDB.Test> rep = work.Repository<DALServerDB.Test>();

            if(rep.FindAll(x=>x.Title==test.TestName).FirstOrDefault()!=null)
            {
                MessageBox.Show("Test is exists");
                return;
            }

            SaveTestToServer(test);

            btn_Cancel_Click(sender, e);

        }

        private void SaveTestToServer(TestLib.Test _test)
        {
            IGenericRepository<DALServerDB.Test> rep = work.Repository<DALServerDB.Test>();

            DALServerDB.Test t = new DALServerDB.Test();
            t.Author = _test.Author;
            t.Title = _test.TestName;
            t.Time = new TimeSpan((int)numericUpDown_Hour.Value, (int)numericUpDown_Minute.Value, 0);

            List<DALServerDB.Question> questions = new List<DALServerDB.Question>();

            foreach (var item in _test.Question)
            {
                DALServerDB.Question question = new DALServerDB.Question();
                question.Title = item.Description;
                question.Difficulty = item.Difficulty;

                List<DALServerDB.Answer> answers = new List<DALServerDB.Answer>();
                foreach (var it in item.Answer)
                {
                    DALServerDB.Answer answer = new DALServerDB.Answer();
                    answer.Description = it.Description;
                    answer.IsRight = Convert.ToBoolean(it.IsRight);
                    answers.Add(answer);
                }
                question.Answers = answers;
                questions.Add(question);
            }

            t.Questions = questions;

            rep.Add(t);

            MessageBox.Show("Test added");

           
        }
    }
}
