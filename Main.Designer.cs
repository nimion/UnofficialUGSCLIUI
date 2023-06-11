namespace UnofficialUGSCLIUI
{
    partial class frmUGSCLIUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemLoadProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUGSCLIPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageEnvironment = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActiveEnvironmentName = new System.Windows.Forms.TextBox();
            this.txtActiveEnvironmentId = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCreateEnvironment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddEnvironmentName = new System.Windows.Forms.TextBox();
            this.txtAddEnvironmentId = new System.Windows.Forms.TextBox();
            this.tabPageAuth = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblActiveAuthProfileFriendlyName = new System.Windows.Forms.Label();
            this.lblActiveAuthProfileAccountKeyId = new System.Windows.Forms.Label();
            this.txtActiveAuthProfileFriendlyName = new System.Windows.Forms.TextBox();
            this.txtActiveAuthProfuleAccountKeyId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreateAuthProfile = new System.Windows.Forms.Button();
            this.lblAuthProfileFriendlyName = new System.Windows.Forms.Label();
            this.lblAccountKeyId = new System.Windows.Forms.Label();
            this.txtAddAuthProfileFriendlyName = new System.Windows.Forms.TextBox();
            this.txtAddAuthProfileAccountKeyId = new System.Windows.Forms.TextBox();
            this.lblAccountSecretKey = new System.Windows.Forms.Label();
            this.txtAddAuthProfileAccountSecretKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditAuthProfile = new System.Windows.Forms.Button();
            this.btnDeleteAuthProfile = new System.Windows.Forms.Button();
            this.btnUseAuthProfile = new System.Windows.Forms.Button();
            this.lstAuthProfiles = new System.Windows.Forms.ListBox();
            this.tabUGSCommands = new System.Windows.Forms.TabControl();
            this.menuStripMainForm.SuspendLayout();
            this.statusStripMainForm.SuspendLayout();
            this.tabPageEnvironment.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPageAuth.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabUGSCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStripMainForm.Size = new System.Drawing.Size(914, 30);
            this.menuStripMainForm.TabIndex = 0;
            this.menuStripMainForm.Text = "MainFormMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemNewProject,
            this.tsMenuItemLoadProject,
            this.toolStripMenuItem2,
            this.tsMenuItemQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // tsMenuItemNewProject
            // 
            this.tsMenuItemNewProject.Name = "tsMenuItemNewProject";
            this.tsMenuItemNewProject.Size = new System.Drawing.Size(175, 26);
            this.tsMenuItemNewProject.Text = "&New Project";
            this.tsMenuItemNewProject.Click += new System.EventHandler(this.tsMenuItemNewProject_Click);
            // 
            // tsMenuItemLoadProject
            // 
            this.tsMenuItemLoadProject.Name = "tsMenuItemLoadProject";
            this.tsMenuItemLoadProject.Size = new System.Drawing.Size(175, 26);
            this.tsMenuItemLoadProject.Text = "&Load Project";
            this.tsMenuItemLoadProject.Click += new System.EventHandler(this.tsMenuItemLoadProject_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
            // 
            // tsMenuItemQuit
            // 
            this.tsMenuItemQuit.Name = "tsMenuItemQuit";
            this.tsMenuItemQuit.Size = new System.Drawing.Size(175, 26);
            this.tsMenuItemQuit.Text = "&Quit";
            this.tsMenuItemQuit.Click += new System.EventHandler(this.tsMenuItemQuit_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUGSCLIPathToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // setUGSCLIPathToolStripMenuItem
            // 
            this.setUGSCLIPathToolStripMenuItem.Name = "setUGSCLIPathToolStripMenuItem";
            this.setUGSCLIPathToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.setUGSCLIPathToolStripMenuItem.Text = "Set &UGS CLI Path";
            this.setUGSCLIPathToolStripMenuItem.Click += new System.EventHandler(this.setUGSCLIPathToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.versionToolStripMenuItem.Text = "&CLI Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 574);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripMainForm.Size = new System.Drawing.Size(914, 26);
            this.statusStripMainForm.TabIndex = 1;
            this.statusStripMainForm.Text = "MainFormStatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(15, 20);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(906, 506);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Scripts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(906, 506);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Modules";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageEnvironment
            // 
            this.tabPageEnvironment.Controls.Add(this.groupBox4);
            this.tabPageEnvironment.Location = new System.Drawing.Point(4, 29);
            this.tabPageEnvironment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEnvironment.Name = "tabPageEnvironment";
            this.tabPageEnvironment.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEnvironment.Size = new System.Drawing.Size(906, 506);
            this.tabPageEnvironment.TabIndex = 2;
            this.tabPageEnvironment.Text = "Environment Profiles";
            this.tabPageEnvironment.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtActiveEnvironmentName);
            this.groupBox4.Controls.Add(this.txtActiveEnvironmentId);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(375, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(527, 493);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Environment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Environment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Environment Id";
            // 
            // txtActiveEnvironmentName
            // 
            this.txtActiveEnvironmentName.Enabled = false;
            this.txtActiveEnvironmentName.Location = new System.Drawing.Point(17, 60);
            this.txtActiveEnvironmentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActiveEnvironmentName.Name = "txtActiveEnvironmentName";
            this.txtActiveEnvironmentName.Size = new System.Drawing.Size(502, 27);
            this.txtActiveEnvironmentName.TabIndex = 17;
            // 
            // txtActiveEnvironmentId
            // 
            this.txtActiveEnvironmentId.Enabled = false;
            this.txtActiveEnvironmentId.Location = new System.Drawing.Point(17, 135);
            this.txtActiveEnvironmentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActiveEnvironmentId.Name = "txtActiveEnvironmentId";
            this.txtActiveEnvironmentId.Size = new System.Drawing.Size(502, 27);
            this.txtActiveEnvironmentId.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCreateEnvironment);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtAddEnvironmentName);
            this.groupBox5.Controls.Add(this.txtAddEnvironmentId);
            this.groupBox5.Location = new System.Drawing.Point(-1, 196);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(528, 297);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Environment";
            // 
            // btnCreateEnvironment
            // 
            this.btnCreateEnvironment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateEnvironment.Location = new System.Drawing.Point(397, 252);
            this.btnCreateEnvironment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateEnvironment.Name = "btnCreateEnvironment";
            this.btnCreateEnvironment.Size = new System.Drawing.Size(125, 37);
            this.btnCreateEnvironment.TabIndex = 9;
            this.btnCreateEnvironment.Text = "&Create";
            this.btnCreateEnvironment.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Environment Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Environment Id";
            // 
            // txtAddEnvironmentName
            // 
            this.txtAddEnvironmentName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAddEnvironmentName.Location = new System.Drawing.Point(18, 64);
            this.txtAddEnvironmentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddEnvironmentName.Name = "txtAddEnvironmentName";
            this.txtAddEnvironmentName.Size = new System.Drawing.Size(503, 27);
            this.txtAddEnvironmentName.TabIndex = 12;
            // 
            // txtAddEnvironmentId
            // 
            this.txtAddEnvironmentId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAddEnvironmentId.Location = new System.Drawing.Point(18, 139);
            this.txtAddEnvironmentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddEnvironmentId.Name = "txtAddEnvironmentId";
            this.txtAddEnvironmentId.Size = new System.Drawing.Size(502, 27);
            this.txtAddEnvironmentId.TabIndex = 8;
            // 
            // tabPageAuth
            // 
            this.tabPageAuth.Controls.Add(this.groupBox2);
            this.tabPageAuth.Controls.Add(this.groupBox1);
            this.tabPageAuth.Location = new System.Drawing.Point(4, 29);
            this.tabPageAuth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAuth.Name = "tabPageAuth";
            this.tabPageAuth.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAuth.Size = new System.Drawing.Size(906, 511);
            this.tabPageAuth.TabIndex = 0;
            this.tabPageAuth.Text = "Auth Profiles";
            this.tabPageAuth.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblActiveAuthProfileFriendlyName);
            this.groupBox2.Controls.Add(this.lblActiveAuthProfileAccountKeyId);
            this.groupBox2.Controls.Add(this.txtActiveAuthProfileFriendlyName);
            this.groupBox2.Controls.Add(this.txtActiveAuthProfuleAccountKeyId);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(374, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(529, 503);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active Authentication Profile";
            // 
            // lblActiveAuthProfileFriendlyName
            // 
            this.lblActiveAuthProfileFriendlyName.AutoSize = true;
            this.lblActiveAuthProfileFriendlyName.Location = new System.Drawing.Point(17, 36);
            this.lblActiveAuthProfileFriendlyName.Name = "lblActiveAuthProfileFriendlyName";
            this.lblActiveAuthProfileFriendlyName.Size = new System.Drawing.Size(105, 20);
            this.lblActiveAuthProfileFriendlyName.TabIndex = 18;
            this.lblActiveAuthProfileFriendlyName.Text = "Friendly Name";
            // 
            // lblActiveAuthProfileAccountKeyId
            // 
            this.lblActiveAuthProfileAccountKeyId.AutoSize = true;
            this.lblActiveAuthProfileAccountKeyId.Location = new System.Drawing.Point(17, 111);
            this.lblActiveAuthProfileAccountKeyId.Name = "lblActiveAuthProfileAccountKeyId";
            this.lblActiveAuthProfileAccountKeyId.Size = new System.Drawing.Size(108, 20);
            this.lblActiveAuthProfileAccountKeyId.TabIndex = 15;
            this.lblActiveAuthProfileAccountKeyId.Text = "Account Key Id";
            // 
            // txtActiveAuthProfileFriendlyName
            // 
            this.txtActiveAuthProfileFriendlyName.Enabled = false;
            this.txtActiveAuthProfileFriendlyName.Location = new System.Drawing.Point(17, 60);
            this.txtActiveAuthProfileFriendlyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActiveAuthProfileFriendlyName.Name = "txtActiveAuthProfileFriendlyName";
            this.txtActiveAuthProfileFriendlyName.Size = new System.Drawing.Size(502, 27);
            this.txtActiveAuthProfileFriendlyName.TabIndex = 17;
            // 
            // txtActiveAuthProfuleAccountKeyId
            // 
            this.txtActiveAuthProfuleAccountKeyId.Enabled = false;
            this.txtActiveAuthProfuleAccountKeyId.Location = new System.Drawing.Point(17, 135);
            this.txtActiveAuthProfuleAccountKeyId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActiveAuthProfuleAccountKeyId.Name = "txtActiveAuthProfuleAccountKeyId";
            this.txtActiveAuthProfuleAccountKeyId.Size = new System.Drawing.Size(502, 27);
            this.txtActiveAuthProfuleAccountKeyId.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCreateAuthProfile);
            this.groupBox3.Controls.Add(this.lblAuthProfileFriendlyName);
            this.groupBox3.Controls.Add(this.lblAccountKeyId);
            this.groupBox3.Controls.Add(this.txtAddAuthProfileFriendlyName);
            this.groupBox3.Controls.Add(this.txtAddAuthProfileAccountKeyId);
            this.groupBox3.Controls.Add(this.lblAccountSecretKey);
            this.groupBox3.Controls.Add(this.txtAddAuthProfileAccountSecretKey);
            this.groupBox3.Location = new System.Drawing.Point(-1, 196);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(528, 297);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Profile";
            // 
            // btnCreateAuthProfile
            // 
            this.btnCreateAuthProfile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateAuthProfile.Location = new System.Drawing.Point(397, 247);
            this.btnCreateAuthProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateAuthProfile.Name = "btnCreateAuthProfile";
            this.btnCreateAuthProfile.Size = new System.Drawing.Size(125, 37);
            this.btnCreateAuthProfile.TabIndex = 9;
            this.btnCreateAuthProfile.Text = "&Create";
            this.btnCreateAuthProfile.UseVisualStyleBackColor = true;
            this.btnCreateAuthProfile.Click += new System.EventHandler(this.btnCreateAuthProfile_Click);
            // 
            // lblAuthProfileFriendlyName
            // 
            this.lblAuthProfileFriendlyName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAuthProfileFriendlyName.AutoSize = true;
            this.lblAuthProfileFriendlyName.Location = new System.Drawing.Point(18, 35);
            this.lblAuthProfileFriendlyName.Name = "lblAuthProfileFriendlyName";
            this.lblAuthProfileFriendlyName.Size = new System.Drawing.Size(105, 20);
            this.lblAuthProfileFriendlyName.TabIndex = 13;
            this.lblAuthProfileFriendlyName.Text = "Friendly Name";
            // 
            // lblAccountKeyId
            // 
            this.lblAccountKeyId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAccountKeyId.AutoSize = true;
            this.lblAccountKeyId.Location = new System.Drawing.Point(18, 109);
            this.lblAccountKeyId.Name = "lblAccountKeyId";
            this.lblAccountKeyId.Size = new System.Drawing.Size(108, 20);
            this.lblAccountKeyId.TabIndex = 7;
            this.lblAccountKeyId.Text = "Account Key Id";
            // 
            // txtAddAuthProfileFriendlyName
            // 
            this.txtAddAuthProfileFriendlyName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAddAuthProfileFriendlyName.Location = new System.Drawing.Point(18, 59);
            this.txtAddAuthProfileFriendlyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddAuthProfileFriendlyName.Name = "txtAddAuthProfileFriendlyName";
            this.txtAddAuthProfileFriendlyName.Size = new System.Drawing.Size(503, 27);
            this.txtAddAuthProfileFriendlyName.TabIndex = 12;
            // 
            // txtAddAuthProfileAccountKeyId
            // 
            this.txtAddAuthProfileAccountKeyId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAddAuthProfileAccountKeyId.Location = new System.Drawing.Point(18, 133);
            this.txtAddAuthProfileAccountKeyId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddAuthProfileAccountKeyId.Name = "txtAddAuthProfileAccountKeyId";
            this.txtAddAuthProfileAccountKeyId.Size = new System.Drawing.Size(502, 27);
            this.txtAddAuthProfileAccountKeyId.TabIndex = 8;
            // 
            // lblAccountSecretKey
            // 
            this.lblAccountSecretKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAccountSecretKey.AutoSize = true;
            this.lblAccountSecretKey.Location = new System.Drawing.Point(18, 184);
            this.lblAccountSecretKey.Name = "lblAccountSecretKey";
            this.lblAccountSecretKey.Size = new System.Drawing.Size(136, 20);
            this.lblAccountSecretKey.TabIndex = 11;
            this.lblAccountSecretKey.Text = "Account Secret Key";
            // 
            // txtAddAuthProfileAccountSecretKey
            // 
            this.txtAddAuthProfileAccountSecretKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAddAuthProfileAccountSecretKey.Location = new System.Drawing.Point(18, 208);
            this.txtAddAuthProfileAccountSecretKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddAuthProfileAccountSecretKey.Name = "txtAddAuthProfileAccountSecretKey";
            this.txtAddAuthProfileAccountSecretKey.Size = new System.Drawing.Size(502, 27);
            this.txtAddAuthProfileAccountSecretKey.TabIndex = 10;
            this.txtAddAuthProfileAccountSecretKey.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lstAuthProfiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(371, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saved Profiles";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditAuthProfile);
            this.panel1.Controls.Add(this.btnDeleteAuthProfile);
            this.panel1.Controls.Add(this.btnUseAuthProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 452);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnEditAuthProfile
            // 
            this.btnEditAuthProfile.Enabled = false;
            this.btnEditAuthProfile.Location = new System.Drawing.Point(125, 0);
            this.btnEditAuthProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditAuthProfile.Name = "btnEditAuthProfile";
            this.btnEditAuthProfile.Size = new System.Drawing.Size(114, 43);
            this.btnEditAuthProfile.TabIndex = 3;
            this.btnEditAuthProfile.Text = "&Edit Profile";
            this.btnEditAuthProfile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAuthProfile
            // 
            this.btnDeleteAuthProfile.Enabled = false;
            this.btnDeleteAuthProfile.Location = new System.Drawing.Point(246, 0);
            this.btnDeleteAuthProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAuthProfile.Name = "btnDeleteAuthProfile";
            this.btnDeleteAuthProfile.Size = new System.Drawing.Size(114, 43);
            this.btnDeleteAuthProfile.TabIndex = 2;
            this.btnDeleteAuthProfile.Text = "&Delete Profile";
            this.btnDeleteAuthProfile.UseVisualStyleBackColor = true;
            // 
            // btnUseAuthProfile
            // 
            this.btnUseAuthProfile.Enabled = false;
            this.btnUseAuthProfile.Location = new System.Drawing.Point(3, 0);
            this.btnUseAuthProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUseAuthProfile.Name = "btnUseAuthProfile";
            this.btnUseAuthProfile.Size = new System.Drawing.Size(114, 43);
            this.btnUseAuthProfile.TabIndex = 1;
            this.btnUseAuthProfile.Text = "&Use Profile";
            this.btnUseAuthProfile.UseVisualStyleBackColor = true;
            // 
            // lstAuthProfiles
            // 
            this.lstAuthProfiles.FormattingEnabled = true;
            this.lstAuthProfiles.ItemHeight = 20;
            this.lstAuthProfiles.Location = new System.Drawing.Point(7, 29);
            this.lstAuthProfiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAuthProfiles.Name = "lstAuthProfiles";
            this.lstAuthProfiles.Size = new System.Drawing.Size(356, 404);
            this.lstAuthProfiles.TabIndex = 0;
            // 
            // tabUGSCommands
            // 
            this.tabUGSCommands.Controls.Add(this.tabPageAuth);
            this.tabUGSCommands.Controls.Add(this.tabPageEnvironment);
            this.tabUGSCommands.Controls.Add(this.tabPage1);
            this.tabUGSCommands.Controls.Add(this.tabPage2);
            this.tabUGSCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUGSCommands.Location = new System.Drawing.Point(0, 30);
            this.tabUGSCommands.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUGSCommands.Name = "tabUGSCommands";
            this.tabUGSCommands.SelectedIndex = 0;
            this.tabUGSCommands.Size = new System.Drawing.Size(914, 544);
            this.tabUGSCommands.TabIndex = 2;
            // 
            // frmUGSCLIUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tabUGSCommands);
            this.Controls.Add(this.statusStripMainForm);
            this.Controls.Add(this.menuStripMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMainForm;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUGSCLIUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unofficial Unity Gaming Service CLI UI";
            this.Load += new System.EventHandler(this.frmUGSCLIUI_Load);
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
            this.tabPageEnvironment.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPageAuth.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabUGSCommands.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripMainForm;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tsMenuItemQuit;
        private StatusStrip statusStripMainForm;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem setUGSCLIPathToolStripMenuItem;
        private ToolStripMenuItem tsMenuItemNewProject;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem versionToolStripMenuItem;
        private ToolStripMenuItem tsMenuItemLoadProject;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPageEnvironment;
        private TabPage tabPageAuth;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnDeleteAuthProfile;
        private Button btnUseAuthProfile;
        private ListBox lstAuthProfiles;
        private TabControl tabUGSCommands;
        private Panel panel1;
        private Button btnEditAuthProfile;
        private Label lblAuthProfileFriendlyName;
        private TextBox txtAddAuthProfileFriendlyName;
        private Label lblAccountSecretKey;
        private TextBox txtAddAuthProfileAccountSecretKey;
        private Button btnCreateAuthProfile;
        private TextBox txtAddAuthProfileAccountKeyId;
        private Label lblAccountKeyId;
        private Label lblActiveAuthProfileFriendlyName;
        private Label lblActiveAuthProfileAccountKeyId;
        private TextBox txtActiveAuthProfileFriendlyName;
        private TextBox txtActiveAuthProfuleAccountKeyId;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private Label label2;
        private TextBox txtActiveEnvironmentName;
        private TextBox txtActiveEnvironmentId;
        private GroupBox groupBox5;
        private Button btnCreateEnvironment;
        private Label label3;
        private Label label4;
        private TextBox txtAddEnvironmentName;
        private TextBox txtAddEnvironmentId;
    }
}