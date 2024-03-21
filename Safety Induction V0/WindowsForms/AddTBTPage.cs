using Safety_Induction_V0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safety_Induction_V0.WindowsForms
{
    public partial class AddTBTPage : Form
    {
        SafetyInductionEntities db = new SafetyInductionEntities();
        public AddTBTPage()
        {
            InitializeComponent();
            short userRoleID = LoginMethod.UserRoleID;
            LoginMethod.CheckLlogin(lnk_EditAuthorization, picBox_Authorization);

            lbl_validation.Visible = false;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        #region Control Events
        private void btn_AddNewTopic_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            if (txt_TopicName.Text.Length > 0)
            {
                topic.Name = txt_TopicName.Text;
                db.Topics.Add(topic);
                db.SaveChanges();
                MessageBox.Show("A new topic has been added");
            }
            else
            {
                lbl_validation.Visible = true;
            }
        }

        private void btn_ViewData_Click(object sender, EventArgs e)
        {
            var query1 = (from topic in db.Topics
                          select topic.Name);
            cb_TopicNames.Items.AddRange(query1.ToArray());
            var query2 = (from instructor in db.Instructors
                          select instructor.Instructor_name);
            cb_InstructorNames.Items.AddRange(query2.ToArray());
        }
        private void btn_InsertIntoTBT_Click(object sender, EventArgs e)
        {
            Tool_Box_Talk tool = new Tool_Box_Talk();
            #region
            //List<string> instructors = new List<string>();
            //List<string> topics = new List<string>();

            //for (int i = 0; i < cb_InstructorNames.Items.Count; i++)
            //{

            //    foreach (var item in cb_InstructorNames.CheckedItems)
            //    {
            //        instructors.Add(cb_InstructorNames.Items[i].ToString());
            //    }

            //}
            //for (int i = 0; i < cb_TopicNames.Items.Count; i++)
            //{

            //    foreach (var item in cb_TopicNames.CheckedItems)
            //    {
            //        topics.Add(cb_TopicNames.Items[i].ToString());
            //    }

            //}
            //var res = topics.Zip(instructors, (t, i) => new { topicname = t, instname = i });
            //foreach (var r in res)
            //{
            //    Topic obj = db.Topics.Where(topic => topic.Name == r.topicname).FirstOrDefault();
            //    Instructor instructor = db.Instructors.Where(inst => inst.Instructor_name == r.instname).FirstOrDefault();
            //    tool.Instructor = instructor;
            //    tool.Topic = obj;
            //    tool.Date = DateTime.Now;
            //    db.Tool_Box_Talks.Add(tool);
            //    db.SaveChanges();
            //}
            #endregion
            foreach (var item in cb_TopicNames.CheckedItems)
            {
                Topic obj = db.Topics.Where(topic => topic.Name == item.ToString()).FirstOrDefault();
                tool.Topic = obj;
                foreach (var instname in cb_InstructorNames.CheckedItems)
                {
                    Instructor instructor = db.Instructors.Where(inst => inst.Instructor_name == instname).FirstOrDefault();
                    tool.Instructor = instructor;
                }
                tool.Date = DateTime.Now;
                db.Tool_Box_Talks.Add(tool);
                db.SaveChanges();
                DataTable dt = new DataTable();
                dt.Columns.Add("Topic Name");
                dt.Columns.Add("Date");
                dt.Columns.Add("Instructor name");
                var selectTBTQuery = from tools in db.Tool_Box_Talks
                                     join topic in db.Topics
                                     on tools.TopicID equals topic.ID
                                     join instructor in db.Instructors
                                     on tools.InstID equals instructor.ID
                                     select new { topic.Name, tools.Date, instructor.Instructor_name };
                foreach (var q in selectTBTQuery)
                {
                    dt.Rows.Add(q.Name, q.Date, q.Instructor_name);
                }
                dataGridView_TBT.DataSource = dt;
            }
        }

        #endregion

        #region Linked Lablels
        private void lnk_HomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            HomePage p = new HomePage();
            p.Show();
        }

        private void lnk_ViewEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ManageEmployeesPage p = new ManageEmployeesPage();
            p.Show();
        }

        private void lnk_SelectProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            DisplayProjectPage p = new DisplayProjectPage();
            p.Show();
        }

        private void lnk_UpdateProjectInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            EditProjectPage p = new EditProjectPage();
            p.Show();
        }

        private void lnk_AddNewProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AddProjectPage p = new AddProjectPage();
            p.Show();
        }

        private void lnk_UpdateProjectStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            UpdateProjectEndDatePage p = new UpdateProjectEndDatePage();
            p.Show();
        }

        private void lnk_SelectFomTBT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            DisplayTBTPage p = new DisplayTBTPage();
            p.Show();
        }

        private void lnk_UpdateTBT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            EditTBTPage p = new EditTBTPage();
            p.Show();
        }

        private void lnk_EditAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            EditAuthorizationPage p = new EditAuthorizationPage();
            p.Show();
        }

        private void lnk_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMethod.UserRoleID = 0;
            Hide();
            LoginPage p = new LoginPage();
            p.ShowDialog();
        }
        #endregion
    }
}
