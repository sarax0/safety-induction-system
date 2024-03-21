using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Safety_Induction_V0.WindowsForms;

namespace Safety_Induction_V0.Models
{
    public class LoginMethod 
    {
        #region ***     connection string
        static SafetyInductionEntities context = new SafetyInductionEntities();
        #endregion

        #region ***     fields
        public static short UserRoleID;
        public static short InstID;
        #endregion
        
        #region ***     Methods(login, checkLogin)
        public static bool login(Label UsernameValidation, Label PasswordValidation, TextBox username, TextBox password)
        {
            var loginQuery = context.Logins;
            bool state = false;
            UsernameValidation.Visible = false;
            PasswordValidation.Visible = false;

            try
            {

                if (username.Text.Length == 0)
                    UsernameValidation.Visible = true;
                if (password.Text.Length == 0)
                    PasswordValidation.Visible = true;
                if (username.Text.Length > 0 && password.Text.Length > 0)
                {
                    string Username = username.Text;
                    string Password = password.Text;

                    var query = loginQuery.ToList().Where(l => l.User_Name == Username && l.Password == Password).FirstOrDefault();

                    if (query != null)
                    {
                        UserRoleID = (short)query.RoleID;
                        InstID = (short)query.InstID;
                        Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
                        lastOpenedForm.Hide();

                        HomePage home = new HomePage();
                        home.ShowDialog();
                        state = true;
                    }
                    else
                    {
                        //if (query.User_Name.Equals(username) == true && query.User_Name.Equals(password)== false)
                        //    MessageBox.Show("Invalid username...", "Faild");
                        //if (query.User_Name.Equals(password) == false && query.User_Name.Equals(username) ==true )
                        //    MessageBox.Show("Invalid password...", "Faild");
                        //if (query.User_Name.Equals(username) == false && query.User_Name.Equals(password) == false)
                        MessageBox.Show("Invalid username or password...", "Faild");
                        state = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                state = false;
            }
            return state;
        }

        public static void CheckLlogin(LinkLabel lnk_EditAuthorization, PictureBox picBox_Authorization)
        {
            try
            {

                short userRoleID = UserRoleID;
                if (userRoleID == 1)
                {
                    lnk_EditAuthorization.Visible = true;
                    picBox_Authorization.Visible = true;
                }
                else
                    lnk_EditAuthorization.Visible = false; picBox_Authorization.Visible = false;

                if (userRoleID == 0) { Application.Exit(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        #endregion

    }
}



