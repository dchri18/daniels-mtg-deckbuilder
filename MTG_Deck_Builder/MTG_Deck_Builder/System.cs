using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MTG_Deck_Builder {
    public static class System {

        public static bool HasBasicCardInfo { get; set; } = false;
        public static DateTime LastBasicCardInfoIngested { get; set; }

        public static void LoadFlags() {

            Debug.Initialise();

            if (File.Exists($"{Directory.GetCurrentDirectory()}/bin/system.dat")) {
                Debug.WriteLine("System is parsing system.dat");
                string read = File.ReadAllText($"{Directory.GetCurrentDirectory()}/bin/system.dat");
                string[] split = read.Split(',');
                HasBasicCardInfo = split[0] == "True";
                string[] temp = split[1].Split(':');
                LastBasicCardInfoIngested = new DateTime(Int32.Parse(temp[2]), Int32.Parse(temp[1]), Int32.Parse(temp[0]));
            } else {
                Debug.WriteLine("System is using default flags");
            }

            Debug.WriteLine($" - HasBasicCardInfo is set to: {HasBasicCardInfo}");
            Debug.WriteLine($" - LastBasicCardInfoIngested is set to: {LastBasicCardInfoIngested.Day}:{LastBasicCardInfoIngested.Month}:{LastBasicCardInfoIngested.Year}");

            Debug.DeInitialise();
        }

        public static void SaveFlags() {
            File.WriteAllText($"{Directory.GetCurrentDirectory()}/bin/system.dat",
                $"{HasBasicCardInfo}," +
                $"{LastBasicCardInfoIngested.Day}:{LastBasicCardInfoIngested.Month}:{LastBasicCardInfoIngested.Year}");
        }
    }
}
