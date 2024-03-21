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
    public partial class EditPage : Form
    {

        SafetyInductionEntities context = new SafetyInductionEntities();

        InsertTBTMethods binding = new InsertTBTMethods();
        TBTGVBindingMethods binding1 = new TBTGVBindingMethods();
        public EditPage()
        {
            InitializeComponent();
            binding.DisplayTBTDetails(dataGridView_Instructors);
        }

        private void lnk_ViewEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisplayEmployeePage p = new DisplayEmployeePage();
            p.ShowDialog();
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
            Hide();
            EditTBTPage p = new EditTBTPage();
            p.ShowDialog();
        }

        private void lnk_EditAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnk_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMethod.UserRoleID = 0;
            Hide();
            LoginPage p = new LoginPage();
            p.ShowDialog();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_RemoveAccess_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView_Instructors_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (e.ColumnIndex == dataGridView1.Columns["ID"].Index)
            //    {
            //        dataGridView1.EndEdit();
            //        decimal quantity = Convert.ToDecimal(row.Cells["ID"].Value);
            //        decimal price = Convert.ToDecimal(row.Cells["Amt"].Value);
            //        decimal netprice = (quantity * price);
            //        row.Cells["netprice"].Value = Math.Round((netprice), 2);
            //    }
            //}


            //Tool_Box_Talk t = new Tool_Box_Talk();
            //short id = short.Parse(dataGridView1.Columns[0].ToString());
            //var obj = from c in context.Tool_Box_Talks
            //          where c.ID == id
            //          select c;
            //dataGridView1.DataSource = obj.ToList();
            //dataGridView1.Rows[e.RowIndex].Cells 
            
            //t.InstID = short.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //context.SaveChanges();

            //binding.InsertTBTGV(dataGridView_Instructors);
        }
        //RevokeAccessGV
    }
}
