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
            this.btnDeploy = new System.Windows.Forms.Button();
            this.tabPageEnvironment = new System.Windows.Forms.TabPage();
            this.btnEnvironmentDelete = new System.Windows.Forms.Button();
            this.btnUseSelectedEnvironment = new System.Windows.Forms.Button();
            this.lstEnvironments = new System.Windows.Forms.ListBox();
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblIsAuthenticated = new System.Windows.Forms.Label();
            this.tabUGSCommands = new System.Windows.Forms.TabControl();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.menuStripMainForm.SuspendLayout();
            this.statusStripMainForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageEnvironment.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPageAuth.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.setUGSCLIPathToolStripMenuItem.Click += new System.EventHandler(this.setUGSCLIPathToolStripMenuItem_Click);
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
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.tabPage1.Controls.Add(this.txtModuleName);
            this.tabPage1.Controls.Add(this.lblFileName);
            this.tabPage1.Controls.Add(this.btnDeploy);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 376);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Modules";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeploy
            // 
            this.btnDeploy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeploy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeploy.Location = new System.Drawing.Point(102, 268);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(595, 102);
            this.btnDeploy.TabIndex = 0;
            this.btnDeploy.Text = "Deploy";
            this.btnDeploy.UseVisualStyleBackColor = true;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // tabPageEnvironment
            // 
            this.tabPageEnvironment.Controls.Add(this.btnEnvironmentDelete);
            this.tabPageEnvironment.Controls.Add(this.btnUseSelectedEnvironment);
            this.tabPageEnvironment.Controls.Add(this.lstEnvironments);
            this.tabPageEnvironment.Controls.Add(this.groupBox4);
            this.tabPageEnvironment.Location = new System.Drawing.Point(4, 24);
            this.tabPageEnvironment.Name = "tabPageEnvironment";
            this.tabPageEnvironment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnvironment.Size = new System.Drawing.Size(792, 376);
            this.tabPageEnvironment.TabIndex = 2;
            this.tabPageEnvironment.Text = "Environment Profiles";
            this.tabPageEnvironment.UseVisualStyleBackColor = true;
            // 
            // btnEnvironmentDelete
            // 
            this.btnEnvironmentDelete.Location = new System.Drawing.Point(216, 325);
            this.btnEnvironmentDelete.Name = "btnEnvironmentDelete";
            this.btnEnvironmentDelete.Size = new System.Drawing.Size(104, 42);
            this.btnEnvironmentDelete.TabIndex = 6;
            this.btnEnvironmentDelete.Text = "&Delete";
            this.btnEnvironmentDelete.UseVisualStyleBackColor = true;
            this.btnEnvironmentDelete.Click += new System.EventHandler(this.btnEnvironmentDelete_Click);
            // 
            // btnUseSelectedEnvironment
            // 
            this.btnUseSelectedEnvironment.Location = new System.Drawing.Point(8, 325);
            this.btnUseSelectedEnvironment.Name = "btnUseSelectedEnvironment";
            this.btnUseSelectedEnvironment.Size = new System.Drawing.Size(202, 42);
            this.btnUseSelectedEnvironment.TabIndex = 4;
            this.btnUseSelectedEnvironment.Text = "&Use";
            this.btnUseSelectedEnvironment.UseVisualStyleBackColor = true;
            this.btnUseSelectedEnvironment.Click += new System.EventHandler(this.btnUseSelectedEnvironment_Click);
            // 
            // lstEnvironments
            // 
            this.lstEnvironments.FormattingEnabled = true;
            this.lstEnvironments.ItemHeight = 15;
            this.lstEnvironments.Location = new System.Drawing.Point(0, 11);
            this.lstEnvironments.Name = "lstEnvironments";
            this.lstEnvironments.Size = new System.Drawing.Size(321, 304);
            this.lstEnvironments.TabIndex = 3;
            this.lstEnvironments.SelectedIndexChanged += new System.EventHandler(this.lstEnvironments_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtActiveEnvironmentName);
            this.groupBox4.Controls.Add(this.txtActiveEnvironmentId);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(328, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 370);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Environment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Environment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Environment Id";
            // 
            // txtActiveEnvironmentName
            // 
            this.txtActiveEnvironmentName.Enabled = false;
            this.txtActiveEnvironmentName.Location = new System.Drawing.Point(15, 45);
            this.txtActiveEnvironmentName.Name = "txtActiveEnvironmentName";
            this.txtActiveEnvironmentName.Size = new System.Drawing.Size(440, 23);
            this.txtActiveEnvironmentName.TabIndex = 17;
            // 
            // txtActiveEnvironmentId
            // 
            this.txtActiveEnvironmentId.Enabled = false;
            this.txtActiveEnvironmentId.Location = new System.Drawing.Point(15, 101);
            this.txtActiveEnvironmentId.Name = "txtActiveEnvironmentId";
            this.txtActiveEnvironmentId.Size = new System.Drawing.Size(440, 23);
            this.txtActiveEnvironmentId.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCreateEnvironment);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtAddEnvironmentName);
            this.groupBox5.Controls.Add(this.txtAddEnvironmentId);
            this.groupBox5.Location = new System.Drawing.Point(-1, 147);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(462, 223);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Environment";
            // 
            // btnCreateEnvironment
            // 
            this.btnCreateEnvironment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateEnvironment.Location = new System.Drawing.Point(347, 189);
            this.btnCreateEnvironment.Name = "btnCreateEnvironment";
            this.btnCreateEnvironment.Size = new System.Drawing.Size(109, 28);
            this.btnCreateEnvironment.TabIndex = 9;
            this.btnCreateEnvironment.Text = "&Create";
            this.btnCreateEnvironment.UseVisualStyleBackColor = true;
            this.btnCreateEnvironment.Click += new System.EventHandler(this.btnCreateEnvironment_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Environment Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Environment Id";
            // 
            // txtAddEnvironmentName
            // 
            this.txtAddEnvironmentName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAddEnvironmentName.Location = new System.Drawing.Point(16, 48);
            this.txtAddEnvironmentName.Name = "txtAddEnvironmentName";
            this.txtAddEnvironmentName.Size = new System.Drawing.Size(441, 23);
            this.txtAddEnvironmentName.TabIndex = 12;
            // 
            // txtAddEnvironmentId
            // 
            this.txtAddEnvironmentId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAddEnvironmentId.Location = new System.Drawing.Point(16, 104);
            this.txtAddEnvironmentId.Name = "txtAddEnvironmentId";
            this.txtAddEnvironmentId.Size = new System.Drawing.Size(440, 23);
            this.txtAddEnvironmentId.TabIndex = 8;
            // 
            // tabPageAuth
            // 
            this.tabPageAuth.Controls.Add(this.groupBox2);
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
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.lblIsAuthenticated);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 370);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active Authentication Profile";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(6, 245);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(774, 119);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblIsAuthenticated
            // 
            this.lblIsAuthenticated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIsAuthenticated.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIsAuthenticated.ForeColor = System.Drawing.Color.Black;
            this.lblIsAuthenticated.Location = new System.Drawing.Point(0, 19);
            this.lblIsAuthenticated.Name = "lblIsAuthenticated";
            this.lblIsAuthenticated.Size = new System.Drawing.Size(786, 223);
            this.lblIsAuthenticated.TabIndex = 15;
            this.lblIsAuthenticated.Text = "Unauthenticated";
            this.lblIsAuthenticated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tabUGSCommands.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(180, 116);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(83, 15);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Module Name";
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(180, 134);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(420, 23);
            this.txtModuleName.TabIndex = 2;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageEnvironment.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPageAuth.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private TabControl tabUGSCommands;
        private Label lblIsAuthenticated;
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
        private Button btnLogin;
        private ListBox lstEnvironments;
        private Button btnEnvironmentDelete;
        private Button btnUseSelectedEnvironment;
        private Button btnDeploy;
        private TextBox txtModuleName;
        private Label lblFileName;
    }
}