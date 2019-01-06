using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine("ID: {0} Name: {1}", process.Id, process.ProcessName);
            }

            Process proc = Process.GetProcessesByName("devenv")[0];
            Console.WriteLine("ID: {0}", proc.Id);

            Console.WriteLine("___________________________________");
            ProcessThreadCollection processThread = proc.Threads;
            foreach (ProcessThread thread in processThread)
            {
                Console.WriteLine("Thread: {0} StartTime: {1}", thread.Id, thread.StartTime);
            }
            Console.WriteLine("___________________________________");
            ProcessModuleCollection modules = proc.Modules;
            foreach (ProcessModule module in modules)
            {
                Console.WriteLine("Name: {0} MemorySize: {1}", module.ModuleName, module.ModuleMemorySize);
            }

            //Process.Start("http://google.com");
            //Process.Start("G://Price.php");
            //Process.Start(@"C:\Program Files\Adobe\Adobe Photoshop CC 2017\Photoshop.exe");

        }
    }
}
