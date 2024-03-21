using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using Safety_Induction_V0.WindowsForms;

namespace Safety_Induction_V0.Models
{
    public partial class TBTGVBindingMethods
    {
        #region ***     connection string
        SafetyInductionEntities context = new SafetyInductionEntities();
        #endregion

        #region ***     Binding Methods(Display[ all, By[topic,id,instructor,date ] ])
        public void DisplayTBTDetails(DataGridView gv)
        {
            try
            {
                //var selectTBTQuery = from x in context.Atte
                //                     select 

                var selectTBTQuery = from tool in context.Tool_Box_Talks
                                     join topic in context.Topics
                                     on tool.TopicID equals topic.ID
                                     join instructor in context.Instructors
                                     on tool.InstID equals instructor.ID
                                     select new { topic.ID, topic.Name, tool.Date, InstructorName = instructor.Instructor_name };

                gv.DataSource = selectTBTQuery.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayTBTByTopic(DataGridView gv, TextBox txt, Label validation)
        {
            try
            {
                string topicName = txt.Text;
                var selectTBTByTopicQuery = from tool in context.Tool_Box_Talks
                                            join topic in context.Topics
                                            on tool.TopicID equals topic.ID
                                            join instructor in context.Instructors
                                            on tool.InstID equals instructor.ID
                                            where topic.Name.Contains(topicName)
                                            select new { topic.ID, topic.Name, tool.Date, instructor.Instructor_name };
                if (topicName.Length > 0)
                {
                    validation.Visible = false;
                    if (selectTBTByTopicQuery != null)
                    {
                        gv.DataSource = selectTBTByTopicQuery.ToList();
                    }
                }
                else
                {
                    //validation.Visible = true;
                    DisplayTBTDetails(gv);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayTBTByID(DataGridView gv,TextBox txt, Label validation)
        {
            try
            {
                int topicID = int.Parse(txt.Text);
                var selectTBTByTopicQuery = from tool in context.Tool_Box_Talks
                                            join topic in context.Topics
                                            on tool.TopicID equals topic.ID
                                            join instructor in context.Instructors
                                            on tool.InstID equals instructor.ID
                                            where topic.ID == topicID
                                            select new { topic.ID, topic.Name, tool.Date, instructor.Instructor_name };
                if (topicID != null)
                {
                    validation.Visible = false;
                    if (selectTBTByTopicQuery != null)
                    {
                        gv.DataSource = selectTBTByTopicQuery.ToList();
                    }
                }
                else
                {
                    //validation.Visible = true;
                    DisplayTBTDetails(gv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayTBTByInstructor(DataGridView gv, TextBox txt, Label validation)
        {
            try
            {
                string instName = txt.Text;
                var selectTBTByTopicQuery = from tool in context.Tool_Box_Talks
                                            join topic in context.Topics
                                            on tool.TopicID equals topic.ID
                                            join instructor in context.Instructors
                                            on tool.InstID equals instructor.ID
                                            where instructor.Instructor_name.Contains(instName)
                                            select new { topic.ID, topic.Name, tool.Date, instructor.Instructor_name };
                if (instName.Length > 0)
                {
                    validation.Visible = false;
                    if (selectTBTByTopicQuery != null)
                    {
                        gv.DataSource = selectTBTByTopicQuery.ToList();
                    }
                }
                else
                {
                    //validation.Visible = true;
                    DisplayTBTDetails(gv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayTBTByDate(DataGridView gv, DateTimePicker dateTimePicker, Label validation)
        {
            try
            {
                DateTime dt = DateTime.Parse(dateTimePicker.Value.ToString("MM/dd/yyyy"));
                if (dt == null)
                {
                    //validation.Visible = true;
                    DisplayTBTDetails(gv);
                }
                else
                {
                    validation.Visible = false;
                    var selectTBTByTopicQuery = from tool in context.Tool_Box_Talks
                                                join topic in context.Topics
                                                on tool.TopicID equals topic.ID
                                                join instructor in context.Instructors
                                                on tool.InstID equals instructor.ID
                                                where tool.Date == dt
                                                select new { topic.ID, topic.Name,Date= (DateTime)tool.Date, instructor.Instructor_name };

                    if (selectTBTByTopicQuery != null)
                        gv.DataSource = selectTBTByTopicQuery.ToList();
                    else
                    { 
                        //validation.Visible = true;
                        DisplayTBTDetails(gv);
                    }

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
