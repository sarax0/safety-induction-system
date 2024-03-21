using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Safety_Induction_V0.WindowsForms;

namespace Safety_Induction_V0.Models
{
    public partial class ManageAutotizationMethods
    {
        #region ***     connection string
        SafetyInductionEntities context = new SafetyInductionEntities();
        #endregion

        #region ***     Methods( display (users, instructor) , Access (grant, revoke) )
        public static string GenerateName(string name)
        {
            Random r = new Random();
            string[] numbers = { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002" };
            string Name = Regex.Replace(name, @"\s+", ""); //remove white spaces
            Name += numbers[r.Next(numbers.Length)];
            return Name;
        }

        public static string GeneratePassword(string consonant)
        {
            Random r = new Random();
            string[] numbers = { "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000" };
            string name = consonant.Split()[0];//Regex.Replace(consonant, @"\s+", ""); //remove white spaces
            string Password = name + "#" + numbers[r.Next(numbers.Length)];
            return Password;
        }
        public void DisplayInstructors(DataGridView gv)
        {
            try
            {
                DataGridViewRow gvRow = new DataGridViewRow();
                gvRow = gv.CurrentRow;
                var selectInstructorsQuery = from I in context.Instructors
                                             select new
                                             {
                                                 InstructorID = I.ID,
                                                 InstructorName = I.Instructor_name,
                                             };

                gv.DataSource = selectInstructorsQuery.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplaySystemUsers(DataGridView gv)
        {
            try
            {
                var selectLoginQuery = from l in context.Logins
                                       select new
                                       {
                                           Username = l.User_Name,
                                           Password = l.Password,
                                           InstructorID = l.InstID,
                                           RoleID = l.RoleID
                                       };
                gv.DataSource = selectLoginQuery.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GrantAccessGV(DataGridView gv)
        {
            try
            {
                string message = string.Empty;
                foreach (DataGridViewRow row in gv.Rows)
                {
                    Login login = new Login();
                    string instName = "";

                    bool isSelected = Convert.ToBoolean(row.Cells["ck_GrantAccessGV"].Value);
                    if (isSelected)
                    {
                        short instID = short.Parse(row.Cells["InstructorID"].Value.ToString());

                        var selectLoginQuery = (from l in context.Logins
                                                where l.InstID == instID
                                                select l).FirstOrDefault();

                        var selectUsernameLogin = from l in context.Logins
                                                  select l;

                        instName = row.Cells["InstructorName"].Value.ToString();

                        if (selectLoginQuery == null)
                        {

                            instName = row.Cells["InstructorName"].Value.ToString();

                            message += Environment.NewLine;
                            message += "Users Added :  ";
                            message += instName;

                            string generatedUsername = GenerateName(row.Cells["InstructorName"].Value.ToString());

                            foreach (var item in selectUsernameLogin)
                            {
                                if (generatedUsername != item.User_Name) { }
                                else
                                    generatedUsername = GenerateName(row.Cells["InstructorName"].Value.ToString());
                            }

                            login.User_Name = generatedUsername;//GenerateName(row.Cells["InstructorName"].Value.ToString());
                            login.Password = GeneratePassword(row.Cells["InstructorName"].Value.ToString());
                            login.InstID = short.Parse(row.Cells["InstructorID"].Value.ToString());
                            login.RoleID = 2;
                            if (login != null)
                            {
                                context.Logins.Add(login);
                                context.SaveChanges();
                            }

                        }
                        else
                        {
                            message += Environment.NewLine;
                            message += $"User Already Exist: ";
                            message += instName;
                        }
                    }


                }

                MessageBox.Show(message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void RevokeAccessGV(DataGridView gv)
        {
            string message = "";
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                Login login = new Login();
                bool isSelected = Convert.ToBoolean(row.Cells["ck_RevokeAccessGV"].Value);
                short rid = short.Parse(row.Cells["RoleID"].Value.ToString());
                if (isSelected)
                {
                    if (rid != 1)
                    {
                        message = "Removed  Users. . .";
                        message += Environment.NewLine;
                        message += row.Cells["Username"].Value.ToString();
                        count += 1;
                        short instID = short.Parse(row.Cells["InstructorID"].Value.ToString());
                        string instName = row.Cells["Username"].Value.ToString();
                        login = context.Logins.Where(l => l.User_Name == instName).FirstOrDefault();

                        if (login != null)
                        {
                            context.Logins.Remove(login);
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        message = "You Can't Delete the Admin";
                    }
                }
            }
            DisplaySystemUsers(gv);
            MessageBox.Show(message);


        }

        #region ***     NOT USED
        public void InsertLoginGV(DataGridView gv)
        {
            //try
            //{
            if (gv.CurrentRow != null)
            {
                DataGridViewRow gvRow = new DataGridViewRow();
                gvRow = gv.CurrentRow;
                Login login = new Login();
                login.User_Name = gvRow.Cells["txt_UsernameGV"].Value.ToString();
                login.Password = gvRow.Cells["txt_PasswordGV"].Value.ToString();
                login.InstID = short.Parse(gvRow.Cells["txt_InstructorIDGV"].Value.ToString());
                login.RoleID = short.Parse(gvRow.Cells["cb_RoleGV"].Value.ToString());
                context.Logins.Add(login);
                context.SaveChanges();
            }
            //else
            //{
            //    MessageBox.Show(". . .");
            //}

            //gv.DataSource = context.Logins.ToList();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public void ManageAuthorizatrion(Label validate_InstID, Label validate_Username,
                                          Label validate_password, Label validate_cbRole,
                                          TextBox TXT_InstID, TextBox TXT_usename,
                                          TextBox TXT_password,
                                          ComboBox CB_Role)
        {
            validate_InstID.Visible = false;
            validate_Username.Visible = false;
            validate_password.Visible = false;
            validate_cbRole.Visible = false;

            short instID = short.Parse(TXT_InstID.Text);
            string username = TXT_usename.Text;
            string password = TXT_password.Text;

            if (instID == 0)
                validate_InstID.Visible = true;
            if (username.Length == 0)
                validate_Username.Visible = true;
            if (password.Length == 0)
                validate_password.Visible = true;
            if (CB_Role.SelectedIndex == -1)
                validate_cbRole.Visible = true;

            var checkInstID = context.Instructors.Find(instID);
            var grantAccess = context.Logins;
            if (checkInstID != null)
            {
                Login access = new Login();
                access.InstID = instID;
                access.User_Name = username;
                access.Password = password;
                access.RoleID = 1;//short.Parse(cb_Role.SelectedIndex.ToString());
                grantAccess.Add(access);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Invalid Instructor ID . . . ");
            }

        }  
        #endregion

        #endregion
    }
}
