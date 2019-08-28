using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTG_Deck_Builder {

    /// <summary>
    /// Class to be used for debuggin purposes only.
    /// If this class is used in any of the code the program will not run unless the application output is Console
    /// Set this is the project properties windows.
    /// </summary>
    public static class Debug {

        public static Stopwatch Stopwatch { get; private set; } = new Stopwatch();
        private static bool TableStructureFlag { get; set; } = false;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow(); 

        public static void Initialise() {
            // If Console is not enabled program cannot continue.
            if (GetConsoleWindow() == IntPtr.Zero) {
                Log.WriteError("FAULT: Debug Console is used in source code but Console is not enabled as Application Output!", 
                    true, "An error has occured and the application must exit!\r\nPlease check the error log file for details.");
                Application.Exit();
            } else {
                // Checck if already initialised
                if (!Stopwatch.IsRunning) {
                    Stopwatch.Restart();
                    PrintTableStructure();
                } else {
                    throw new Exception("Debug tried to initialise in an already initialised state");
                }
            }
        }

        public static void DeInitialise() {
            if (Stopwatch.IsRunning) {
                Stopwatch.Stop();
            } else {
                throw new Exception("Debug tried to deinitialise in an already deinitilaised state");
            }
        }

        public static void WriteLine(string message) {
            Console.WriteLine($"{Stopwatch.Elapsed.ToString()}    {message}");
        }

        private static void PrintTableStructure() {
            if (!TableStructureFlag) {
                Console.WriteLine("###########################################################################");
                Console.WriteLine("#   Timestamp   #                        Task Output                      #");
                Console.WriteLine("###########################################################################");
                TableStructureFlag = true;
            }
        }
    }
}
