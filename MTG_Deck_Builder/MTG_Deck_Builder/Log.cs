using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MTG_Deck_Builder {
    public static class Log {

        /// <summary>
        /// Prints an output to the associated task log file.
        /// </summary>
        /// <param name="output">The output message to be printed.</param>
        /// <param name="show">Whether or not to show a messagebox.</param>
        /// <param name="popup">Message to show on the messagebox.</param>
        public static void WriteTask(string output, bool show = false, string popup = "") {
            // Print message.
            FileInfo file = new FileInfo($"{Directory.GetCurrentDirectory()}/bin/logs/");
            file.Directory.Create();
            var writer = File.AppendText($"{Directory.GetCurrentDirectory()}/bin/logs/task.txt");
            string date = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            writer.WriteLine($"{date} | {output}");
            writer.Close();

            // Show popup if enabled.
            if (show) { MessageBox.Show(popup); }
        }

        /// <summary>
        /// Prints an output ot the associated error log file.
        /// </summary>
        /// <param name="output">The output message to be printed.</param>
        /// <param name="show">Whether or not to show a messagebox.</param>
        /// <param name="popup">Message to show on the messagebox.</param>
        public static void WriteError(string output, bool show = false, string popup = "") {
            // Print message.
            FileInfo file = new FileInfo($"{Directory.GetCurrentDirectory()}/bin/logs/");
            file.Directory.Create();
            var writer = File.AppendText($"{Directory.GetCurrentDirectory()}/bin/logs/error.txt");
            string date = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            writer.WriteLine($"{date} | {output}");
            writer.Close();

            // Show popup if enabled.
            if (show) { MessageBox.Show(popup); }
        }
    }
}
