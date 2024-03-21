using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Safety_Induction_V0.WindowsForms;

namespace Safety_Induction_V0.Models
{
    class InsertTBTMethods
    {
        #region ***     connection string
        SafetyInductionEntities context = new SafetyInductionEntities();
        #endregion

        #region ***     Methods (Display, Insert)

        public void DisplayTBTDetails(DataGridView gv)
        {
            try
            {
                var selectTBTQuery = from tool in context.Tool_Box_Talks
                                     join topic in context.Topics
                                     on tool.TopicID equals topic.ID
                                     join instructor in context.Instructors
                                     on tool.InstID equals instructor.ID
                                     select new
                                     {
                                         TopicID = topic.ID,
                                         TopicName = topic.Name,
                                         Date = tool.Date,
                                         InstructorName = instructor.Instructor_name
                                     };

                gv.DataSource = selectTBTQuery.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertTBTGV(DataGridView gv)
        {
            try
            {
                Tool_Box_Talk tbt = new Tool_Box_Talk();
                DataGridViewRow gvRow = new DataGridViewRow();
                gvRow = gv.CurrentRow;
                foreach (DataGridViewRow Row in gv.Rows)
                {

                    //if ((Row.Cells["ck_GrantAccessGV"].Value) != null)
                    //{
                    //    if ((bool)(Row.Cells["ck_GrantAccessGV"].Value) == true)
                    //    {

                    gv.Rows[Row.Index].Selected = true;
                    tbt.ID = short.Parse(gvRow.Cells["TopicID"].Value.ToString());
                    tbt.Topic.Name = gvRow.Cells["TopicName"].Value.ToString();
                    tbt.Date = DateTime.Parse(gvRow.Cells["Date"].Value.ToString());
                    tbt.Instructor.Instructor_name = gvRow.Cells["InstructorName"].Value.ToString();
                    context.Tool_Box_Talks.Add(tbt);
                    context.SaveChanges();

                    //    }
                    //    else
                    //    {
                    //        gv.Rows[Row.Index].Selected = false;
                    //    }
                    //}

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
