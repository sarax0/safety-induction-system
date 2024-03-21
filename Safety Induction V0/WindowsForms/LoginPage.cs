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
     
    public partial class LoginPage : Form
    {
        #region ***     connection string
        SafetyInductionEntities context = new SafetyInductionEntities(); 
        #endregion

        public LoginPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        #region ***     LinkClicked
        private void lnk_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ForgotPasswordPage p = new ForgotPasswordPage();
            p.ShowDialog();
        }
        #endregion

        #region ***     ControlEvents
        private void LoginPage_Load(object sender, EventArgs e)
        {
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Can't Access static with an instance 
            LoginMethod.login(lbl_UsernameValidation, lbl_PasswordValidation, txt_Username, txt_Password);

        } 
        #endregion
        

    }
}
