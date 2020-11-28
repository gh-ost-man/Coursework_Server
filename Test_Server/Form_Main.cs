using DALServerDB;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Server
{
    //33101 - load tests

    public partial class Form_Main : Form
    {
        User admin;

        Form activeForm = null;
        GenericUnitOfWork work = new GenericUnitOfWork(new ServerContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));

        int portSend = 5555;
        int portRecive = 5556;


        int portSendTest = 5558;
        int portReciveTest = 5557;

        int portSendRes = 5560;
        int portReciveRes = 5559;


        public Form_Main()
        {
            InitializeComponent();
        }
        public Form_Main(User user)
        {
            InitializeComponent();
            admin = user;
            customizeDesign();

            IGenericRepository<User> rep = work.Repository<User>();
            IGenericRepository<Test> repTest = work.Repository<Test>();
            
            IGenericRepository<Answer> repAnswer = work.Repository<Answer>();
            IGenericRepository<UserAnswer> repUserAnswer = work.Repository<UserAnswer>();



            TcpClient clientTcp = null;
            NetworkStream streamSend;

            label_UserName.Text = $"{admin.FirstName} {admin.LastName}";

            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener server = new TcpListener(localAddr, portRecive);
            server.Start();

            TcpListener server2 = new TcpListener(localAddr, portReciveTest);
            server2.Start();

            TcpListener server3 = new TcpListener(localAddr, portReciveRes);
            server3.Start();



            //Users
            Task.Run(() =>
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    byte[] buff = new byte[1024];
                    MemoryStream ms = new MemoryStream();

                    do
                    {
                        int bytes = stream.Read(buff, 0, buff.Length);

                        ms.Append(buff);
                    }
                    while (stream.DataAvailable);

                    BinaryFormatter bf = new BinaryFormatter();

                    ms.Position = 0;
                    TreeGedaLib.User user1 = (TreeGedaLib.User)bf.Deserialize(ms);
                    ms.Close();

                    var ures = rep.FindAll(x => x.Login == user1.Login && x.Password == user1.Password).FirstOrDefault();

                    if (ures != null)
                    {
                        user1.Id = ures.Id;
                        user1.FirstName = ures.FirstName;
                        user1.LastName = ures.LastName;
                        user1.Login = ures.Login;
                        user1.Password = ures.Password;
                        user1.IsAdmin = ures.IsAdmin;


                        byte[] data;

                        using (ms = new MemoryStream())
                        {
                            var binForm = new BinaryFormatter();
                            binForm.Serialize(ms, user1);

                            data = ms.ToArray();
                        }
                        clientTcp = new TcpClient();
                        clientTcp.Connect("localhost", portSend);
                        streamSend = clientTcp.GetStream();

                        streamSend.Write(data, 0, data.Length);
                        ms.Close();
                    }
                    else
                    {

                        user1.Id = -1;
                        byte[] data;

                        using (ms = new MemoryStream())
                        {
                            var binForm = new BinaryFormatter();
                            binForm.Serialize(ms, user1);

                            data = ms.ToArray();
                        }
                        clientTcp = new TcpClient();
                        clientTcp.Connect("localhost", portSend);
                        streamSend = clientTcp.GetStream();

                        streamSend.Write(data, 0, data.Length);
                        ms.Close();
                    }
                }
            });


            //Tests
            Task.Run(() =>
            {
                while (true)
                {
                    TcpClient client = server2.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    byte[] buff = new byte[1024];
                    MemoryStream ms = new MemoryStream();

                    do
                    {
                        int bytes = stream.Read(buff, 0, buff.Length);

                        ms.Append(buff);
                    }
                    while (stream.DataAvailable);

                    BinaryFormatter bf = new BinaryFormatter();

                    ms.Position = 0;
                    TreeGedaLib.User user1 = (TreeGedaLib.User)bf.Deserialize(ms);
                    ms.Close();


                    if (user1 != null)
                    {
                        var groups = rep.FindById(user1.Id).Groups.ToList();

                        var tests = groups.Select(x => x.Tests.ToList()).FirstOrDefault();

                        if (tests.Count() > 0)
                        {
                            List<TreeGedaLib.Test> testsSend = new List<TreeGedaLib.Test>();

                            foreach (var test in tests)
                            {
                                TreeGedaLib.Test t = new TreeGedaLib.Test();
                                t.Id = test.Id;
                                t.Author = test.Author;
                                t.Time = test.Time;
                                t.Title = test.Title;

                                foreach (var question in test.Questions)
                                {
                                    TreeGedaLib.Question q = new TreeGedaLib.Question();
                                    q.Id = question.Id;
                                    q.Title = question.Title;
                                    q.Difficulty = question.Difficulty;

                                    foreach (var answer in question.Answers)
                                    {
                                        TreeGedaLib.Answer a = new TreeGedaLib.Answer();
                                        a.Id = answer.Id;
                                        a.Description = answer.Description;
                                        a.IsRight = answer.IsRight;
                                        q.Answers.Add(a);
                                    }
                                    t.Questions.Add(q);
                                }
                                testsSend.Add(t);
                            }

                            byte[] data;

                            using (ms = new MemoryStream())
                            {
                                var binForm = new BinaryFormatter();
                                binForm.Serialize(ms, testsSend);

                                data = ms.ToArray();
                            }

                            clientTcp = new TcpClient();
                            clientTcp.Connect("localhost", portSendTest);
                            streamSend = clientTcp.GetStream();

                            streamSend.Write(data, 0, data.Length);
                            ms.Close();
                            user1 = null;
                        }
                    }
                }
            });

            //Result

            Task.Run(() =>
            {
                while (true)
                {
                    TcpClient client = server3.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    byte[] buff = new byte[1024];
                    MemoryStream ms = new MemoryStream();

                    do
                    {
                        int bytes = stream.Read(buff, 0, buff.Length);

                        ms.Append(buff);
                    }
                    while (stream.DataAvailable);

                    BinaryFormatter bf = new BinaryFormatter();

                    ms.Position = 0;
                    List<TreeGedaLib.UserAnswer> userAnswer = (List<TreeGedaLib.UserAnswer>)bf.Deserialize(ms);
                    ms.Close();

                    if (userAnswer.Count != 0)
                    {
                        foreach (var item in userAnswer)
                        {
                            UserAnswer ua = new UserAnswer();

                            Answer answer = repAnswer.FindById(item.Answer.Id);
                            User us = rep.FindById(item.User.Id);

                            ua.Date = item.Date;
                            ua.Answer = answer;
                            ua.User = us;

                            repUserAnswer.Add(ua);
                        }
                    }
                }
            });

        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void customizeDesign()
        {
            panel_Groups_SubMenu.Visible = false;
            panel_Users_SubMenu.Visible = false;
            panel_Test_SubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panel_Users_SubMenu.Visible == true) panel_Users_SubMenu.Visible = false;
            if (panel_Groups_SubMenu.Visible == true) panel_Groups_SubMenu.Visible = false;
            if (panel_Test_SubMenu.Visible == true) panel_Test_SubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            panel_Main.BringToFront();
            childForm.Show();
        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Groups_SubMenu);
            label_Menu.Text = "Groups";
        }

        private void btn_Groups_Show_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Groups));
            label_Menu.Text = "Show all Groups";
        }

        private void btn_Groups_Add_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_Group(TypeOfCRUT.Add));
            label_Menu.Text = "Add new Group";
        }

        private void btn_Groups_Update_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_Group(TypeOfCRUT.Update));
            label_Menu.Text = "Update of Groups";

        }

        private void btn_Users_Show_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Users));
            label_Menu.Text = "Show all Users";
        }

        private void btn_Users_Add_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_User(TypeOfCRUT.Add));
        }

        private void btn_Users_Update_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Add_Update_User(TypeOfCRUT.Update));
            label_Menu.Text = "Update Users";
        }

        private void btn_GroupShowUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GroupShowData(TypeEntity.Users));
            label_Menu.Text = "Show all users of group";
        }

        private void btn_GroupAddUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GroupAddUser());
            label_Menu.Text = "Add new user to group";
        }

        private void btn_Tests_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Test_SubMenu);
            label_Menu.Text = "Tests";
        }

        private void btn_LoadTest_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_LoadTest());
            label_Menu.Text = "Load Test";

        }

        private void btn_Tests_ShowAll_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Tests));
            label_Menu.Text = "Show all Tests";
        }

        private void btn_AsignesTest_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_AsignesTest());
            label_Menu.Text = "Asignes test to group";
        }

        private void btn_Test_ShowTestsGroups_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_GroupShowData(TypeEntity.Tests));
            label_Menu.Text = "Show tests of group";
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Users_SubMenu);
            label_Menu.Text = "Users";
        }

        private void btn_Test_ShowResultTests_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowData(TypeEntity.Results));
            label_Menu.Text = "Results";
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {



        }
    }
}
