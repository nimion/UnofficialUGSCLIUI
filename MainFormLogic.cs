using Newtonsoft.Json;

namespace UnofficialUGSCLIUI
{
    public class MainFormLogic
    {
        private const string APPLICATION_TITLE = "Unofficial Unity Gaming Service CLI UI";
        private frmUGSCLIUI _mainFormView = default;
        private ProjectData _projectData = null;
        private ProgramConfig _programConfig = null;

        public MainFormLogic(frmUGSCLIUI mainFormView)
        {
            _mainFormView = mainFormView;
            _mainFormView.OnMenuItemNewProjectClicked += HandleOnOpenCreateNewProjectModal;
            _mainFormView.OnMenuItemLoadProjectClicked += HandleOnOpenLoadProjectModal;
            _mainFormView.OnLocateCLILocation += HandleOnLocateCLILocation;
            _mainFormView.OnUseAuthProfileClicked += HandleOnUseAuthClicked;
            _mainFormView.OnEditAuthProfileClicked += HandleOnEditAuthProfileClicked;
            _mainFormView.OnDeleteAuthProfileClicked += HandleOnDeleteAuthProfileClicked;
            _mainFormView.OnCreateAuthProfileClicked += HandleOnCreateAuthProfileClicked;
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

        private async Task HandleOnOpenCreateNewProjectModal()
        {
            try
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
                        _projectData = new ProjectData(projectName, projectID);
                        File.WriteAllText(PathHelper.GetProjectDataPath(_projectData), JsonConvert.SerializeObject(_projectData));
                        await SetProjectId();
                        _mainFormView.Text = string.Concat(APPLICATION_TITLE, $" ({_projectData.ProjectName} | {_projectData.ProjectId})");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Creating Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task HandleOnOpenLoadProjectModal()
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
                    await SetProjectId();
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

        private async Task SetProjectId()
        {
            var response = await UGSCLIWrapper.SetProjectId(_programConfig.CLILocation, "b9d49470-eff5-4f03-ae2a-3c860953b272");
            if (response.Error == CLIWrapperResponse.ErrorCode.Success)
            {
                MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async Task HandleOnUseAuthClicked(int selectedEntryIndex)
        {
            throw new NotImplementedException();
        }

        private void HandleOnEditAuthProfileClicked(int selectedEntryIndex)
        {
            throw new NotImplementedException();
        }

        private void HandleOnDeleteAuthProfileClicked(int selectedEntryIndex)
        {
            throw new NotImplementedException();
        }

        private async Task HandleOnCreateAuthProfileClicked(string name, string key, string secret)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Friendly Name cannot be empty.", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(key) || UserInputValidators.IsValidId(key) == false)
                {
                    MessageBox.Show("Account Key is an invalid format.", "Account Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(secret) || secret.Length != 32)
                {
                    MessageBox.Show("Account Secret is an invalid format.", "Account Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProjectServiceAccount serviceAccount = new ProjectServiceAccount(name, key, secret);
                File.WriteAllText(PathHelper.GetProjectAuthSecretPath(_projectData, name), secret);
                File.WriteAllText(PathHelper.GetProjectDataPath(_projectData), JsonConvert.SerializeObject(_projectData));

                _projectData.AddProjectServiceAccount(serviceAccount);
                _mainFormView.PopulateAuthProfileList(_projectData);

                var result = MessageBox.Show($"Auth Profile Created! Login as {name}({key})?", "Auth Profile Created", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string path = PathHelper.GetProjectAuthSecretPath(_projectData, key);
                    await UGSCLIWrapper.SetAuthorization(_programConfig.CLILocation, key, path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}