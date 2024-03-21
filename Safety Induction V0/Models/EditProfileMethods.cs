using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safety_Induction_V0.Models
{
    public class EditProfileMethods
    { 
        #region ***     connection string
        SafetyInductionEntities context = new SafetyInductionEntities();
        #endregion 

        #region ***     Methods (EditPassword Overload(forogt,update) , View profile)

        public void EditPassword(TextBox txt_name, TextBox txt_oldPass,
                                TextBox txt_newPass, TextBox txt_confirmPass,
                                Label lbl_validOldName, Label lbl_validOldPass,
                                Label lbl_validNewPass, Label lbl_validConfirmPass)
        {
            //if (txt_name.TextLength <= 0 || txt_oldPass.TextLength <= 0 || txt_newPass.TextLength <= 0 || txt_confirmPass.TextLength <= 0)
            //{
            //    lbl_validOldName.Text = "All Fields Are Requred";
            //    lbl_validOldName.Visible = true;

            //}
            try
            {
                if (txt_name.TextLength <= 0)
                    lbl_validOldName.Visible = true;
                if (txt_oldPass.TextLength <=0)
                    lbl_validOldPass.Visible = true;
                if (txt_newPass.TextLength <=0)
                    lbl_validNewPass.Visible = true;
                if (txt_newPass.Text != txt_confirmPass.Text)
                    lbl_validConfirmPass.Visible = true;


                if (txt_name.TextLength > 0)
                {
                    Login username = context.Logins.Where(s => s.User_Name == txt_name.Text).FirstOrDefault();
                    lbl_validOldName.Visible = false;
                    //if (txt_oldPass.TextLength > 7 && txt_newPass.TextLength > 7 && txt_confirmPass.TextLength > 7)
                    //{
                        lbl_validNewPass.Visible = false;
                        lbl_validOldPass.Visible = false;
                        lbl_validConfirmPass.Visible = false;
                        if (username.User_Name == txt_name.Text)
                        {
                            if (txt_oldPass.Text == username.Password)
                            {
                                if (txt_newPass.Text == txt_confirmPass.Text)
                                { 
                                    username.Password = txt_newPass.Text; 
                                    lbl_validConfirmPass.Visible = false;
                                    context.SaveChanges();
                                    MessageBox.Show("Password Updated successfully . . .", "Update");
                                }
                                else
                                    lbl_validConfirmPass.Visible = true;
                            }
                            
                            
                        }
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        public void ViewDetails(DataGridView gv, TextBox txt_name)
        {
            try
            {
                if (txt_name.TextLength > 0)
                {
                    var instIDQuery = from l in context.Logins
                                      where l.User_Name == txt_name.Text
                                      from i in context.Instructors
                                      where i.ID == l.InstID
                                      from e in context.Employees
                                      where e.NID == i.NID
                                      select new
                                      {
                                          Username = l.User_Name,
                                          e.NID,
                                          Password = l.Password,
                                          EmployeeName = e.Name,
                                          Department = e.Department.Name,
                                          Position = e.Position.Name,
                                          StartDate = e.Start_date
                                      };

                    gv.DataSource = instIDQuery.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditPassword(TextBox txt_name, TextBox txt_newPass,
            TextBox txt_confirmPass, Label lbl_validOldName,
            Label lbl_validNewPass, Label lbl_validConfirmPass)
        {
            try
            {

                if (txt_name.TextLength <= 0)
                    lbl_validOldName.Visible = true;
                if (txt_newPass.TextLength < 8)
                    lbl_validNewPass.Visible = true;
                if (txt_newPass.Text != txt_confirmPass.Text)
                    lbl_validConfirmPass.Visible = true;


                if (txt_name.TextLength > 0)
                {
                    Login username = context.Logins.Where(s => s.User_Name == txt_name.Text).FirstOrDefault();
                    lbl_validOldName.Visible = false;
                    if (txt_newPass.TextLength > 7 && txt_confirmPass.TextLength > 7)
                    {
                        lbl_validNewPass.Visible = false;
                        lbl_validConfirmPass.Visible = false;
                        if (username.User_Name == txt_name.Text)
                        {
                            if (txt_newPass.Text == txt_confirmPass.Text)
                                username.Password = txt_newPass.Text;
                            else
                                lbl_validConfirmPass.Visible = true;
                            context.SaveChanges();
                            MessageBox.Show("Password Changed successfully . . .", "update password");
                        }
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
