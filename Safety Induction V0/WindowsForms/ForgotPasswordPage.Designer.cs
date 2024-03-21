
namespace Safety_Induction_V0.WindowsForms
{
    partial class ForgotPasswordPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BackToLogin = new System.Windows.Forms.Button();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.txt_OldUsername = new System.Windows.Forms.TextBox();
            this.lbl_ValidateConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_ValidateNewPassword = new System.Windows.Forms.Label();
            this.lbl_ValidateOldUsername = new System.Windows.Forms.Label();
            this.lbl_TBTName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_BackToLogin);
            this.panel1.Controls.Add(this.txt_ConfirmPassword);
            this.panel1.Controls.Add(this.txt_NewPassword);
            this.panel1.Controls.Add(this.btn_Confirm);
            this.panel1.Controls.Add(this.txt_OldUsername);
            this.panel1.Controls.Add(this.lbl_ValidateConfirmPassword);
            this.panel1.Controls.Add(this.lbl_ValidateNewPassword);
            this.panel1.Controls.Add(this.lbl_ValidateOldUsername);
            this.panel1.Controls.Add(this.lbl_TBTName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(753, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 288);
            this.panel1.TabIndex = 11;
            // 
            // btn_BackToLogin
            // 
            this.btn_BackToLogin.BackColor = System.Drawing.Color.White;
            this.btn_BackToLogin.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_BackToLogin.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackToLogin.ForeColor = System.Drawing.Color.Blue;
            this.btn_BackToLogin.Location = new System.Drawing.Point(53, 219);
            this.btn_BackToLogin.Name = "btn_BackToLogin";
            this.btn_BackToLogin.Size = new System.Drawing.Size(200, 39);
            this.btn_BackToLogin.TabIndex = 60;
            this.btn_BackToLogin.Text = "back to login";
            this.btn_BackToLogin.UseVisualStyleBackColor = false;
            this.btn_BackToLogin.Click += new System.EventHandler(this.btn_BackToLogin_Click);
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(53, 168);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(400, 32);
            this.txt_ConfirmPassword.TabIndex = 57;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(53, 106);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(400, 32);
            this.txt_NewPassword.TabIndex = 54;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.White;
            this.btn_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Confirm.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.btn_Confirm.ForeColor = System.Drawing.Color.Black;
            this.btn_Confirm.Location = new System.Drawing.Point(259, 219);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(200, 39);
            this.btn_Confirm.TabIndex = 53;
            this.btn_Confirm.Text = "confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // txt_OldUsername
            // 
            this.txt_OldUsername.Location = new System.Drawing.Point(53, 40);
            this.txt_OldUsername.Name = "txt_OldUsername";
            this.txt_OldUsername.Size = new System.Drawing.Size(400, 32);
            this.txt_OldUsername.TabIndex = 50;
            // 
            // lbl_ValidateConfirmPassword
            // 
            this.lbl_ValidateConfirmPassword.AutoSize = true;
            this.lbl_ValidateConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ValidateConfirmPassword.Font = new System.Drawing.Font("Gill Sans MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValidateConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValidateConfirmPassword.Location = new System.Drawing.Point(268, 145);
            this.lbl_ValidateConfirmPassword.Name = "lbl_ValidateConfirmPassword";
            this.lbl_ValidateConfirmPassword.Size = new System.Drawing.Size(185, 27);
            this.lbl_ValidateConfirmPassword.TabIndex = 59;
            this.lbl_ValidateConfirmPassword.Text = "Password should match";
            // 
            // lbl_ValidateNewPassword
            // 
            this.lbl_ValidateNewPassword.AutoSize = true;
            this.lbl_ValidateNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ValidateNewPassword.Font = new System.Drawing.Font("Gill Sans MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValidateNewPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValidateNewPassword.Location = new System.Drawing.Point(247, 84);
            this.lbl_ValidateNewPassword.Name = "lbl_ValidateNewPassword";
            this.lbl_ValidateNewPassword.Size = new System.Drawing.Size(206, 27);
            this.lbl_ValidateNewPassword.TabIndex = 56;
            this.lbl_ValidateNewPassword.Text = "Enter at least 8 characters";
            // 
            // lbl_ValidateOldUsername
            // 
            this.lbl_ValidateOldUsername.AutoSize = true;
            this.lbl_ValidateOldUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ValidateOldUsername.Font = new System.Drawing.Font("Gill Sans MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValidateOldUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValidateOldUsername.Location = new System.Drawing.Point(234, 16);
            this.lbl_ValidateOldUsername.Name = "lbl_ValidateOldUsername";
            this.lbl_ValidateOldUsername.Size = new System.Drawing.Size(219, 27);
            this.lbl_ValidateOldUsername.TabIndex = 52;
            this.lbl_ValidateOldUsername.Text = "Please enter your username";
            // 
            // lbl_TBTName
            // 
            this.lbl_TBTName.AutoSize = true;
            this.lbl_TBTName.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.lbl_TBTName.Location = new System.Drawing.Point(48, 15);
            this.lbl_TBTName.Name = "lbl_TBTName";
            this.lbl_TBTName.Size = new System.Drawing.Size(97, 29);
            this.lbl_TBTName.TabIndex = 51;
            this.lbl_TBTName.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.label5.Location = new System.Drawing.Point(48, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 15F);
            this.label3.Location = new System.Drawing.Point(48, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "New Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Safety_Induction_V0.Properties.Resources.ra_login__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Safety_Induction_V0.Properties.Resources.ra_login__1_;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1386, 756);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Safety_Induction_V0.Properties.Resources.ra_login__1_;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ForgotPasswordPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_TBTName;
        private System.Windows.Forms.TextBox txt_OldUsername;
        private System.Windows.Forms.Label lbl_ValidateConfirmPassword;
        private System.Windows.Forms.Label lbl_ValidateNewPassword;
        private System.Windows.Forms.Label lbl_ValidateOldUsername;
        private System.Windows.Forms.Button btn_BackToLogin;
    }
}