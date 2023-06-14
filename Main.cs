namespace UnofficialUGSCLIUI
{
    public partial class frmUGSCLIUI : Form
    {
        public event Func<Task> OnMenuItemNewProjectClicked;
        public event Func<Task> OnMenuItemLoadProjectClicked;
        public event Func<Task> OnLoginClicked;
        public event Func<Task> OnLogoutClicked;
        public event Func<int, Task> OnUseEnvironmentProfileClicked;
        public event Action<int> OnDeleteEnvironmentProfileClicked;
        public event Func<string, string, Task> OnCreateEnvironmentProfileClicked;
        public event Action OnLocateCLILocation;
        public event Action OnGetCLIVersion;
        public event Func<string, Task> OnDeployClicked;

        public frmUGSCLIUI()
        {
            InitializeComponent();
        }

        private async void tsMenuItemNewProject_Click(object sender, EventArgs e)
        {
            await OnMenuItemNewProjectClicked?.Invoke();
        }

        private async void tsMenuItemLoadProject_Click(object sender, EventArgs e)
        {
            await OnMenuItemLoadProjectClicked?.Invoke();
        }

        private void tsMenuItemQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void PopulateEnvironmentProfileList(ProjectData projectData)
        {
            lstEnvironments.Items.Clear();
            foreach (var entry in projectData.Environments)
            {
                lstEnvironments.Items.Add(entry.EnvironmentName);
            }
        }

        public void ToggleTabPaneVisibility(bool isVisible)
        {
            tabUGSCommands.Visible = isVisible;
        }

        public void ToggleIsAuthenticate(bool value)
        {
            if (value)
            {
                lblIsAuthenticated.ForeColor = Color.DodgerBlue;
                lblIsAuthenticated.Text = "Authenticated";
            }
            else
            {
                lblIsAuthenticated.ForeColor = Color.Red;
                lblIsAuthenticated.Text = "Logged Out";
            }
        }

        private async void frmUGSCLIUI_Load(object sender, EventArgs e)
        {
            await OnLogoutClicked?.Invoke();
        }

        private void setUGSCLIPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnLocateCLILocation?.Invoke();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnGetCLIVersion?.Invoke();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await OnLoginClicked?.Invoke();
        }

        private async void btnCreateEnvironment_Click(object sender, EventArgs e)
        {
            await OnCreateEnvironmentProfileClicked?.Invoke(txtAddEnvironmentName.Text, txtAddEnvironmentId.Text);
        }

        private void lstEnvironments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstEnvironments.SelectedIndex;
            if (index == -1)
            {
                btnEnvironmentDelete.Enabled = false;
                btnUseSelectedEnvironment.Enabled = false;
            }
            else
            {
                btnEnvironmentDelete.Enabled = true;
                btnUseSelectedEnvironment.Enabled = true;
            }
        }

        private async void btnUseSelectedEnvironment_Click(object sender, EventArgs e)
        {
            int index = lstEnvironments.SelectedIndex;
            await OnUseEnvironmentProfileClicked?.Invoke(index);
            lstEnvironments.SelectedIndex = -1;
        }

        private void btnEnvironmentDelete_Click(object sender, EventArgs e)
        {
            string profileName = (string)lstEnvironments.SelectedItem;
            int index = lstEnvironments.SelectedIndex;
            var result = MessageBox.Show($"Are you sure you wish to delete {profileName}?", "Delete Environment Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                OnDeleteEnvironmentProfileClicked?.Invoke(index);
            }

            lstEnvironments.SelectedIndex = -1;
        }

        private async void btnDeploy_Click(object sender, EventArgs e)
        {
            await OnDeployClicked?.Invoke(txtModuleName.Text);
        }
    }
}