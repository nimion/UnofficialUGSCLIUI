using Newtonsoft.Json;

namespace UnofficialUGSCLIUI
{
    public class MainFormLogic
    {
        private const string APPLICATION_TITLE = "Unofficial Unity Gaming Service CLI UI";
        private frmUGSCLIUI _mainFormView = default;
        private ProjectData _projectData = null;
        private AuthProfilePanelLogic _authProfilePanelLogic = null;
        private ProgramConfig _programConfig = null;

        public MainFormLogic(frmUGSCLIUI mainFormView)
        {
            _mainFormView = mainFormView;
            _mainFormView.OnMenuItemNewProjectClicked += HandleOnOpenCreateNewProjectModal;
            _mainFormView.OnMenuItemLoadProjectClicked += HandleOnOpenLoadProjectModal;
            _mainFormView.OnLocateCLILocation += HandleOnLocateCLILocation;
            _authProfilePanelLogic = new AuthProfilePanelLogic(mainFormView);
            bool success = CreateOrGetConfig();
            if (success)
                Application.Run(mainFormView);
            else
                Application.Exit();
        }

        private bool CreateOrGetConfig()
        {
            bool success = false;

            try
            {
                string configPath = PathHelper.GetConfigPath();
                FileInfo fileInfo = new FileInfo(configPath);
                if (fileInfo.Exists == false)
                {
                    _programConfig = new ProgramConfig();
                    var json = JsonConvert.SerializeObject(_programConfig);


                    if (!fileInfo.Directory.Exists)
                        fileInfo.Directory.Create();

                    File.WriteAllText(fileInfo.FullName, json);
                    success = true;
                }
                else
                {
                    var json = File.ReadAllText(configPath);
                    _programConfig = JsonConvert.DeserializeObject<ProgramConfig>(json);
                    success = true;
                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show($"{ex.Message}", "Project Config Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    success = false;
                }
            }

            return success;
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

        private void HandleOnLocateCLILocation()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = PathHelper.GetInitialDirectory();
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "Select Windows UGS File";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    _programConfig.SetCLILocation(path);
                    File.WriteAllText(PathHelper.GetConfigPath(), JsonConvert.SerializeObject(_programConfig));
                    MessageBox.Show($"CLI location has been saved!", "CLI Location Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Locating CLI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}