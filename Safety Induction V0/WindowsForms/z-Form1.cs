using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safety_Induction_V0
{
    public partial class Form1 : Form
    {
        SafetyInductionEntities context = new SafetyInductionEntities();
        public Form1()
        {
            InitializeComponent();




            // Add the events to listen for
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(dataGridView1_CurrentCellDirtyStateChanged);



            var query1 = from p in context.Projects
                         select p.Employee.Name;


            DataTable dt = new DataTable();
            dt.Columns.Add("NID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Manager");
            dt.Columns.Add("Date");
            var testTextColumn = new DataGridViewComboBoxColumn();
            testTextColumn.HeaderText = "Manager";
            //testTextColumn.ind
            testTextColumn.DataSource = query1.ToList();
            testTextColumn.DataPropertyName = "Manager";
            dataGridView1.Columns.Add(testTextColumn);
            var query = from p in context.Projects
                        select new
                        {
                            p.ManagerID,
                            p.Project_name,
                            p.Employee.Name,
                            p.Start_date

                        };
            foreach (var item in query)
            {
                dt.Rows.Add(item.ManagerID, item.Project_name, item.Name, item.Start_date);
            }
            dataGridView1.DataSource = dt;






        }


        



        // This event handler manually raises the CellValueChanged event 
        // by calling the CommitEdit method. 
        void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[1];
            if (cb.Value != null)
            {
                // do stuff
                dataGridView1.Invalidate();
            }
        }










    }
}
