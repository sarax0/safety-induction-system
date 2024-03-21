
namespace Safety_Induction_V0.WindowsForms
{
    partial class LoginPage
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
            this.lbl_PasswordValidation = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_UsernameValidation = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnk_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PasswordValidation
            // 
            this.lbl_PasswordValidation.AutoSize = true;
            this.lbl_PasswordValidation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.lbl_PasswordValidation.Location = new System.Drawing.Point(222, 100);
            this.lbl_PasswordValidation.Name = "lbl_PasswordValidation";
            this.lbl_PasswordValidation.Size = new System.Drawing.Size(292, 28);
            this.lbl_PasswordValidation.TabIndex = 10;
            this.lbl_PasswordValidation.Text = "Please enter a valid password";
            this.lbl_PasswordValidation.Visible = false;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Password.Location = new System.Drawing.Point(51, 95);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(114, 34);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Username.Location = new System.Drawing.Point(51, 17);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(120, 34);
            this.lbl_Username.TabIndex = 8;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_UsernameValidation
            // 
            this.lbl_UsernameValidation.AutoSize = true;
            this.lbl_UsernameValidation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsernameValidation.ForeColor = System.Drawing.Color.Red;
            this.lbl_UsernameValidation.Location = new System.Drawing.Point(216, 20);
            this.lbl_UsernameValidation.Name = "lbl_UsernameValidation";
            this.lbl_UsernameValidation.Size = new System.Drawing.Size(295, 28);
            this.lbl_UsernameValidation.TabIndex = 7;
            this.lbl_UsernameValidation.Text = "Please enter a valid username";
            this.lbl_UsernameValidation.Visible = false;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(121, 180);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(252, 39);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(56, 126);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(400, 38);
            this.txt_Password.TabIndex = 5;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(53, 47);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(400, 38);
            this.txt_Username.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lnk_ForgotPassword);
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Controls.Add(this.lbl_PasswordValidation);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.lbl_UsernameValidation);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Location = new System.Drawing.Point(753, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 300);
            this.panel1.TabIndex = 11;
            // 
            // lnk_ForgotPassword
            // 
            this.lnk_ForgotPassword.AutoSize = true;
            this.lnk_ForgotPassword.Font = new System.Drawing.Font("Gill Sans MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_ForgotPassword.Location = new System.Drawing.Point(179, 223);
            this.lnk_ForgotPassword.Name = "lnk_ForgotPassword";
            this.lnk_ForgotPassword.Size = new System.Drawing.Size(166, 31);
            this.lnk_ForgotPassword.TabIndex = 11;
            this.lnk_ForgotPassword.TabStop = true;
            this.lnk_ForgotPassword.Text = "forgot password?";
            this.lnk_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ForgotPassword_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Safety_Induction_V0.Properties.Resources.ra_login__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Safety_Induction_V0.Properties.Resources.ra_login__1_;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 729);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Safety_Induction_V0.Properties.Resources.ra_login__1_;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_UsernameValidation;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_PasswordValidation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnk_ForgotPassword;
    }
}