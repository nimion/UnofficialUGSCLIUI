using System.Diagnostics;

namespace UnofficialUGSCLIUI
{
    public class UGSCLIWrapper
    {
        public static async Task<CLIWrapperResponse> SetProjectId(string cliPath, string projectId)
        {
            try
            {
                string output = await RunProcess(cliPath, $"config set project-id {projectId}");
                if (output.Contains("is not valid"))
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.IdIsInvalid, output);
                }
                else if (output.Contains("The config 'project-id' has been set"))
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Success, $"The project id ({projectId}) was set successfully.");
                }
                else
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Undefined, output);
                }
            }
            catch (Exception ex)
            {
                return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Undefined, ex.Message);
            }
        }

        public static async Task<CLIWrapperResponse> SetAuthorization(string cliPath, string serviceKey, string secretKeyPath)
        {
            try
            {
                string output = await RunProcess(cliPath, $"ugs login --service-key-id \"{serviceKey}\" --secret-key-stdin < \"{secretKeyPath}\"");
                if (output.Contains("cannot find"))
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.NotFound, "Secret key file not found.");
                }

                if(output.Contains("Account key saved"))
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Success, $"Logged in as {serviceKey} successfully!");
                }
                else
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Undefined, output);
                }
            }
            catch (Exception ex)
            {
                return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Undefined, ex.Message);
            }
        }

        private static async Task<string> RunProcess(string cliPath, string arguments)
        {
            Cursor.Current = Cursors.WaitCursor;
            ProcessStartInfo startInfo = new()
            {
                FileName = cliPath,
                Arguments = arguments,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };

            var proc = Process.Start(startInfo);
            ArgumentNullException.ThrowIfNull(proc);
            string output = proc.StandardOutput.ReadToEnd();
            await proc.WaitForExitAsync();
            Cursor.Current = Cursors.Default;
            return output;
        }
    }

    public class CLIWrapperResponse
    {
        public ErrorCode Error { get; private set; }
        public string Message { get; private set; }

        public CLIWrapperResponse(ErrorCode errorCode, string errorMessage)
        {
            Error = errorCode;
            Message = errorMessage;
        }

        public enum ErrorCode
        {
            Undefined,
            IdIsInvalid,
            NotFound,
            Success
        }
    }
}