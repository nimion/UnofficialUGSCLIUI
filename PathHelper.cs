namespace UnofficialUGSCLIUI
{
    public static class PathHelper
    {
        private static string ROOT_DIRECTORY = "Projects";

        public static List<string> GetProjectsInRootDirectory()
        {
            if (Directory.Exists(ROOT_DIRECTORY))
            {
                return Directory.GetFiles(Path.Combine(ROOT_DIRECTORY)).ToList();
            }

            return new List<string>();
        }

        public static string GetProjectPath(ProjectData projectData)
        {
            return Path.Combine(ROOT_DIRECTORY, projectData.ProjectName);
        }

        public static string GetProjectDataPath(ProjectData projectData)
        {
            return Path.Combine(ROOT_DIRECTORY, projectData.ProjectName, $"{projectData.ProjectId}.json");
        }

        public static string GetInitialDirectory()
        {
            return Path.Combine(ROOT_DIRECTORY);
        }
    }
}