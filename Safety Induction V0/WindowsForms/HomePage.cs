using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Safety_Induction_V0.Models;

namespace Safety_Induction_V0.WindowsForms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            btn_settings.Visible = false;
            short userRoleID = LoginMethod.UserRoleID;
            LoginMethod.CheckLlogin(lnk_EditAuthorization, picBox_Authorization);
        }

        #region ***     LinkClicked
        private void lnk_HomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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
            Hide();
            EditTBTPage p = new EditTBTPage();
            p.ShowDialog();
        }
        private void lnk_EditAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
                
        #region ***     ControlEvents
        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Hide();
            UserPersonalDetailsPage p = new UserPersonalDetailsPage();
            p.ShowDialog();
        }
        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            Hide();
            StatisticsPage p = new StatisticsPage();
            p.ShowDialog();
        }
        #endregion


    }
}
