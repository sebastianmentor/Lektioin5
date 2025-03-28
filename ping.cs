using System;
using System.Diagnostics;

class PingTest {
    static void Main() {
        string target = "8.8.8.8";
        Process ping = new Process();
        ping.StartInfo.FileName = "ping";
        ping.StartInfo.Arguments = "-c 4 " + target;
        ping.StartInfo.RedirectStandardOutput = true;
        ping.StartInfo.UseShellExecute = false;
        ping.Start();

        string output = ping.StandardOutput.ReadToEnd();
        ping.WaitForExit();
        Console.WriteLine(output);
    }
}
