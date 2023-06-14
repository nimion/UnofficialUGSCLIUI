using Newtonsoft.Json;
using System.IO.Compression;

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
            _mainFormView.OnLoginClicked += HandleOnLoginClicked;
            _mainFormView.OnLogoutClicked += HandleOnClickLogout;
            _mainFormView.OnUseEnvironmentProfileClicked += HandleOnUseEnvironmentProfileClicked;
            _mainFormView.OnDeleteEnvironmentProfileClicked += HandleOnDeleteEnvironmentProfileClicked;
            _mainFormView.OnCreateEnvironmentProfileClicked += HandleOnOnCreateEnvironmentProfileClicked;
            _mainFormView.OnDeployClicked += HandleOnDeployClicked;
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
                        FileInfo fileInfo = new FileInfo(PathHelper.GetProjectDataPath(_projectData));
                        if (!fileInfo.Directory.Exists)
                            fileInfo.Directory.Create();

                        File.WriteAllText(PathHelper.GetProjectDataPath(_projectData), JsonConvert.SerializeObject(_projectData));
                        await SetProjectId(_projectData.ProjectId);
                        _mainFormView.Text = string.Concat(APPLICATION_TITLE, $" ({_projectData.ProjectName} | {_projectData.ProjectId})");
                        _mainFormView.ToggleTabPaneVisibility(true);
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
                    await SetProjectId(_projectData.ProjectId);
                    _mainFormView.Text = string.Concat(APPLICATION_TITLE, $" ({_projectData.ProjectName} | {_projectData.ProjectId})");
                    _mainFormView.PopulateEnvironmentProfileList(_projectData);
                    _mainFormView.ToggleTabPaneVisibility(true);
                    MessageBox.Show($"Project {_projectData.ProjectName} has been successfully loaded!", "Project Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Loading Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SetProjectId(string projectId)
        {
            var response = await UGSCLIWrapper.SetProjectId(_programConfig.CLILocation, projectId);
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

        private async Task HandleOnClickLogout()
        {
            try
            {
                await UGSCLIWrapper.Logout(_programConfig.CLILocation);
                _mainFormView.ToggleIsAuthenticate(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Logging Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task HandleOnLoginClicked()
        {
            try
            {
                var response = await UGSCLIWrapper.SetAuthorization(_programConfig.CLILocation);
                if (response.Error == CLIWrapperResponse.ErrorCode.Success)
                {
                    _mainFormView.ToggleIsAuthenticate(true);
                    MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Logging In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task HandleOnOnCreateEnvironmentProfileClicked(string name, string id)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Environment name is an invalid format.", "Environment Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(id) || UserInputValidators.IsValidId(id) == false)
                {
                    MessageBox.Show("Environment Id is an invalid format.", "Environment Id Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProjectEnvironment environment = new ProjectEnvironment(name, id);
                _projectData.AddProjectEnvironment(environment);
                File.WriteAllText(PathHelper.GetProjectDataPath(_projectData), JsonConvert.SerializeObject(_projectData));
                _mainFormView.PopulateEnvironmentProfileList(_projectData);

                var result = MessageBox.Show($"Environment Profile Created! Set {name}({id}) as the active environment?", "Environment Profile Created", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var response = await UGSCLIWrapper.SetActiveEnvironment(_programConfig.CLILocation, name);
                    if (response.Error == CLIWrapperResponse.ErrorCode.Success)
                    {
                        MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task HandleOnUseEnvironmentProfileClicked(int index)
        {
            try
            {
                var environment = _projectData.Environments[index];
                var response = await UGSCLIWrapper.SetActiveEnvironment(_programConfig.CLILocation, environment.EnvironmentName);
                if (response.Error == CLIWrapperResponse.ErrorCode.Success)
                {
                    MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleOnDeleteEnvironmentProfileClicked(int index)
        {
            try
            {
                _projectData.RemoveProjectEnvironment(index);
                _mainFormView.PopulateEnvironmentProfileList(_projectData);
                File.WriteAllText(PathHelper.GetProjectDataPath(_projectData), JsonConvert.SerializeObject(_projectData));
                MessageBox.Show("Environment Removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task HandleOnDeployClicked()
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.InitialDirectory = PathHelper.GetInitialDirectory();
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string zipDirectory = folderBrowserDialog.SelectedPath;
                    DirectoryInfo directoryToZip = new DirectoryInfo(zipDirectory);
                    DirectoryInfo destinationDirectory = new DirectoryInfo(Path.Combine(directoryToZip.Parent.FullName, "Deployment"));
                    
                    if(destinationDirectory.Exists ==false)
                        destinationDirectory.Create();

                    FileInfo zipFile = new FileInfo(Path.Combine(destinationDirectory.FullName,"zipTest.ccm"));
                    if (zipFile.Exists)
                    {
                        zipFile.Delete();
                    }

                    ZipFile.CreateFromDirectory(directoryToZip.FullName, zipFile.FullName);

                    var response = await UGSCLIWrapper.DeployModule(_programConfig.CLILocation, zipFile.FullName);
                    if (response.Error == CLIWrapperResponse.ErrorCode.Success)
                    {
                        MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}