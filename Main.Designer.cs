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
            this.tabPageAuth = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblActiveAuthProfileFriendlyName = new System.Windows.Forms.Label();
            this.lblActiveAuthProfileAccountKeyId = new System.Windows.Forms.Label();
            this.txtActiveAuthProfileFriendlyName = new System.Windows.Forms.TextBox();
            this.txtActiveAuthProfuleAccountKeyId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblAuthProfileFriendlyName = new System.Windows.Forms.Label();
            this.lblAccountKeyId = new System.Windows.Forms.Label();
            this.txtAuthProfileFriendlyName = new System.Windows.Forms.TextBox();
            this.txtAuthProfileAccountKeyId = new System.Windows.Forms.TextBox();
            this.lblAccountSecretKey = new System.Windows.Forms.Label();
            this.txtAuthProfileAccountSecretKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditAuthProfile = new System.Windows.Forms.Button();
            this.btnDeleteAuthProfile = new System.Windows.Forms.Button();
            this.btnUseAuthProfile = new System.Windows.Forms.Button();
            this.lstAuthProfiles = new System.Windows.Forms.ListBox();
            this.tabUGSCommands = new System.Windows.Forms.TabControl();
            this.menuStripMainForm.SuspendLayout();
            this.statusStripMainForm.SuspendLayout();
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
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(800, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // tsMenuItemNewProject
            // 
            this.tsMenuItemNewProject.Name = "tsMenuItemNewProject";
            this.tsMenuItemNewProject.Size = new System.Drawing.Size(140, 22);
            this.tsMenuItemNewProject.Text = "&New Project";
            this.tsMenuItemNewProject.Click += new System.EventHandler(this.tsMenuItemNewProject_Click);
            // 
            // tsMenuItemLoadProject
            // 
            this.tsMenuItemLoadProject.Name = "tsMenuItemLoadProject";
            this.tsMenuItemLoadProject.Size = new System.Drawing.Size(140, 22);
            this.tsMenuItemLoadProject.Text = "&Load Project";
            this.tsMenuItemLoadProject.Click += new System.EventHandler(this.tsMenuItemLoadProject_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(137, 6);
            // 
            // tsMenuItemQuit
            // 
            this.tsMenuItemQuit.Name = "tsMenuItemQuit";
            this.tsMenuItemQuit.Size = new System.Drawing.Size(140, 22);
            this.tsMenuItemQuit.Text = "&Quit";
            this.tsMenuItemQuit.Click += new System.EventHandler(this.tsMenuItemQuit_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUGSCLIPathToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // setUGSCLIPathToolStripMenuItem
            // 
            this.setUGSCLIPathToolStripMenuItem.Name = "setUGSCLIPathToolStripMenuItem";
            this.setUGSCLIPathToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.setUGSCLIPathToolStripMenuItem.Text = "Set &UGS CLI Path";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.versionToolStripMenuItem.Text = "&CLI Version";
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 428);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(800, 22);
            this.statusStripMainForm.TabIndex = 1;
            this.statusStripMainForm.Text = "MainFormStatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 376);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Scripts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 376);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Modules";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageEnvironment
            // 
            this.tabPageEnvironment.Location = new System.Drawing.Point(4, 24);
            this.tabPageEnvironment.Name = "tabPageEnvironment";
            this.tabPageEnvironment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnvironment.Size = new System.Drawing.Size(792, 376);
            this.tabPageEnvironment.TabIndex = 2;
            this.tabPageEnvironment.Text = "Environment Profiles";
            this.tabPageEnvironment.UseVisualStyleBackColor = true;
            // 
            // tabPageAuth
            // 
            this.tabPageAuth.Controls.Add(this.groupBox2);
            this.tabPageAuth.Controls.Add(this.groupBox1);
            this.tabPageAuth.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuth.Name = "tabPageAuth";
            this.tabPageAuth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuth.Size = new System.Drawing.Size(792, 376);
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
            this.groupBox2.Location = new System.Drawing.Point(328, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 370);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active Authentication Profile";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblActiveAuthProfileFriendlyName
            // 
            this.lblActiveAuthProfileFriendlyName.AutoSize = true;
            this.lblActiveAuthProfileFriendlyName.Location = new System.Drawing.Point(15, 27);
            this.lblActiveAuthProfileFriendlyName.Name = "lblActiveAuthProfileFriendlyName";
            this.lblActiveAuthProfileFriendlyName.Size = new System.Drawing.Size(84, 15);
            this.lblActiveAuthProfileFriendlyName.TabIndex = 18;
            this.lblActiveAuthProfileFriendlyName.Text = "Friendly Name";
            // 
            // lblActiveAuthProfileAccountKeyId
            // 
            this.lblActiveAuthProfileAccountKeyId.AutoSize = true;
            this.lblActiveAuthProfileAccountKeyId.Location = new System.Drawing.Point(15, 83);
            this.lblActiveAuthProfileAccountKeyId.Name = "lblActiveAuthProfileAccountKeyId";
            this.lblActiveAuthProfileAccountKeyId.Size = new System.Drawing.Size(87, 15);
            this.lblActiveAuthProfileAccountKeyId.TabIndex = 15;
            this.lblActiveAuthProfileAccountKeyId.Text = "Account Key Id";
            // 
            // txtActiveAuthProfileFriendlyName
            // 
            this.txtActiveAuthProfileFriendlyName.Enabled = false;
            this.txtActiveAuthProfileFriendlyName.Location = new System.Drawing.Point(15, 45);
            this.txtActiveAuthProfileFriendlyName.Name = "txtActiveAuthProfileFriendlyName";
            this.txtActiveAuthProfileFriendlyName.Size = new System.Drawing.Size(440, 23);
            this.txtActiveAuthProfileFriendlyName.TabIndex = 17;
            // 
            // txtActiveAuthProfuleAccountKeyId
            // 
            this.txtActiveAuthProfuleAccountKeyId.Enabled = false;
            this.txtActiveAuthProfuleAccountKeyId.Location = new System.Drawing.Point(15, 101);
            this.txtActiveAuthProfuleAccountKeyId.Name = "txtActiveAuthProfuleAccountKeyId";
            this.txtActiveAuthProfuleAccountKeyId.Size = new System.Drawing.Size(440, 23);
            this.txtActiveAuthProfuleAccountKeyId.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Controls.Add(this.lblAuthProfileFriendlyName);
            this.groupBox3.Controls.Add(this.lblAccountKeyId);
            this.groupBox3.Controls.Add(this.txtAuthProfileFriendlyName);
            this.groupBox3.Controls.Add(this.txtAuthProfileAccountKeyId);
            this.groupBox3.Controls.Add(this.lblAccountSecretKey);
            this.groupBox3.Controls.Add(this.txtAuthProfileAccountSecretKey);
            this.groupBox3.Location = new System.Drawing.Point(-1, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 223);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Profile";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.Location = new System.Drawing.Point(347, 185);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 28);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // lblAuthProfileFriendlyName
            // 
            this.lblAuthProfileFriendlyName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAuthProfileFriendlyName.AutoSize = true;
            this.lblAuthProfileFriendlyName.Location = new System.Drawing.Point(16, 26);
            this.lblAuthProfileFriendlyName.Name = "lblAuthProfileFriendlyName";
            this.lblAuthProfileFriendlyName.Size = new System.Drawing.Size(84, 15);
            this.lblAuthProfileFriendlyName.TabIndex = 13;
            this.lblAuthProfileFriendlyName.Text = "Friendly Name";
            // 
            // lblAccountKeyId
            // 
            this.lblAccountKeyId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAccountKeyId.AutoSize = true;
            this.lblAccountKeyId.Location = new System.Drawing.Point(16, 82);
            this.lblAccountKeyId.Name = "lblAccountKeyId";
            this.lblAccountKeyId.Size = new System.Drawing.Size(87, 15);
            this.lblAccountKeyId.TabIndex = 7;
            this.lblAccountKeyId.Text = "Account Key Id";
            // 
            // txtAuthProfileFriendlyName
            // 
            this.txtAuthProfileFriendlyName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAuthProfileFriendlyName.Location = new System.Drawing.Point(16, 44);
            this.txtAuthProfileFriendlyName.Name = "txtAuthProfileFriendlyName";
            this.txtAuthProfileFriendlyName.Size = new System.Drawing.Size(441, 23);
            this.txtAuthProfileFriendlyName.TabIndex = 12;
            // 
            // txtAuthProfileAccountKeyId
            // 
            this.txtAuthProfileAccountKeyId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAuthProfileAccountKeyId.Location = new System.Drawing.Point(16, 100);
            this.txtAuthProfileAccountKeyId.Name = "txtAuthProfileAccountKeyId";
            this.txtAuthProfileAccountKeyId.Size = new System.Drawing.Size(440, 23);
            this.txtAuthProfileAccountKeyId.TabIndex = 8;
            // 
            // lblAccountSecretKey
            // 
            this.lblAccountSecretKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAccountSecretKey.AutoSize = true;
            this.lblAccountSecretKey.Location = new System.Drawing.Point(16, 138);
            this.lblAccountSecretKey.Name = "lblAccountSecretKey";
            this.lblAccountSecretKey.Size = new System.Drawing.Size(109, 15);
            this.lblAccountSecretKey.TabIndex = 11;
            this.lblAccountSecretKey.Text = "Account Secret Key";
            // 
            // txtAuthProfileAccountSecretKey
            // 
            this.txtAuthProfileAccountSecretKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAuthProfileAccountSecretKey.Location = new System.Drawing.Point(16, 156);
            this.txtAuthProfileAccountSecretKey.Name = "txtAuthProfileAccountSecretKey";
            this.txtAuthProfileAccountSecretKey.Size = new System.Drawing.Size(440, 23);
            this.txtAuthProfileAccountSecretKey.TabIndex = 10;
            this.txtAuthProfileAccountSecretKey.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lstAuthProfiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 370);
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
            this.panel1.Location = new System.Drawing.Point(3, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnEditAuthProfile
            // 
            this.btnEditAuthProfile.Enabled = false;
            this.btnEditAuthProfile.Location = new System.Drawing.Point(109, 0);
            this.btnEditAuthProfile.Name = "btnEditAuthProfile";
            this.btnEditAuthProfile.Size = new System.Drawing.Size(100, 32);
            this.btnEditAuthProfile.TabIndex = 3;
            this.btnEditAuthProfile.Text = "Edit Profile";
            this.btnEditAuthProfile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAuthProfile
            // 
            this.btnDeleteAuthProfile.Enabled = false;
            this.btnDeleteAuthProfile.Location = new System.Drawing.Point(215, 0);
            this.btnDeleteAuthProfile.Name = "btnDeleteAuthProfile";
            this.btnDeleteAuthProfile.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteAuthProfile.TabIndex = 2;
            this.btnDeleteAuthProfile.Text = "Delete Auth";
            this.btnDeleteAuthProfile.UseVisualStyleBackColor = true;
            // 
            // btnUseAuthProfile
            // 
            this.btnUseAuthProfile.Enabled = false;
            this.btnUseAuthProfile.Location = new System.Drawing.Point(3, 0);
            this.btnUseAuthProfile.Name = "btnUseAuthProfile";
            this.btnUseAuthProfile.Size = new System.Drawing.Size(100, 32);
            this.btnUseAuthProfile.TabIndex = 1;
            this.btnUseAuthProfile.Text = "Use Profile";
            this.btnUseAuthProfile.UseVisualStyleBackColor = true;
            // 
            // lstAuthProfiles
            // 
            this.lstAuthProfiles.FormattingEnabled = true;
            this.lstAuthProfiles.ItemHeight = 15;
            this.lstAuthProfiles.Location = new System.Drawing.Point(6, 22);
            this.lstAuthProfiles.Name = "lstAuthProfiles";
            this.lstAuthProfiles.Size = new System.Drawing.Size(312, 304);
            this.lstAuthProfiles.TabIndex = 0;
            // 
            // tabUGSCommands
            // 
            this.tabUGSCommands.Controls.Add(this.tabPageAuth);
            this.tabUGSCommands.Controls.Add(this.tabPageEnvironment);
            this.tabUGSCommands.Controls.Add(this.tabPage1);
            this.tabUGSCommands.Controls.Add(this.tabPage2);
            this.tabUGSCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUGSCommands.Location = new System.Drawing.Point(0, 24);
            this.tabUGSCommands.Name = "tabUGSCommands";
            this.tabUGSCommands.SelectedIndex = 0;
            this.tabUGSCommands.Size = new System.Drawing.Size(800, 404);
            this.tabUGSCommands.TabIndex = 2;
            // 
            // frmUGSCLIUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabUGSCommands);
            this.Controls.Add(this.statusStripMainForm);
            this.Controls.Add(this.menuStripMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMainForm;
            this.Name = "frmUGSCLIUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unofficial Unity Gaming Service CLI UI";
            this.Load += new System.EventHandler(this.frmUGSCLIUI_Load);
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
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
        private TextBox txtAuthProfileFriendlyName;
        private Label lblAccountSecretKey;
        private TextBox txtAuthProfileAccountSecretKey;
        private Button btnCreate;
        private TextBox txtAuthProfileAccountKeyId;
        private Label lblAccountKeyId;
        private Label lblActiveAuthProfileFriendlyName;
        private Label lblActiveAuthProfileAccountKeyId;
        private TextBox txtActiveAuthProfileFriendlyName;
        private TextBox txtActiveAuthProfuleAccountKeyId;
        private GroupBox groupBox3;
    }
}