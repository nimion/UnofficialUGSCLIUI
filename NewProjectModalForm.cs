namespace UnofficialUGSCLIUI
{
    public partial class NewProjectModalForm : Form
    {
        public NewProjectModalForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProjectId))
            {
                MessageBox.Show("Project Id cannot be empty.", "Missing Project Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(string.IsNullOrEmpty(ProjectName))
            {
                MessageBox.Show("Project Name cannot be empty.", "Missing Project Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ProjectId.Count() != 36 || !UserInputValidators.IsValidId(ProjectId))
            {
                MessageBox.Show("Project Id is invalid.", "Invalid Project Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!UserInputValidators.IsValidName(ProjectName))
            {
                MessageBox.Show("Project Name is invalid. Only 0-9, A-Z, a-z, _ and - are allowed.", "Invalid Project Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
