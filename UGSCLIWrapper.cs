using System.Diagnostics;
using System.Text;

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

        public static async Task<CLIWrapperResponse> Logout(string cliPath)
        {
            try
            {
                ProcessStartInfo startInfo = new()
                {
                    FileName = cliPath,
                    Arguments = "logout",
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                };

                var proc = Process.Start(startInfo);
                string output = proc.StandardOutput.ReadToEnd();
                await proc.WaitForExitAsync();
                return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Success, string.Empty);
            }
            catch (Exception ex)
            {
                return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Undefined, ex.Message);
            }
        }

        public static async Task<CLIWrapperResponse> SetActiveEnvironment(string cliPath, string name)
        {
            try
            {
                ProcessStartInfo startInfo = new()
                {
                    FileName = cliPath,
                    Arguments = $"config set environment-name {name}",
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                };

                var proc = Process.Start(startInfo);
                string output = proc.StandardOutput.ReadToEnd();
                await proc.WaitForExitAsync();

                if (output.Contains("has been set"))
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Success, "Environment has been set!");
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

        public static async Task<CLIWrapperResponse> SetAuthorization(string cliPath)
        {
            try
            {
                ProcessStartInfo startInfo = new()
                {
                    FileName = cliPath,
                    Arguments = "login",
                    CreateNoWindow = false,
                };

                var proc = Process.Start(startInfo);
                await proc.WaitForExitAsync();

                ProcessStartInfo startInfo2 = new()
                {
                    FileName = cliPath,
                    Arguments = "status",
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                };

                var proc2 = Process.Start(startInfo2);
                string output = proc2.StandardOutput.ReadToEnd();

                if (output.Contains("Using Service"))
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Success, "Successfully authenticated!");
                }
                else if (output.Contains("No Service"))
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Undefined, "Login failed!");
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

        public static async Task<CLIWrapperResponse> DeployModule(string cliPath, string modulePath)
        {
            try
            {
                ProcessStartInfo startInfo = new()
                {
                    FileName = cliPath,
                    Arguments = $"deploy \"{modulePath}\"",
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                };

                var proc = Process.Start(startInfo);
                string output = proc.StandardOutput.ReadToEnd();
                await proc.WaitForExitAsync();

                if (output.Contains("Updated:") && output.Contains("Deployed:"))
                {
                    return new CLIWrapperResponse(CLIWrapperResponse.ErrorCode.Success, "Successfully Deployed!");
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