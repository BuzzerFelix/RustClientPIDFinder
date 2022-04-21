using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustClientPIDFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] proc = Process.GetProcessesByName("RustClient");
            if (proc.Length == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RustClient is Detected");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                MessageBox.Show("RustClient not Found, Please Run RustClient(Steam or Pirated Version) and Try Again");
                Environment.Exit(431);
            }
            foreach (var rust in proc)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"RustClient's PID: {rust.Id}");
                long kl = rust.PagedSystemMemorySize64; //EAC is Defending Memory, and it's not showing :/
                Console.Write(kl.ToString());
                long xxx = rust.PrivateMemorySize64; //WTF EAC, why? :( 
                Console.Write(xxx.ToString());
            }
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}
