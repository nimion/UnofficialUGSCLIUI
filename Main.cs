namespace UnofficialUGSCLIUI
{
    public partial class frmUGSCLIUI : Form
    {
        public event Action OnMenuItemNewProjectClicked;
        public event Action OnMenuItemLoadProjectClicked;
        public event Action<int> OnUseAuthProfileClicked;
        public event Action<int> OnEditAuthProfileClicked;
        public event Action<int> OnDeleteAuthProfileClicked;

        public frmUGSCLIUI()
        {
            InitializeComponent();
        }

        private void tsMenuItemNewProject_Click(object sender, EventArgs e)
        {
            OnMenuItemNewProjectClicked?.Invoke();
        }

        private void tsMenuItemLoadProject_Click(object sender, EventArgs e)
        {
            OnMenuItemLoadProjectClicked?.Invoke();
        }

        private void tsMenuItemQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmUGSCLIUI_Load(object sender, EventArgs e)
        {

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}