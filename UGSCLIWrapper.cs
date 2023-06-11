using System.Diagnostics;

namespace UnofficialUGSCLIUI
{
    public class UGSCLIWrapper
    {
        public static async Task<CLIWrapperResponse> SetProjectId(string cliPath, string projectId)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ProcessStartInfo startInfo = new()
                {
                    FileName = cliPath,
                    Arguments = $"config set project-id {projectId}",
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                };

                var proc = Process.Start(startInfo);
                ArgumentNullException.ThrowIfNull(proc);
                string output = proc.StandardOutput.ReadToEnd();
                await proc.WaitForExitAsync();

                Cursor.Current = Cursors.WaitCursor;
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
                Cursor.Current = Cursors.WaitCursor;
                return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Undefined, ex.Message);
            }
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
            Success
        }
    }
}