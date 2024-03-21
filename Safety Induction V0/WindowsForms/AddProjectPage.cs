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
    public partial class AddProjectPage : Form
    { 
        SafetyInductionEntities db = new SafetyInductionEntities();
        void viewEmployees()
        {
            var query = (from emp in db.Employees
                         select emp.Name);
            cb_EmployeeNames.Items.AddRange(query.ToArray());
        }
        public AddProjectPage()
        {
            InitializeComponent();

            short userRoleID = LoginMethod.UserRoleID;
            LoginMethod.CheckLlogin(lnk_EditAuthorization, picBox_Authorization);

            lbl_Validation.Visible = false;
            btn_delete.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        #region ***     LinkClicked

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
        private void lnk_AddNewTools_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AddTBTPage p = new AddTBTPage();
            p.Show();
        }
        private void lnk_EditAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            EditAuthorizationPage p = new EditAuthorizationPage();
            p.ShowDialog();
        }
        private void lnk_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMethod.UserRoleID = 0;
            Hide();
            LoginPage p = new LoginPage();
            p.ShowDialog();
        }

        #endregion

        #region Control Events
        private void btn_ViewData_Click(object sender, EventArgs e)
        {
            var query = (from emp in db.Employees
                         select emp.Name);
            cb_EmployeeNames.Items.AddRange(query.ToArray());
        }

        private void btn_InsertIntoProject_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            if (txt_ProjectName.Text.Length > 0)
            {
                foreach (var item in cb_EmployeeNames.CheckedItems)
                {
                    Employee employee = db.Employees.Where(emp => emp.Name == item.ToString()).FirstOrDefault();
                    project.Employee = employee;
                    project.Start_date = DateTime.Now;
                    project.Project_name = txt_ProjectName.Text;
                    db.Projects.Add(project);
                    db.SaveChanges();
                }
                DataTable dt = new DataTable();
                dt.Columns.Add("Project Name");
                dt.Columns.Add("Manager");
                dt.Columns.Add("Start Date");
                dt.Columns.Add("End Date");
                var query = (from poject in db.Projects
                             join emp in db.Employees
                             on poject.ManagerID  equals emp.NID
                             select new { poject.Project_name, emp.Name, poject.Start_date, poject.End_date });
                foreach (var q in query)
                {
                    dt.Rows.Add(q.Project_name, q.Name, q.Start_date, q.End_date);
                }
                dataGridView_Projects.DataSource = dt;
            }
            else
            {
                lbl_Validation.Visible = true;
            }
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selectedrow;
            selectedrow = dataGridView_Projects.CurrentCell.RowIndex;
            dataGridView_Projects.Rows.RemoveAt(selectedrow);
            //DataGridViewRow selectedrow1;
            //selectedrow1 = dataGridView_Projects.CurrentRow;
            //db.Departments.Remove(selectedrow1.Cells["ID"].Value.ToString);
            db.SaveChanges();
        }
        #endregion

    }
}
