using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Safety_Induction_V0.WindowsForms
{
    public partial class EditEmployeePage : Form
    {
         SafetyInductionEntities context = new SafetyInductionEntities();
        DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
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
                dt.Columns.Add("Warning");
                dt.Columns.Add("StartDate", typeof(System.DateTime));
                dt.Columns.Add("EndDate", typeof(System.DateTime));
                dt.Columns.Add("Position");
                dt.Columns.Add("Gender");
                var query = from employee in context.Employees
                            select new { employee.NID, employee.Name, employee.Phone_number, employee.Emergency_contact, employee.Address, employee.DoB, employee.Email, DeptName = employee.Department.Name, employee.Warning, employee.Start_date, employee.End_date, position = employee.Position.Name };

            foreach (var q in query)
            {
                dt.Rows.Add(q.NID, q.Name, q.Phone_number, q.Emergency_contact, q.Address, q.DoB, q.Email, q.DeptName, q.Warning, q.Start_date, q.End_date, q.position);
            }
            dataGridView1.DataSource = dt;

        }
        void CBPositionFill(DataGridViewComboBoxColumn cb)
        {
            var query = from p in context.Positions
                        select p.Name;
            cb.DataSource = query.ToList();
        }
        
        public EditEmployeePage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            selectEmployees(dataGridView1);
            comboBoxColumn.HeaderText = "Position";
            comboBoxColumn.Width = 100;
            comboBoxColumn.Name = "cb_Position";
            CBPositionFill(comboBoxColumn);
            
        }
        private void lnk_ViewEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisplayEmployeePage p = new DisplayEmployeePage();
            p.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string nid = textBox1.Text;

            var selectbyIdQuery = from emp in context.Employees
                                  where emp.NID == nid
                                  select emp;
            dataGridView1.DataSource = selectbyIdQuery.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nid = textBox1.Text;
                if (nid.Length > 0)
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
                    dt.Columns.Add("Warning");
                    dt.Columns.Add("StartDate", typeof(System.DateTime));
                    dt.Columns.Add("EndDate", typeof(System.DateTime));

                    dataGridView1.Columns.Add(comboBoxColumn);

                    //dt.Columns.Add("PosID");
                    dt.Columns.Add("Gender");
                    var query = from employee in context.Employees
                                where employee.NID.Contains(nid)
                                select new { employee.NID, employee.Name, employee.Phone_number, employee.Emergency_contact, employee.Address, employee.DoB, employee.Email, DeptName = employee.Department.Name, employee.Warning, employee.Start_date, employee.End_date, position = employee.Position.Name };

                    foreach (var q in query)
                    {
                        dt.Rows.Add(q.NID, q.Name, q.Phone_number, q.Emergency_contact, q.Address, q.DoB, q.Email, q.DeptName, q.Warning, q.Start_date, q.End_date, q.position);
                    }
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    selectEmployees(dataGridView1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //string Id = (dataGridView1[0, e.RowIndex].Value.ToString());
            ////var query = (from emp in context.Employees
            ////             where emp.NID == Id
            ////             select emp).FirstOrDefault();

            //if (e.ColumnIndex == dataGridView1.Columns["NID"].Index)
            //{
            //    // dataGridView1.EndEdit(); // No need this line, you are already in CellEndEdit event

            //    var currentRow = dataGridView1.Rows[e.RowIndex];

            //    emp.NID = currentRow.Cells["NID"].Value.ToString();
            //    emp.Name = currentRow.Cells["Name"].Value.ToString();
            //    emp.Email = currentRow.Cells["Email"].Value.ToString();
            //    emp.Phone_number = currentRow.Cells["Phone Number"].Value.ToString();

            //}
            //context.Employees.Add(emp);
            //context.SaveChanges();
            //MessageBox.Show("added");
            //foreach (DataGridViewRow currentRow in dataGridView1.Rows)
            //{
            //    Employee emp = new Employee();
            //    //if (e.ColumnIndex == dataGridView1.Columns["NID"].Index)
            //    //{
            //        dataGridView1.EndEdit();
            //        emp.NID = currentRow.Cells["NID"].Value.ToString();
            //        emp.Name = currentRow.Cells["Name"].Value.ToString();
            //        emp.Email = currentRow.Cells["Email"].Value.ToString();
            //        emp.Phone_number = currentRow.Cells["Phone Number"].Value.ToString();
            //    //}
            //    context.Employees.Add(emp);
            //    context.SaveChanges();
            //    MessageBox.Show("added");
            //}





        }

        private void button1_Click(object sender, EventArgs e)
        {

                var currentRow = dataGridView1.CurrentRow;
                Employee emp = new Employee();
                emp.NID = currentRow.Cells["NID"].Value.ToString();
                emp.Name = currentRow.Cells["Name"].Value.ToString();
                emp.Phone_number = currentRow.Cells["Phone Number"].Value.ToString();
                emp.Emergency_contact = currentRow.Cells["Emergency Number"].Value.ToString();
                emp.Address = currentRow.Cells["Address"].Value.ToString();
                emp.DoB = DateTime.Parse("01/01/2023");
                emp.Email = currentRow.Cells["Email"].Value.ToString();

                emp.DeptID = 6003; 
                emp.Warning = int.Parse(currentRow.Cells["Warning"].Value.ToString());
                emp.Start_date = DateTime.Parse("01/01/2023");
                emp.End_date = DateTime.Parse("01/01/2023");

                emp.PosID = 2;
                emp.Gender = currentRow.Cells["Gender"].Value.ToString();


                context.Employees.Add(emp);
                context.SaveChanges();

        }
    }
}
