using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Safety_Induction_V0.WindowsForms;

namespace Safety_Induction_V0.Models
{
    class ProjectGVBindingMethods
    {
        #region ***     connection string
        SafetyInductionEntities context = new SafetyInductionEntities();
        #endregion

        #region ***     BindingMethods(Display[ all, By[Name,Manager,startdate,enddate ] ])
        public void DisplayProjectDetails(DataGridView gv)
        {
            try
            { 
                DataTable dt = new DataTable();
                dt.Columns.Add("Project Name");
                dt.Columns.Add("Manager");
                dt.Columns.Add("Start Date", typeof(System.DateTime));
                dt.Columns.Add("End Date", typeof(System.DateTime));
                var query = (from poject in context.Projects
                             join emp in context.Employees
                             on poject.ManagerID equals emp.NID
                             select new { poject.Project_name, emp.Name, poject.Start_date, poject.End_date });
                foreach (var q in query)
                {
                    dt.Rows.Add(q.Project_name, q.Name, q.Start_date, q.End_date);
                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayProjectTByName(DataGridView gv, TextBox txt, Label validation)
        {
            try
            {
                string projectName = txt.Text;
                DataTable dt = new DataTable();
                dt.Columns.Add("Project Name");
                dt.Columns.Add("Manager");
                dt.Columns.Add("Start Date", typeof(System.DateTime));
                dt.Columns.Add("End Date", typeof(System.DateTime));
                if (projectName.Length > 0)
                {
                    var queryProjectByName = (from poject in context.Projects
                             join emp in context.Employees
                             on poject.ManagerID equals emp.NID
                             where poject.Project_name.Contains(projectName)
                             select new { poject.Project_name, emp.Name, poject.Start_date, poject.End_date });
                

                
                    validation.Visible = false;
                    if (queryProjectByName != null)
                    {
                        foreach (var q in queryProjectByName)
                        {
                            dt.Rows.Add(q.Project_name, q.Name, q.Start_date, q.End_date);
                        }
                        gv.DataSource = dt;
                    }
                }
                else
                {
                    //validation.Visible = true;
                    DisplayProjectDetails(gv);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayProjectByManager(DataGridView gv, TextBox txt, Label validation)
        {
            try
            {
                string mgrName = txt.Text;
                DataTable dt = new DataTable();
                dt.Columns.Add("Project Name");
                dt.Columns.Add("Manager");
                dt.Columns.Add("Start Date", typeof(System.DateTime));
                dt.Columns.Add("End Date", typeof(System.DateTime));
                if (mgrName.Length > 0)
                {
                    var queryProjectByManager = (from poject in context.Projects
                                             join emp in context.Employees
                                             on poject.ManagerID equals emp.NID
                                             where emp.Name.Contains(mgrName)
                                             select new { poject.Project_name, emp.Name, poject.Start_date, poject.End_date });

                
                    validation.Visible = false;
                    if (queryProjectByManager != null)
                    {
                        foreach (var q in queryProjectByManager)
                        {
                            dt.Rows.Add(q.Project_name, q.Name, q.Start_date, q.End_date);
                        }
                        gv.DataSource = dt;
                    }
                }
                else
                {
                    //validation.Visible = true;
                    DisplayProjectDetails(gv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayProjectByStartDate(DataGridView gv, DateTimePicker dateTimePicker, Label validation)
        {
            try
            {
                DateTime date = DateTime.Parse(dateTimePicker.Value.ToString("MM/dd/yyyy"));
                if (date == null)
                {
                    //validation.Visible = true;
                    DisplayProjectDetails(gv);
                }
                else
                {
                    validation.Visible = false;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Project Name");
                    dt.Columns.Add("Manager");
                    dt.Columns.Add("Start Date", typeof(System.DateTime));
                    dt.Columns.Add("End Date", typeof(System.DateTime));
                    var queryProjectByStartDate = (from poject in context.Projects
                                                   join emp in context.Employees
                                                   on poject.ManagerID equals emp.NID
                                                   where poject.Start_date == date
                                                   select new { poject.Project_name, emp.Name, poject.Start_date, poject.End_date });


                    if (queryProjectByStartDate != null)
                    {
                        foreach (var q in queryProjectByStartDate)
                        {
                            dt.Rows.Add(q.Project_name, q.Name, q.Start_date, q.End_date);
                        }
                        gv.DataSource = dt;
                    }
                    else
                        DisplayProjectDetails(gv);
                    //validation.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayProjectByEndDate(DataGridView gv, DateTimePicker dateTimePicker, Label validation)
        {
            try
            {
                DateTime date = DateTime.Parse(dateTimePicker.Value.ToString("MM/dd/yyyy"));
                if (date == null)
                {
                    DisplayProjectDetails(gv);
                    //validation.Visible = true;
                }
                else
                {
                    validation.Visible = false;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Project Name");
                    dt.Columns.Add("Manager");
                    dt.Columns.Add("Start Date", typeof(System.DateTime));
                    dt.Columns.Add("End Date", typeof(System.DateTime));
                    var queryProjectByEndDate = (from poject in context.Projects
                                                   join emp in context.Employees
                                                   on poject.ManagerID equals emp.NID
                                                   where poject.End_date == date
                                                   select new { poject.Project_name, emp.Name, poject.Start_date, poject.End_date });


                    if (queryProjectByEndDate != null)
                    {
                        foreach (var q in queryProjectByEndDate)
                        {
                            dt.Rows.Add(q.Project_name, q.Name, q.Start_date, q.End_date);
                        }
                        gv.DataSource = dt;
                    }
                    else
                        DisplayProjectDetails(gv);
                    //validation.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion



    }
}
