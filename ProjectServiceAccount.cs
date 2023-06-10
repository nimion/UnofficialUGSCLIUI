namespace UnofficialUGSCLIUI
{
    public class ProjectServiceAccount
    {
        public string AccountKeyId { get; } = string.Empty;
        public string AccountSecretKey { get; } = string.Empty;
        public string FriendlyName { get; } = string.Empty;
        public ProjectServiceAccount(string accountKeyId, string accountSecretId, string friendlyName)
        {
            AccountKeyId = accountKeyId;
            AccountSecretKey = accountSecretId;
            FriendlyName = friendlyName;
        }
    }
}