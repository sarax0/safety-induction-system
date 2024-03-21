using Safety_Induction_V0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safety_Induction_V0.WindowsForms
{
    public partial class EditTBTPage : Form
    {
        SafetyInductionEntities db = new SafetyInductionEntities();
        public EditTBTPage()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            short userRoleID = LoginMethod.UserRoleID;
            LoginMethod.CheckLlogin(lnk_EditAuthorization, picBox_Authorization);

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Topic Name");
            dt.Columns.Add("Topic ID");
            dt.Columns.Add("Instructor Name");
            dt.Columns.Add("Instructor ID");
            dt.Columns.Add("Date");
            var selectTBTQuery = from tools in db.Tool_Box_Talks
                                 join topic in db.Topics
                                 on tools.TopicID equals topic.ID
                                 join instructor in db.Instructors
                                 on tools.InstID equals instructor.ID
                                 select new
                                 {
                                     tools.ID,
                                     topic.Name,
                                     tools.TopicID,
                                     instructor.Instructor_name,
                                     tools.InstID,
                                     tools.Date
                                 };
            foreach (var q in selectTBTQuery)
            {
                dt.Rows.Add(q.ID, q.Name, q.TopicID, q.Instructor_name, q.InstID, q.Date);
            }
            dataGridView_TBT.DataSource = dt;
            dataGridView_TBT.Columns[0].Visible = false;
        }

        #region ***     LinkClicked
        private void lnk_HomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            HomePage p = new HomePage();
            p.ShowDialog();
        }
        private void lnk_ViewEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            //ManageEmployeesPage P = new ManageEmployeesPage();
            ManageEmployeesPage p = new ManageEmployeesPage();
            p.ShowDialog();
        }
        private void lnk_SelectProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            DisplayProjectPage p = new DisplayProjectPage();
            p.ShowDialog();
        }//Edit Project Details
        private void lnk_UpdateProjectInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            EditProjectPage p = new EditProjectPage();
            p.ShowDialog();
        }
        private void lnk_AddNewProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AddProjectPage p = new AddProjectPage();
            p.ShowDialog();
        }
        private void lnk_UpdateProjectStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            UpdateProjectEndDatePage p = new UpdateProjectEndDatePage();
            p.ShowDialog();
        }//Edit Project Status
        private void lnk_SelectFomTBT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            DisplayTBTPage p = new DisplayTBTPage();
            p.ShowDialog();
        }
        private void lnk_UpdateTBT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void lnk_EditAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            EditAuthorizationPage p = new EditAuthorizationPage();
            p.ShowDialog();
        }
        private void lnk_AddNewTools_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AddTBTPage p = new AddTBTPage();
            p.ShowDialog();
        }//add TBT
        private void lnk_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMethod.UserRoleID = 0;
            Hide();
            LoginPage p = new LoginPage();
            p.ShowDialog();
        }
        #endregion

        #region ***     Control Events

        private void btn_Info_Click(object sender, EventArgs e)
        {
            var query1 = (from instructor in db.Instructors
                          select new
                          {
                              Instructor_ID = instructor.ID,
                              Instructor_Name = instructor.Instructor_name
                          });
            var query2 = (from topic in db.Topics
                          select new { Topic_ID = topic.ID, Topic_Name = topic.Name });
            //Regex regex = new Regex("{{({?}?[^{}])*}}");

            //foreach (var q in query1)
            //{
            //    listBox_TopicsAndInstructors.Items.Add(q.ToString());
            //}
            listBox_TopicsAndInstructors.Items.AddRange(query1.ToArray());
            listBox_TopicsAndInstructors.Items.AddRange(query2.ToArray());
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Topic Name");
            dt.Columns.Add("Topic ID");
            dt.Columns.Add("Instructor Name");
            dt.Columns.Add("Instructor ID");
            dt.Columns.Add("Date");
            var selectTBTQuery = from tools in db.Tool_Box_Talks
                                 join topic in db.Topics
                                 on tools.TopicID equals topic.ID
                                 join instructor in db.Instructors
                                 on tools.InstID equals instructor.ID
                                 select new
                                 {
                                     tools.ID,
                                     topic.Name,
                                     tools.TopicID,
                                     instructor.Instructor_name,
                                     tools.InstID,
                                     tools.Date
                                 };
            foreach (var q in selectTBTQuery)
            {
                dt.Rows.Add(q.ID, q.Name, q.TopicID, q.Instructor_name, q.InstID, q.Date);
            }
            dataGridView_TBT.DataSource = dt;
            dataGridView_TBT.Columns[0].Visible = false;
        }

        private void btn_DisplayAfterEditing_Click(object sender, EventArgs e)
        {
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


        private void dataGridView_TBT_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int Id = int.Parse(dataGridView_TBT[0, e.RowIndex].Value.ToString());
            var query = (from tool in db.Tool_Box_Talks
                         where tool.ID == Id
                         select tool).FirstOrDefault();

            query.InstID = short.Parse(dataGridView_TBT[4, e.RowIndex].Value.ToString());
            query.TopicID = short.Parse(dataGridView_TBT[2, e.RowIndex].Value.ToString());
            db.SaveChanges();
        }
        #endregion

    }
}
