using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeforceUpdateKiller
{
    class Program
    {
        // Variables.
        static string UpdateFolderName = @"C:\ProgramData\NVIDIA Corporation\GeForce Experience\Update\";
        static string UpdateName = "setup.exe";
        static string NewUpdateName = "_setup.exe";
        static string GeforcePath = @"C:\Program Files (x86)\NVIDIA Corporation\NVIDIA GeForce Experience\LaunchGFExperience.exe";


        // Actual forming.
        static void Main(string[] args)
        {
            // Check for the existence of the update file.
            if(File.Exists(UpdateFolderName + UpdateName))
            {
                // If exists, rename.
                File.Move(UpdateFolderName + UpdateName, UpdateFolderName + NewUpdateName);
                Console.WriteLine("Found Geforce Experience update exectuable and renamed it.");
            }
            else
            {
                // If not, start the Geforce Experience.
                Console.WriteLine("No update executeable found. Starting Geforce Experience...");
                Process.Start(GeforcePath);
            }
        }
    }
}
