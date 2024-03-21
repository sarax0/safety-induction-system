
namespace Safety_Induction_V0.WindowsForms
{
    partial class DisplayProjectPage
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
            this.dataGridView_Projects = new System.Windows.Forms.DataGridView();
            this.txt_SearchValue = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_SelectSearchCriteria = new System.Windows.Forms.ComboBox();
            this.lbl_searchCriteria = new System.Windows.Forms.Label();
            this.lbl_Validation = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_ValidateCB = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnk_HomePage = new System.Windows.Forms.LinkLabel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lnk_AddNewTools = new System.Windows.Forms.LinkLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lnk_AddNewProject = new System.Windows.Forms.LinkLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lnk_LogOut = new System.Windows.Forms.LinkLabel();
            this.lnk_UpdateTBT = new System.Windows.Forms.LinkLabel();
            this.lnk_SelectProject = new System.Windows.Forms.LinkLabel();
            this.lnk_UpdateProjectInfo = new System.Windows.Forms.LinkLabel();
            this.lnk_SelectFomTBT = new System.Windows.Forms.LinkLabel();
            this.lnk_EditAuthorization = new System.Windows.Forms.LinkLabel();
            this.lnk_ViewEmployees = new System.Windows.Forms.LinkLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picBox_Authorization = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            this.picBox_ViewEmployee = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnk_UpdateProjectStatus = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Authorization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Projects
            // 
            this.dataGridView_Projects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Projects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Projects.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_Projects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Projects.Location = new System.Drawing.Point(375, 311);
            this.dataGridView_Projects.Name = "dataGridView_Projects";
            this.dataGridView_Projects.RowHeadersWidth = 40;
            this.dataGridView_Projects.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Projects.Size = new System.Drawing.Size(931, 369);
            this.dataGridView_Projects.TabIndex = 6;
            // 
            // txt_SearchValue
            // 
            this.txt_SearchValue.Location = new System.Drawing.Point(570, 203);
            this.txt_SearchValue.Name = "txt_SearchValue";
            this.txt_SearchValue.Size = new System.Drawing.Size(269, 38);
            this.txt_SearchValue.TabIndex = 8;
            this.txt_SearchValue.TextChanged += new System.EventHandler(this.txt_SearchValue_TextChanged);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(370, 45);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(380, 47);
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "Display Project Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search Value";
            // 
            // cb_SelectSearchCriteria
            // 
            this.cb_SelectSearchCriteria.FormattingEnabled = true;
            this.cb_SelectSearchCriteria.Items.AddRange(new object[] {
            "Project Name",
            "Manager Name",
            "Start Date",
            "End Date"});
            this.cb_SelectSearchCriteria.Location = new System.Drawing.Point(570, 137);
            this.cb_SelectSearchCriteria.Name = "cb_SelectSearchCriteria";
            this.cb_SelectSearchCriteria.Size = new System.Drawing.Size(269, 43);
            this.cb_SelectSearchCriteria.TabIndex = 11;
            this.cb_SelectSearchCriteria.SelectedIndexChanged += new System.EventHandler(this.cb_SelectSearchCriteria_SelectedIndexChanged);
            // 
            // lbl_searchCriteria
            // 
            this.lbl_searchCriteria.AutoSize = true;
            this.lbl_searchCriteria.Location = new System.Drawing.Point(401, 140);
            this.lbl_searchCriteria.Name = "lbl_searchCriteria";
            this.lbl_searchCriteria.Size = new System.Drawing.Size(186, 38);
            this.lbl_searchCriteria.TabIndex = 12;
            this.lbl_searchCriteria.Text = "Search Criteria";
            // 
            // lbl_Validation
            // 
            this.lbl_Validation.AutoSize = true;
            this.lbl_Validation.Font = new System.Drawing.Font("Gill Sans MT", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Validation.ForeColor = System.Drawing.Color.Red;
            this.lbl_Validation.Location = new System.Drawing.Point(845, 206);
            this.lbl_Validation.Name = "lbl_Validation";
            this.lbl_Validation.Size = new System.Drawing.Size(312, 33);
            this.lbl_Validation.TabIndex = 13;
            this.lbl_Validation.Text = "Enter a value to search with";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Reset.Location = new System.Drawing.Point(1135, 270);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(171, 39);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_ValidateCB
            // 
            this.lbl_ValidateCB.AutoSize = true;
            this.lbl_ValidateCB.Font = new System.Drawing.Font("Gill Sans MT", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValidateCB.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValidateCB.Location = new System.Drawing.Point(845, 143);
            this.lbl_ValidateCB.Name = "lbl_ValidateCB";
            this.lbl_ValidateCB.Size = new System.Drawing.Size(242, 33);
            this.lbl_ValidateCB.TabIndex = 16;
            this.lbl_ValidateCB.Text = "Select search criteria";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(570, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 38);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.lnk_HomePage);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.lnk_AddNewTools);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.lnk_AddNewProject);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.lnk_LogOut);
            this.panel1.Controls.Add(this.lnk_UpdateTBT);
            this.panel1.Controls.Add(this.lnk_SelectProject);
            this.panel1.Controls.Add(this.lnk_UpdateProjectInfo);
            this.panel1.Controls.Add(this.lnk_SelectFomTBT);
            this.panel1.Controls.Add(this.lnk_EditAuthorization);
            this.panel1.Controls.Add(this.lnk_ViewEmployees);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.picBox_Authorization);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.picBox_Logo);
            this.panel1.Controls.Add(this.picBox_ViewEmployee);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lnk_UpdateProjectStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 691);
            this.panel1.TabIndex = 28;
            // 
            // lnk_HomePage
            // 
            this.lnk_HomePage.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_HomePage.AutoSize = true;
            this.lnk_HomePage.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_HomePage.LinkColor = System.Drawing.Color.White;
            this.lnk_HomePage.Location = new System.Drawing.Point(88, 159);
            this.lnk_HomePage.Name = "lnk_HomePage";
            this.lnk_HomePage.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_HomePage.Size = new System.Drawing.Size(132, 46);
            this.lnk_HomePage.TabIndex = 42;
            this.lnk_HomePage.TabStop = true;
            this.lnk_HomePage.Text = "Home Page";
            this.lnk_HomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_HomePage_LinkClicked);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Safety_Induction_V0.Properties.Resources.home;
            this.pictureBox9.Location = new System.Drawing.Point(32, 159);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pictureBox9.Size = new System.Drawing.Size(25, 30);
            this.pictureBox9.TabIndex = 41;
            this.pictureBox9.TabStop = false;
            // 
            // lnk_AddNewTools
            // 
            this.lnk_AddNewTools.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_AddNewTools.AutoSize = true;
            this.lnk_AddNewTools.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_AddNewTools.LinkColor = System.Drawing.Color.White;
            this.lnk_AddNewTools.Location = new System.Drawing.Point(88, 527);
            this.lnk_AddNewTools.Name = "lnk_AddNewTools";
            this.lnk_AddNewTools.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_AddNewTools.Size = new System.Drawing.Size(116, 46);
            this.lnk_AddNewTools.TabIndex = 39;
            this.lnk_AddNewTools.TabStop = true;
            this.lnk_AddNewTools.Text = "Add TBT ";
            this.lnk_AddNewTools.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_AddNewTools_LinkClicked_1);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Safety_Induction_V0.Properties.Resources.addTBT;
            this.pictureBox8.Location = new System.Drawing.Point(32, 527);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pictureBox8.Size = new System.Drawing.Size(25, 30);
            this.pictureBox8.TabIndex = 38;
            this.pictureBox8.TabStop = false;
            // 
            // lnk_AddNewProject
            // 
            this.lnk_AddNewProject.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_AddNewProject.AutoSize = true;
            this.lnk_AddNewProject.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_AddNewProject.LinkColor = System.Drawing.Color.White;
            this.lnk_AddNewProject.Location = new System.Drawing.Point(88, 389);
            this.lnk_AddNewProject.Name = "lnk_AddNewProject";
            this.lnk_AddNewProject.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_AddNewProject.Size = new System.Drawing.Size(202, 46);
            this.lnk_AddNewProject.TabIndex = 35;
            this.lnk_AddNewProject.TabStop = true;
            this.lnk_AddNewProject.Text = "Add New Project ";
            this.lnk_AddNewProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_AddNewProject_LinkClicked);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Safety_Induction_V0.Properties.Resources.insertEmp;
            this.pictureBox7.Location = new System.Drawing.Point(32, 389);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pictureBox7.Size = new System.Drawing.Size(25, 30);
            this.pictureBox7.TabIndex = 34;
            this.pictureBox7.TabStop = false;
            // 
            // lnk_LogOut
            // 
            this.lnk_LogOut.ActiveLinkColor = System.Drawing.Color.Red;
            this.lnk_LogOut.AutoSize = true;
            this.lnk_LogOut.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_LogOut.LinkColor = System.Drawing.Color.White;
            this.lnk_LogOut.Location = new System.Drawing.Point(88, 620);
            this.lnk_LogOut.Name = "lnk_LogOut";
            this.lnk_LogOut.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_LogOut.Size = new System.Drawing.Size(101, 46);
            this.lnk_LogOut.TabIndex = 33;
            this.lnk_LogOut.TabStop = true;
            this.lnk_LogOut.Text = "Log Out";
            this.lnk_LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_LogOut_LinkClicked);
            // 
            // lnk_UpdateTBT
            // 
            this.lnk_UpdateTBT.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_UpdateTBT.AutoSize = true;
            this.lnk_UpdateTBT.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_UpdateTBT.LinkColor = System.Drawing.Color.White;
            this.lnk_UpdateTBT.Location = new System.Drawing.Point(88, 481);
            this.lnk_UpdateTBT.Name = "lnk_UpdateTBT";
            this.lnk_UpdateTBT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_UpdateTBT.Size = new System.Drawing.Size(105, 46);
            this.lnk_UpdateTBT.TabIndex = 32;
            this.lnk_UpdateTBT.TabStop = true;
            this.lnk_UpdateTBT.Text = "Edit TBT";
            this.lnk_UpdateTBT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_UpdateTBT_LinkClicked);
            // 
            // lnk_SelectProject
            // 
            this.lnk_SelectProject.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_SelectProject.AutoSize = true;
            this.lnk_SelectProject.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_SelectProject.LinkColor = System.Drawing.Color.White;
            this.lnk_SelectProject.Location = new System.Drawing.Point(88, 251);
            this.lnk_SelectProject.Name = "lnk_SelectProject";
            this.lnk_SelectProject.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_SelectProject.Size = new System.Drawing.Size(246, 46);
            this.lnk_SelectProject.TabIndex = 31;
            this.lnk_SelectProject.TabStop = true;
            this.lnk_SelectProject.Text = "Display Project Details";
            this.lnk_SelectProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_SelectProject_LinkClicked);
            // 
            // lnk_UpdateProjectInfo
            // 
            this.lnk_UpdateProjectInfo.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_UpdateProjectInfo.AutoSize = true;
            this.lnk_UpdateProjectInfo.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_UpdateProjectInfo.LinkColor = System.Drawing.Color.White;
            this.lnk_UpdateProjectInfo.Location = new System.Drawing.Point(88, 297);
            this.lnk_UpdateProjectInfo.Name = "lnk_UpdateProjectInfo";
            this.lnk_UpdateProjectInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_UpdateProjectInfo.Size = new System.Drawing.Size(211, 46);
            this.lnk_UpdateProjectInfo.TabIndex = 29;
            this.lnk_UpdateProjectInfo.TabStop = true;
            this.lnk_UpdateProjectInfo.Text = "Edit Project Details";
            this.lnk_UpdateProjectInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_UpdateProjectInfo_LinkClicked);
            // 
            // lnk_SelectFomTBT
            // 
            this.lnk_SelectFomTBT.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_SelectFomTBT.AutoSize = true;
            this.lnk_SelectFomTBT.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_SelectFomTBT.LinkColor = System.Drawing.Color.White;
            this.lnk_SelectFomTBT.Location = new System.Drawing.Point(88, 435);
            this.lnk_SelectFomTBT.Name = "lnk_SelectFomTBT";
            this.lnk_SelectFomTBT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_SelectFomTBT.Size = new System.Drawing.Size(217, 46);
            this.lnk_SelectFomTBT.TabIndex = 27;
            this.lnk_SelectFomTBT.TabStop = true;
            this.lnk_SelectFomTBT.Text = "Display TBT Details";
            this.lnk_SelectFomTBT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_SelectFomTBT_LinkClicked);
            // 
            // lnk_EditAuthorization
            // 
            this.lnk_EditAuthorization.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_EditAuthorization.AutoSize = true;
            this.lnk_EditAuthorization.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_EditAuthorization.LinkColor = System.Drawing.Color.White;
            this.lnk_EditAuthorization.Location = new System.Drawing.Point(88, 574);
            this.lnk_EditAuthorization.Name = "lnk_EditAuthorization";
            this.lnk_EditAuthorization.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_EditAuthorization.Size = new System.Drawing.Size(202, 46);
            this.lnk_EditAuthorization.TabIndex = 26;
            this.lnk_EditAuthorization.TabStop = true;
            this.lnk_EditAuthorization.Text = "Edit Authorization";
            this.lnk_EditAuthorization.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_EditAuthorization_LinkClicked);
            // 
            // lnk_ViewEmployees
            // 
            this.lnk_ViewEmployees.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_ViewEmployees.AutoSize = true;
            this.lnk_ViewEmployees.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_ViewEmployees.LinkColor = System.Drawing.Color.White;
            this.lnk_ViewEmployees.Location = new System.Drawing.Point(88, 205);
            this.lnk_ViewEmployees.Name = "lnk_ViewEmployees";
            this.lnk_ViewEmployees.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_ViewEmployees.Size = new System.Drawing.Size(209, 46);
            this.lnk_ViewEmployees.TabIndex = 24;
            this.lnk_ViewEmployees.TabStop = true;
            this.lnk_ViewEmployees.Text = "Manage Employees";
            this.lnk_ViewEmployees.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ViewEmployees_LinkClicked);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Safety_Induction_V0.Properties.Resources.logout;
            this.pictureBox6.Location = new System.Drawing.Point(32, 625);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pictureBox6.Size = new System.Drawing.Size(25, 30);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // picBox_Authorization
            // 
            this.picBox_Authorization.Image = global::Safety_Induction_V0.Properties.Resources.access1;
            this.picBox_Authorization.Location = new System.Drawing.Point(32, 575);
            this.picBox_Authorization.Name = "picBox_Authorization";
            this.picBox_Authorization.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.picBox_Authorization.Size = new System.Drawing.Size(25, 30);
            this.picBox_Authorization.TabIndex = 17;
            this.picBox_Authorization.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Safety_Induction_V0.Properties.Resources.TBTEdit;
            this.pictureBox3.Location = new System.Drawing.Point(32, 481);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pictureBox3.Size = new System.Drawing.Size(25, 30);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Safety_Induction_V0.Properties.Resources.TBTDetails;
            this.pictureBox4.Location = new System.Drawing.Point(32, 435);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pictureBox4.Size = new System.Drawing.Size(25, 30);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Safety_Induction_V0.Properties.Resources.updateProject;
            this.pictureBox5.Location = new System.Drawing.Point(32, 297);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pictureBox5.Size = new System.Drawing.Size(25, 30);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Safety_Induction_V0.Properties.Resources.projectDetails;
            this.pictureBox2.Location = new System.Drawing.Point(32, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pictureBox2.Size = new System.Drawing.Size(25, 30);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Logo.Image = global::Safety_Induction_V0.Properties.Resources.LogoHrizontal;
            this.picBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(292, 133);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_Logo.TabIndex = 3;
            this.picBox_Logo.TabStop = false;
            // 
            // picBox_ViewEmployee
            // 
            this.picBox_ViewEmployee.Image = global::Safety_Induction_V0.Properties.Resources.updateEmp;
            this.picBox_ViewEmployee.Location = new System.Drawing.Point(32, 205);
            this.picBox_ViewEmployee.Name = "picBox_ViewEmployee";
            this.picBox_ViewEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.picBox_ViewEmployee.Size = new System.Drawing.Size(25, 30);
            this.picBox_ViewEmployee.TabIndex = 2;
            this.picBox_ViewEmployee.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Safety_Induction_V0.Properties.Resources.Status;
            this.pictureBox1.Location = new System.Drawing.Point(32, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pictureBox1.Size = new System.Drawing.Size(25, 30);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lnk_UpdateProjectStatus
            // 
            this.lnk_UpdateProjectStatus.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.lnk_UpdateProjectStatus.AutoSize = true;
            this.lnk_UpdateProjectStatus.Font = new System.Drawing.Font("Gill Sans MT", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_UpdateProjectStatus.LinkColor = System.Drawing.Color.White;
            this.lnk_UpdateProjectStatus.Location = new System.Drawing.Point(88, 343);
            this.lnk_UpdateProjectStatus.Name = "lnk_UpdateProjectStatus";
            this.lnk_UpdateProjectStatus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lnk_UpdateProjectStatus.Size = new System.Drawing.Size(238, 46);
            this.lnk_UpdateProjectStatus.TabIndex = 37;
            this.lnk_UpdateProjectStatus.TabStop = true;
            this.lnk_UpdateProjectStatus.Text = "Update Project Status";
            this.lnk_UpdateProjectStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_UpdateProjectStatus_LinkClicked);
            // 
            // DisplayProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1354, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_ValidateCB);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Validation);
            this.Controls.Add(this.lbl_searchCriteria);
            this.Controls.Add(this.cb_SelectSearchCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SearchValue);
            this.Controls.Add(this.dataGridView_Projects);
            this.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DisplayProjectPage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Authorization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Projects;
        private System.Windows.Forms.TextBox txt_SearchValue;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_SelectSearchCriteria;
        private System.Windows.Forms.Label lbl_searchCriteria;
        private System.Windows.Forms.Label lbl_Validation;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_ValidateCB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnk_HomePage;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnk_AddNewTools;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.LinkLabel lnk_UpdateProjectStatus;
        private System.Windows.Forms.LinkLabel lnk_AddNewProject;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.LinkLabel lnk_LogOut;
        private System.Windows.Forms.LinkLabel lnk_UpdateTBT;
        private System.Windows.Forms.LinkLabel lnk_SelectProject;
        private System.Windows.Forms.LinkLabel lnk_UpdateProjectInfo;
        private System.Windows.Forms.LinkLabel lnk_SelectFomTBT;
        private System.Windows.Forms.LinkLabel lnk_EditAuthorization;
        private System.Windows.Forms.LinkLabel lnk_ViewEmployees;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picBox_Authorization;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBox_Logo;
        private System.Windows.Forms.PictureBox picBox_ViewEmployee;
    }
}