using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace OutsideProject2
{
    [Binding]

    public class CMDZalenium
    {
       private readonly static string  ZeleniumStartCommand = "docker run --rm -ti --name zalenium -p 4444:4444 -v /var/run/docker.sock:/var/run/docker.sock -v /home/seluser/videos --privileged dosel/zalenium start --desiredContainers 6";
       private readonly static string ZeleniumStopCommand = "docker stop zalenium";

        [BeforeTestRun]

        public static void CMDZale()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine(ZeleniumStartCommand);
            process.StandardInput.Flush();
            process.StandardInput.Close();
            //process.WaitForExit();
            //Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();


            }

            //[AfterTestRun]
            //public static void CMDStopZale()
            //{
            //    Process process = new Process();
            //    process.StartInfo.FileName = "cmd.exe";
            //    process.StartInfo.CreateNoWindow = true;
            //    process.StartInfo.RedirectStandardInput = true;
            //    process.StartInfo.RedirectStandardOutput = true;
            //    process.StartInfo.UseShellExecute = false;
            //    process.Start();
            //    process.StandardInput.WriteLine(ZeleniumStopCommand);
            //    process.StandardInput.Flush();
            //    process.StandardInput.Close();
            //    process.WaitForExit();
            //    Console.WriteLine(process.StandardOutput.ReadToEnd());
            //    Console.ReadKey();

            //}
        }
}
