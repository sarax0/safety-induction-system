﻿using Nest;
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
    public partial class DisplayProjectPage : Form
    { 
        #region ***     ModelCalls
        ProjectGVBindingMethods binding = new ProjectGVBindingMethods(); 
        #endregion

        public DisplayProjectPage()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            short userRoleID = LoginMethod.UserRoleID;
            LoginMethod.CheckLlogin(lnk_EditAuthorization, picBox_Authorization);

            lbl_Validation.Visible = false;
            lbl_ValidateCB.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            binding.DisplayProjectDetails(dataGridView_Projects);

            
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
         
        #region ***     CotrolEvents
        //NOT USED
        private void btn_Search_Click(object sender, EventArgs e)
        {
            int cbIndex = cb_SelectSearchCriteria.SelectedIndex;
            if (cbIndex != -1)
            {
                lbl_ValidateCB.Visible = false;

                //if (cbIndex == 0)
                //    binding.DisplayTBTByID(dataGridView_TBT, txt_SearchValue, lbl_Validation);
                if (cbIndex == 0)
                    binding.DisplayProjectTByName(dataGridView_Projects, txt_SearchValue, lbl_Validation);
                else if (cbIndex == 1)
                    binding.DisplayProjectByManager(dataGridView_Projects, txt_SearchValue, lbl_Validation);
                else if (cbIndex == 2)
                    binding.DisplayProjectByStartDate(dataGridView_Projects, dateTimePicker1, lbl_Validation);
                else if (cbIndex == 3)
                    binding.DisplayProjectByEndDate(dataGridView_Projects, dateTimePicker1, lbl_Validation);

            }
            else
            {
                lbl_ValidateCB.Visible = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            binding.DisplayProjectDetails(dataGridView_Projects);
            txt_SearchValue.Text = "";

        }

        private void cb_SelectSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            binding.DisplayProjectDetails(dataGridView_Projects);
            if (cb_SelectSearchCriteria.SelectedIndex == -1)
                lbl_ValidateCB.Visible = true;
            else
                lbl_ValidateCB.Visible = false;

            if (cb_SelectSearchCriteria.SelectedIndex == 2 || cb_SelectSearchCriteria.SelectedIndex == 3)
            { dateTimePicker1.Visible = true; txt_SearchValue.Visible = false; }
            if (cb_SelectSearchCriteria.SelectedIndex != 2 && cb_SelectSearchCriteria.SelectedIndex != 3)
            { txt_SearchValue.Visible = true; dateTimePicker1.Visible = false; }

            txt_SearchValue.Text = "";
        }

        private void txt_SearchValue_TextChanged(object sender, EventArgs e)
        {
            int cbIndex = cb_SelectSearchCriteria.SelectedIndex;
            if (cbIndex != -1)
            {
                lbl_ValidateCB.Visible = false;
                if (cbIndex == 0)
                    binding.DisplayProjectTByName(dataGridView_Projects, txt_SearchValue, lbl_Validation);
                else if (cbIndex == 1)
                    binding.DisplayProjectByManager(dataGridView_Projects, txt_SearchValue, lbl_Validation);
            }
            else
            {
                lbl_ValidateCB.Visible = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int cbIndex = cb_SelectSearchCriteria.SelectedIndex;
            if (cbIndex != -1)
            {
                lbl_ValidateCB.Visible = false;
                if (cbIndex == 2)
                    binding.DisplayProjectByStartDate(dataGridView_Projects, dateTimePicker1, lbl_Validation);
                if (cbIndex == 3)
                    binding.DisplayProjectByEndDate(dataGridView_Projects, dateTimePicker1, lbl_Validation);
            }
            else
            {
                lbl_ValidateCB.Visible = true;
            }
        } 
        #endregion
    }
}
