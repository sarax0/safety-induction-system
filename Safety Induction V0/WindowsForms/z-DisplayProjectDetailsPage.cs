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
    public partial class DisplayProjectDetailsPage : Form
    {
        SafetyInductionEntities db = new SafetyInductionEntities();
        ProjectGVBindingMethods binding = new ProjectGVBindingMethods();
        //public static short UserRoleID = LoginMethod.UserRoleID;
        public DisplayProjectDetailsPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            binding.DisplayProjectDetails(dataGridView_Projects);
        }

        private void lnk_ViewEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void lnk_UpdateEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ManageEmployeesPage p = new ManageEmployeesPage();
            p.ShowDialog();
        }

        private void lnk_SelectFomTBT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            DisplayTBTPage p = new DisplayTBTPage();
            p.ShowDialog();
        }

        private void lnk_UpdateTBT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnk_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMethod.UserRoleID = 0;
            Application.Exit();
        }

        private void lnk_ProjectDone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Hide();
            //UpdateProjectEndDatePage done = new UpdateProjectEndDatePage();
            //done.Show();
        }

        private void lnk_UpdateProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnk_AddProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Hide();
            //AddProjectPage project = new AddProjectPage();
            //project.Show();
        }
    }
}
