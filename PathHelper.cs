namespace UnofficialUGSCLIUI
{
    public static class PathHelper
    {
        private static string PROJECT_ROOT_DIRECTORY = "Projects";
        private static string CONFIG_ROOT_DIRECTORY = "Configs";

        public static List<string> GetProjectsInRootDirectory()
        {
            if (Directory.Exists(PROJECT_ROOT_DIRECTORY))
            {
                return Directory.GetFiles(Path.Combine(PROJECT_ROOT_DIRECTORY)).ToList();
            }

            return new List<string>();
        }

        public static string GetProjectPath(ProjectData projectData)
        {
            return Path.Combine(PROJECT_ROOT_DIRECTORY, projectData.ProjectName);
        }

        public static string GetProjectDataPath(ProjectData projectData)
        {
            return Path.Combine(PROJECT_ROOT_DIRECTORY, projectData.ProjectName, $"{projectData.ProjectId}.json");
        }

        public static string GetInitialDirectory()
        {
            return Path.Combine(PROJECT_ROOT_DIRECTORY);
        }

        public static string GetConfigPath()
        {
            return Path.Combine(CONFIG_ROOT_DIRECTORY, "config.json");
        }
    }
}