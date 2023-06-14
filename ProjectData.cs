using Newtonsoft.Json;

namespace UnofficialUGSCLIUI
{
    public class ProjectData
    {
        public string ProjectName { get; }
        public string ProjectId { get; }
        [JsonIgnore]
        public IReadOnlyList<ProjectEnvironment> Environments => _projectEnvironments;
        [JsonIgnore]
        public ProjectEnvironment ActiveEnvironment => _activeEnvironment;
        [JsonIgnore]
        private ProjectEnvironment _activeEnvironment = null;
        [JsonProperty]
        private List<ProjectEnvironment> _projectEnvironments { get; }

        [JsonConstructor]
        public ProjectData(string projectName, string projectId, List<ProjectEnvironment> projectEnvironments)
        {
            ProjectName = projectName;
            ProjectId = projectId;
            _projectEnvironments = projectEnvironments;
            if (_projectEnvironments == null)
                _projectEnvironments = new List<ProjectEnvironment>();
        }

        public ProjectData(string projectName, string projectId)
        {
            ProjectName = projectName;
            ProjectId = projectId;
            _projectEnvironments = new List<ProjectEnvironment>();
        }

        public AddProjectSubDataResult<ProjectEnvironment> AddProjectEnvironment(ProjectEnvironment data)
        {
            if (_projectEnvironments.FirstOrDefault(p => p.EnvironmentId == data.EnvironmentId) != default)
            {
                return new AddProjectSubDataResult<ProjectEnvironment>($"Environment Id {data.EnvironmentId} ({data.EnvironmentName}) already exsists.");
            }

            _projectEnvironments.Add(data);
            return new AddProjectSubDataResult<ProjectEnvironment>(data);
        }

        public void RemoveProjectEnvironment(int index)
        {
            _projectEnvironments.RemoveAt(index);
        }
    }
}