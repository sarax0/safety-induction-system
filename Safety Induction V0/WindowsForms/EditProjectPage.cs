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
    public partial class EditProjectPage : Form
    {
        SafetyInductionEntities db = new SafetyInductionEntities();
        public EditProjectPage()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            short userRoleID = LoginMethod.UserRoleID;
            LoginMethod.CheckLlogin(lnk_EditAuthorization, picBox_Authorization);

            DataTable dt = new DataTable();
            dt.Columns.Add("Project ID");
            dt.Columns.Add("Project Name");
            dt.Columns.Add("Supervisor NID");
            dt.Columns.Add("Supervisor Name");
            dt.Columns.Add("Start Date");
            dt.Columns.Add("End Date");
            var query = (from poject in db.Projects
                         join emp in db.Employees
                         on poject.ManagerID equals emp.NID
                         select new
                         {
                             poject.ID,
                             poject.Project_name,
                             poject.ManagerID,
                             emp.Name,
                             poject.Start_date,
                             poject.End_date
                         });
            foreach (var q in query)
            {
                dt.Rows.Add(q.ID, q.Project_name, q.ManagerID, q.Name, q.Start_date, q.End_date);
            }
            dataGridView_Projects.DataSource = dt;
            dataGridView_Projects.Columns[0].Visible = false;

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
                
        #region ***     Control Events
        private void btn_EmployeesNames_Click(object sender, EventArgs e)
        {
            var query = (from emp in db.Employees
                         select new { emp.Name, emp.NID });
            listBox_EmployeeDetails.Items.AddRange(query.ToArray());
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Project ID");
            dt.Columns.Add("Project Name");
            dt.Columns.Add("Employee NID");
            dt.Columns.Add("Employee Name");
            dt.Columns.Add("Start Date");
            dt.Columns.Add("End Date");
            var query = (from poject in db.Projects
                         join emp in db.Employees
                         on poject.ManagerID equals emp.NID
                         select new
                         {
                             poject.ID,
                             poject.Project_name,
                             poject.ManagerID,
                             emp.Name,
                             poject.Start_date,
                             poject.End_date
                         });
            foreach (var q in query)
            {
                dt.Rows.Add(q.ID, q.Project_name, q.ManagerID, q.Name, q.Start_date, q.End_date);
            }
            dataGridView_Projects.DataSource = dt;
            dataGridView_Projects.Columns[0].Visible = false;
        }

        private void btn_DisplayAfterEditing_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Project Name");
            dt.Columns.Add("Manager");
            dt.Columns.Add("Start Date");
            dt.Columns.Add("End Date");
            var query = (from poject in db.Projects
                         join emp in db.Employees
                         on poject.ManagerID equals emp.NID
                         select new { poject.Project_name, emp.Name, poject.Start_date, poject.End_date });
            foreach (var q in query)
            {
                dt.Rows.Add(q.Project_name, q.Name, q.Start_date, q.End_date);
            }
            dataGridView_Projects.DataSource = dt;
        }

        private void dataGridView_Projects_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int Id = int.Parse(dataGridView_Projects[0, e.RowIndex].Value.ToString());
            var query = (from poject in db.Projects
                         where poject.ID == Id
                         select poject).FirstOrDefault();
            query.Project_name = dataGridView_Projects[1, e.RowIndex].Value.ToString();
            query.ManagerID = dataGridView_Projects[2, e.RowIndex].Value.ToString();
            db.SaveChanges();
        }
        #endregion

    }
}
