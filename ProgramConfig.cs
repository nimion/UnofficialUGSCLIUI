using Newtonsoft.Json;

namespace UnofficialUGSCLIUI
{
    public class ProgramConfig
    {
        public string CLILocation { get; private set; }

        public ProgramConfig()
        {

        }

        [JsonConstructor]
        public ProgramConfig(string cliLocation)
        {
            CLILocation = cliLocation;
        }

        public void SetCLILocation(string path)
        {
            CLILocation = path;
        }
    }
}