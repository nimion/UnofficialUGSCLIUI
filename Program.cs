using Newtonsoft.Json;

namespace UnofficialUGSCLIUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var mainFormView = new frmUGSCLIUI();
            _ = new MainFormLogic(mainFormView);
            Application.Run(mainFormView);
        }
    }

    public class MainFormLogic
    {
        private const string APPLICATION_TITLE = "Unofficial Unity Gaming Service CLI UI";
        private frmUGSCLIUI _mainFormView = default;
        private ProjectData _projectData = null;
        private AuthProfilePanelLogic _authProfilePanelLogic = null;

        public MainFormLogic(frmUGSCLIUI mainFormView)
        {
            _mainFormView = mainFormView;
            _mainFormView.OnMenuItemNewProjectClicked += HandleOnOpenCreateNewProjectModal;
            _mainFormView.OnMenuItemLoadProjectClicked += HandleOnOpenLoadProjectModal;
            _authProfilePanelLogic = new AuthProfilePanelLogic(mainFormView);
        }

        private void HandleOnOpenCreateNewProjectModal()
        {
            NewProjectModalForm newProjectForm = new NewProjectModalForm();
            DialogResult result = newProjectForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string projectID = newProjectForm.ProjectId;
                string projectName = newProjectForm.ProjectName;
                if (Directory.Exists(projectName))
                {
                    MessageBox.Show($"A project already exists with the name {projectName}", "Project Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        _projectData = new ProjectData(projectName, projectID);
                        var directoryInfo = Directory.CreateDirectory(PathHelper.GetProjectPath(_projectData));
                        File.WriteAllText(PathHelper.GetProjectDataPath(_projectData), JsonConvert.SerializeObject(_projectData));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error Creating Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void HandleOnOpenLoadProjectModal()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = PathHelper.GetInitialDirectory();
                openFileDialog.Filter = "Json Files (*.json)|*.json";
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "Select Project File";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string jsonData = File.ReadAllText(path);
                    _projectData = JsonConvert.DeserializeObject<ProjectData>(jsonData);
                    _mainFormView.Text = string.Concat(APPLICATION_TITLE, $" ({_projectData.ProjectName} | {_projectData.ProjectId})");
                    _mainFormView.PopulateAuthProfileList(_projectData);
                    MessageBox.Show($"Project {_projectData.ProjectName} has been successfully loaded!", "Project Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Loading Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class AuthProfilePanelLogic
    {
        private frmUGSCLIUI _mainFormView = null;

        public AuthProfilePanelLogic(frmUGSCLIUI mainFormView)
        {
            _mainFormView = mainFormView;
            _mainFormView.OnUseAuthProfileClicked += HandleOnUseAuthClicked;
            _mainFormView.OnEditAuthProfileClicked += HandleOnEditAuthProfileClicked;
            _mainFormView.OnDeleteAuthProfileClicked += HandleOnDeleteAuthProfileClicked;
        }

        private void HandleOnUseAuthClicked(int selectedEntryIndex)
        {

        }

        private void HandleOnEditAuthProfileClicked(int selectedEntryIndex)
        {

        }

        private void HandleOnDeleteAuthProfileClicked(int selectedEntryIndex)
        {

        }
    }
}