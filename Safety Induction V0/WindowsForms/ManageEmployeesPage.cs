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
    public partial class ManageEmployeesPage : Form
    {
        SafetyInductionEntities context = new SafetyInductionEntities();
        //DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
        string id;
        int id1;
        void selectEmployees(DataGridView gv)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NID");
            dt.Columns.Add("Name");
            dt.Columns.Add("PhoneNumber");
            dt.Columns.Add("EmergencyNumber");
            dt.Columns.Add("Address");
            dt.Columns.Add("DateOfbirth");
            dt.Columns.Add("Email");
            dt.Columns.Add("DepartmentID");
            //dt.Columns.Add("Department Name");
            dt.Columns.Add("Warning");
            dt.Columns.Add("StartDate", typeof(System.DateTime));
            dt.Columns.Add("EndDate", typeof(System.DateTime));
            dt.Columns.Add("Position");
            //dt.Columns.Add("Position Name");
            dt.Columns.Add("Gender");
            var query = from employee in context.Employees
                        select new
                        {
                            employee.NID,
                            employee.Name,
                            employee.Phone_number,
                            employee.Emergency_contact,
                            employee.Address,
                            employee.DoB,
                            employee.Email,
                            employee.DeptID,
                            //DeptName = employee.Department.Department_Name, 
                            employee.Warning,
                            employee.Start_date,
                            employee.End_date,
                            employee.PosID,
                            //position = employee.Position.Position_Name, 
                            employee.Gender
                        };

            foreach (var q in query)
            {
                dt.Rows.Add(q.NID, q.Name, q.Phone_number, q.Emergency_contact, q.Address, q.DoB, q.Email, q.DeptID,
                    //q.DeptName,
                    q.Warning, q.Start_date, q.End_date, q.PosID,
                    //q.position, 
                    q.Gender);
            }
            dataGridView_Employees.DataSource = dt;

        }

        public ManageEmployeesPage()
        {
            InitializeComponent();
            short userRoleID = LoginMethod.UserRoleID;
            LoginMethod.CheckLlogin(lnk_EditAuthorization, picBox_Authorization);

            selectEmployees(dataGridView_Employees);
            lbl_Validation.Visible = false;
        }
        #region Control Events
        private void btn_InsertIntoEmployees_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView_Employees.CurrentRow;
            Employee emp = new Employee();
            emp.NID = currentRow.Cells["NID"].Value.ToString();
            emp.Name = currentRow.Cells["Name"].Value.ToString();
            emp.Phone_number = currentRow.Cells["PhoneNumber"].Value.ToString();
            emp.Emergency_contact = currentRow.Cells["EmergencyNumber"].Value.ToString();
            emp.Address = currentRow.Cells["Address"].Value.ToString();
            emp.DoB = DateTime.Parse(currentRow.Cells["DateOfbirth"].Value.ToString());
            emp.Email = currentRow.Cells["Email"].Value.ToString();

            emp.DeptID = short.Parse(currentRow.Cells["DepartmentID"].Value.ToString());
            emp.Warning = int.Parse(currentRow.Cells["Warning"].Value.ToString());
            emp.Start_date = DateTime.Parse(currentRow.Cells["StartDate"].Value.ToString());
            emp.End_date = DateTime.Parse(currentRow.Cells["EndDate"].Value.ToString());

            emp.PosID = short.Parse(currentRow.Cells["Position"].Value.ToString());
            emp.Gender = currentRow.Cells["Gender"].Value.ToString();

            context.Employees.Add(emp);
            context.SaveChanges();
        }

        private void dataGridView_Employees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string Id = dataGridView_Employees[0, e.RowIndex].Value.ToString();
            var query = (from emp in context.Employees
                         where emp.NID == Id
                         select emp).FirstOrDefault();
            query.Name = dataGridView_Employees[1, e.RowIndex].Value.ToString();
            query.Phone_number = dataGridView_Employees[2, e.RowIndex].Value.ToString();
            query.Emergency_contact = dataGridView_Employees[3, e.RowIndex].Value.ToString();
            query.Address = dataGridView_Employees[4, e.RowIndex].Value.ToString();
            query.DoB = DateTime.Parse(dataGridView_Employees[5, e.RowIndex].Value.ToString());
            query.Email = dataGridView_Employees[6, e.RowIndex].Value.ToString();
            query.DeptID = short.Parse(dataGridView_Employees[7, e.RowIndex].Value.ToString());
            query.Warning = int.Parse(dataGridView_Employees[8, e.RowIndex].Value.ToString());
            query.Start_date = DateTime.Parse(dataGridView_Employees[9, e.RowIndex].Value.ToString());
            query.End_date = DateTime.Parse(dataGridView_Employees[10, e.RowIndex].Value.ToString());
            query.PosID = short.Parse(dataGridView_Employees[11, e.RowIndex].Value.ToString());

            context.SaveChanges();
        }
        private void btn_ViewInfo_Click(object sender, EventArgs e)
        {
            var query1 = (from pos in context.Positions
                          select new { pos.ID, pos.Name });
            var query2 = (from dept in context.Departments
                          select new { dept.ID, dept.Name });
            listBox_Info.Items.AddRange(query1.ToArray());
            listBox_Info.Items.AddRange(query2.ToArray());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (comboBox_Searches.SelectedIndex == -1)
            {
                lbl_Validation.Visible = true;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("NID");
            dt.Columns.Add("Name");
            dt.Columns.Add("PhoneNumber");
            dt.Columns.Add("EmergencyNumber");
            dt.Columns.Add("Address");
            dt.Columns.Add("DateOfbirth");
            dt.Columns.Add("Email");
            dt.Columns.Add("DepartmentID");
            //dt.Columns.Add("Department Name");
            dt.Columns.Add("Warning");
            dt.Columns.Add("StartDate", typeof(System.DateTime));
            dt.Columns.Add("EndDate", typeof(System.DateTime));
            dt.Columns.Add("Position");
            //dt.Columns.Add("Position Name");
            dt.Columns.Add("Gender");

            if (comboBox_Searches.SelectedIndex == 0)
            {
                var query = from employee in context.Employees
                            where employee.NID.Contains(textBox_SearchValue.Text)
                            select new
                            {
                                employee.NID,
                                employee.Name,
                                employee.Phone_number,
                                employee.Emergency_contact,
                                employee.Address,
                                employee.DoB,
                                employee.Email,
                                employee.DeptID,
                                //DeptName = employee.Department.Department_Name, 
                                employee.Warning,
                                employee.Start_date,
                                employee.End_date,
                                employee.PosID,
                                //position = employee.Position.Position_Name, 
                                employee.Gender
                            };
                foreach (var q in query)
                {
                    dt.Rows.Add(q.NID, q.Name, q.Phone_number, q.Emergency_contact, q.Address, q.DoB, q.Email, q.DeptID,
                        //q.DeptName,
                        q.Warning, q.Start_date, q.End_date, q.PosID,
                        //q.position, 
                        q.Gender);
                }
                dataGridView_Employees.DataSource = dt;
            }
            if (comboBox_Searches.SelectedIndex == 1)
            {
                var query = from employee in context.Employees
                            where employee.Name.Contains(textBox_SearchValue.Text)
                            select new
                            {
                                employee.NID,
                                employee.Name,
                                employee.Phone_number,
                                employee.Emergency_contact,
                                employee.Address,
                                employee.DoB,
                                employee.Email,
                                employee.DeptID,
                                //DeptName = employee.Department.Department_Name, 
                                employee.Warning,
                                employee.Start_date,
                                employee.End_date,
                                employee.PosID,
                                //position = employee.Position.Position_Name, 
                                employee.Gender
                            };
                foreach (var q in query)
                {
                    dt.Rows.Add(q.NID, q.Name, q.Phone_number, q.Emergency_contact, q.Address, q.DoB, q.Email, q.DeptID,
                        //q.DeptName,
                        q.Warning, q.Start_date, q.End_date, q.PosID,
                        //q.position, 
                        q.Gender);
                }
                dataGridView_Employees.DataSource = dt;
            }
            if (comboBox_Searches.SelectedIndex == 2)
            {
                var query = from employee in context.Employees
                            where employee.Address.Contains(textBox_SearchValue.Text)
                            select new
                            {
                                employee.NID,
                                employee.Name,
                                employee.Phone_number,
                                employee.Emergency_contact,
                                employee.Address,
                                employee.DoB,
                                employee.Email,
                                employee.DeptID,
                                //DeptName = employee.Department.Department_Name, 
                                employee.Warning,
                                employee.Start_date,
                                employee.End_date,
                                employee.PosID,
                                //position = employee.Position.Position_Name, 
                                employee.Gender
                            };
                foreach (var q in query)
                {
                    dt.Rows.Add(q.NID, q.Name, q.Phone_number, q.Emergency_contact, q.Address, q.DoB, q.Email, q.DeptID,
                        //q.DeptName,
                        q.Warning, q.Start_date, q.End_date, q.PosID,
                        //q.position, 
                        q.Gender);
                }
                dataGridView_Employees.DataSource = dt;
            }
            if (comboBox_Searches.SelectedIndex == 3)
            {
                var query = from employee in context.Employees
                            where employee.Phone_number.Contains(textBox_SearchValue.Text)
                            select new
                            {
                                employee.NID,
                                employee.Name,
                                employee.Phone_number,
                                employee.Emergency_contact,
                                employee.Address,
                                employee.DoB,
                                employee.Email,
                                employee.DeptID,
                                //DeptName = employee.Department.Department_Name, 
                                employee.Warning,
                                employee.Start_date,
                                employee.End_date,
                                employee.PosID,
                                //position = employee.Position.Position_Name, 
                                employee.Gender
                            };
                foreach (var q in query)
                {
                    dt.Rows.Add(q.NID, q.Name, q.Phone_number, q.Emergency_contact, q.Address, q.DoB, q.Email, q.DeptID,
                        //q.DeptName,
                        q.Warning, q.Start_date, q.End_date, q.PosID,
                        //q.position, 
                        q.Gender);
                }
                dataGridView_Employees.DataSource = dt;
            }
        }

        #endregion

        #region Linked Labels
        private void lnk_HomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            HomePage p = new HomePage();
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
