namespace UnofficialUGSCLIUI
{
    public class ProjectEnvironment
    {
        public string EnvironmentId { get; } = string.Empty;
        public string EnvironmentName { get; } = string.Empty;
        public ProjectEnvironment(string environmentId, string environmentName)
        {
            EnvironmentId = environmentId;
            EnvironmentName = environmentName;
        }
    }
}