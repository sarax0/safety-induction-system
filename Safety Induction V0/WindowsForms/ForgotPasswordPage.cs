using Safety_Induction_V0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safety_Induction_V0.WindowsForms
{
    
    public partial class ForgotPasswordPage : Form
    {
            
        #region ***     ModelCalls
        EditProfileMethods method = new EditProfileMethods();
        SafetyInductionEntities context = new SafetyInductionEntities(); 
        #endregion

        public ForgotPasswordPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            lbl_ValidateOldUsername.Visible = false;
            lbl_ValidateNewPassword.Visible = false;
            lbl_ValidateConfirmPassword.Visible = false;
        }
                
        #region ***     ControlEvents
        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            method.EditPassword(txt_OldUsername, txt_NewPassword, txt_ConfirmPassword,
                lbl_ValidateOldUsername, lbl_ValidateNewPassword, lbl_ValidateConfirmPassword);
        }

        private void btn_BackToLogin_Click(object sender, EventArgs e)
        {
            Hide();
            LoginPage p = new LoginPage();
            p.ShowDialog();
        } 
        #endregion


    }
}
