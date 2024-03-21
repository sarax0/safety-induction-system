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
    public partial class StatisticsPage : Form
    {
        SafetyInductionEntities db = new SafetyInductionEntities();
        public StatisticsPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            short userRoleID = LoginMethod.UserRoleID;
            LoginMethod.CheckLlogin(lnk_EditAuthorization, picBox_Authorization);
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

            var query1 = (from emp in db.Employees
                          select emp.NID).Count().ToString();
            var query2 = (from emp in db.Employees
                          where emp.Gender == "Female"
                          select emp.NID).Count().ToString();
            var query3 = (from emp in db.Employees
                          where emp.Gender == "Male"
                          select emp.NID).Count().ToString();
            var query4 = (from tool in db.Tool_Box_Talks
                          where tool.Date != null
                          select tool.ID).Count().ToString();

            //var query2 = (from emp in db.Employees
            //              where emp.Warning == 0 
            //              select emp.NID);
            var query10 = (from emp in db.Employees
                          where emp.Warning != 0
                          select emp.NID).Count().ToString();
            var query11 = (from emp in db.Employees
                           where emp.End_date != null
                           select emp.NID).Count().ToString();
            var query12 = (from emp in db.Employees
                           where emp.End_date == null
                           select emp.NID).Count().ToString();
            var query5 = (from project in db.Projects
                          select project.ID).Count().ToString();
            var query6 = (from topic in db.Topics
                          where topic.Name != null
                          select topic.ID).Count().ToString();
            var query7 = (from tool in db.Tool_Box_Talks
                          where tool.InstID == null
                          select tool.ID).Count().ToString();
            var query8 = (from project in db.Projects
                          where project.End_date != null
                          select project.ID).Count().ToString();
            var query9 = (from project in db.Projects
                          where project.End_date == null
                          select project.ID).Count().ToString();
            lbl_countAll.TextAlign = ContentAlignment.MiddleCenter;
            lbl_countMale.TextAlign = ContentAlignment.MiddleCenter;
            lbl_countfemale.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Warned.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Active.TextAlign = ContentAlignment.MiddleCenter;
            lbl_InActive.TextAlign = ContentAlignment.MiddleCenter;

            lbl_TBTTotal.TextAlign = ContentAlignment.MiddleCenter;
            lbl_TBTTopic.TextAlign = ContentAlignment.MiddleCenter;
            lbl_TBTNoInst.TextAlign = ContentAlignment.MiddleCenter;

            lbl_totalProject.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ProjectFinished.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ProjectInProgress.TextAlign = ContentAlignment.MiddleCenter;

            lbl_countAll.Text = query1;
            lbl_countMale.Text = query2;
            lbl_countfemale.Text = query3;
            lbl_Warned.Text = query10;
            lbl_Active.Text = query12;
            lbl_InActive.Text = query11;

            lbl_TBTTotal.Text = query4;
            lbl_TBTTopic.Text = query6;
            lbl_TBTNoInst.Text = query7;

            lbl_totalProject.Text = query5;
            lbl_ProjectFinished.Text = query8;
            lbl_ProjectInProgress.Text = query9;

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
            Hide();
            EditTBTPage p = new EditTBTPage();
            p.ShowDialog();
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

    }
}
