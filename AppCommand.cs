using System;
using System.Diagnostics;
using System.IO;

namespace w3wpHUD
{
    static class AppCommand
    {
        static string AppCmdPath = @"c:\windows\system32\inetsrv\appcmd.exe";

        public static string GetWorkerProcessesList()
        {
            string output;

            try
            {
                if (!File.Exists(AppCmdPath))
                {
                    output = "Failed to find appcmd.exe";
                }

                Process appcmd = BuildAppCmdProcess("list wp");
                appcmd.Start();
                output = appcmd.StandardOutput.ReadToEnd();

                if (output.Length == 0)
                {
                    output = "No w3wp.exe processes running";
                }
            }
            catch (Exception ex)
            {
                output = "Failed to run appcmd";
                throw new Exception(output, ex);
            }

            return output;
        }

        private static Process BuildAppCmdProcess(string args)
        {
            return new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = AppCmdPath,
                    Arguments = args,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    Verb = "runas",
                },
            };
        }
    }
}
