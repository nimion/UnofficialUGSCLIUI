using Newtonsoft.Json;

namespace UnofficialUGSCLIUI
{
    public class ProjectData
    {
        public string ProjectName { get; }
        public string ProjectId { get; }
        public IReadOnlyList<ProjectEnvironment> Environments => _projectEnvironments;
        public IReadOnlyList<ProjectServiceAccount> ServiceAccounts => _projectServiceAccounts;
        [JsonIgnore]
        public bool HasServiceAccounts => _projectServiceAccounts != null && _projectServiceAccounts.Count > 0;
        [JsonIgnore]
        public ProjectEnvironment ActiveEnvironment => _activeEnvironment;
        [JsonIgnore]
        public ProjectServiceAccount ActiveServiceAccount => _activeServiceAccount;

        private List<ProjectEnvironment> _projectEnvironments { get; }
        private List<ProjectServiceAccount> _projectServiceAccounts { get; }
        [JsonIgnore]
        private ProjectEnvironment _activeEnvironment = null;
        [JsonIgnore]
        private ProjectServiceAccount _activeServiceAccount = null;

        [JsonConstructor]
        public ProjectData(string projectName, string projectId, List<ProjectEnvironment> projectEnvironments, List<ProjectServiceAccount> projectServiceAccounts)
        {
            ProjectName = projectName;
            ProjectId = projectId;
            _projectEnvironments = projectEnvironments;
            _projectServiceAccounts = projectServiceAccounts;
        }

        public ProjectData(string projectName, string projectId)
        {
            ProjectName = projectName; 
            ProjectId = projectId;
            _projectEnvironments = new List<ProjectEnvironment>();
            _projectServiceAccounts = new List<ProjectServiceAccount>();
        }

        public AddProjectSubDataResult<ProjectEnvironment> AddProjectEnvironment(ProjectEnvironment data)
        {
            if(_projectEnvironments.FirstOrDefault(p=>p.EnvironmentId == data.EnvironmentId) != default)
            {
                return new AddProjectSubDataResult<ProjectEnvironment>($"Environment Id {data.EnvironmentId} ({data.EnvironmentName}) already exsists.");
            }

            _projectEnvironments.Add(data);
            return new AddProjectSubDataResult<ProjectEnvironment>(data);
        }

        public AddProjectSubDataResult<ProjectServiceAccount> AddProjectServiceAccount(ProjectServiceAccount data)
        {
            if (_projectServiceAccounts.FirstOrDefault(p => p.AccountKeyId == data.AccountKeyId) != default)
            {
                return new AddProjectSubDataResult<ProjectServiceAccount>($"Service Account Id {data.AccountKeyId} already exsists.");
            }

            _projectServiceAccounts.Add(data);
            return new AddProjectSubDataResult<ProjectServiceAccount>(data);
        }
    }
}