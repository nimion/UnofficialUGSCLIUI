namespace UnofficialUGSCLIUI
{
    public partial class frmUGSCLIUI : Form
    {
        public event Func<Task> OnMenuItemNewProjectClicked;
        public event Func<Task> OnMenuItemLoadProjectClicked;
        public event Func<Task, int> OnUseAuthProfileClicked;
        public event Action<int> OnEditAuthProfileClicked;
        public event Action<int> OnDeleteAuthProfileClicked;
        public event Action<string, string, string> OnCreateAuthProfileClicked;
        public event Action OnLocateCLILocation;
        public event Action OnGetCLIVersion;

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

        public void PopulateAuthProfileList(ProjectData projectData)
        {
            lstAuthProfiles.Items.Clear();
            if (projectData.HasServiceAccounts == false)
                return;

            foreach (var entry in projectData.ServiceAccounts)
            {
                lstAuthProfiles.Items.Add(entry.AccountKeyId);
            }
        }

        private void btnCreateAuthProfile_Click(object sender, EventArgs e)
        {
            OnCreateAuthProfileClicked?.Invoke(txtAddAuthProfileFriendlyName.Text, txtAddAuthProfileAccountKeyId.Text, txtAddAuthProfileAccountSecretKey.Text);
        }

        private void frmUGSCLIUI_Load(object sender, EventArgs e)
        {

        }

        private void setUGSCLIPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnLocateCLILocation?.Invoke();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnGetCLIVersion?.Invoke();
        }
    }
}