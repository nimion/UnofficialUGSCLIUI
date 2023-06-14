namespace UnofficialUGSCLIUI
{
    public class ProjectEnvironment
    {
        public string EnvironmentName { get; } = string.Empty;
        public string EnvironmentId { get; } = string.Empty;
        public ProjectEnvironment(string environmentName, string environmentId)
        {
            EnvironmentName = environmentName;
            EnvironmentId = environmentId;
        }
    }
}