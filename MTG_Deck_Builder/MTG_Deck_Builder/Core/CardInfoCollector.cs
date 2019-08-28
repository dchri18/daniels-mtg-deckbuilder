using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using MTG_Deck_Builder.Request;
using System.Threading;
using System.Timers;

namespace MTG_Deck_Builder.Core {
    static class CardInfoCollector {

        public static List<Card> AllCards { get; private set; }

        public async static Task<bool> Initialise() {

            AllCards = new List<Card>();

            if (System.HasBasicCardInfo) {

                return LoadLocalCardInfo();

            } else {

                if (await PopulateNewCardInfo()) {
 
                    System.HasBasicCardInfo = true;
                    System.LastBasicCardInfoIngested = DateTime.Now;                    
                    return LoadLocalCardInfo();

                } else { return false; }

            }
        }

        /// <summary>
        /// Receive all card pages from the scryfall API and serialize each Card received
        /// </summary>
        /// <returns>Whether the task completed successfully</returns>
        private async static Task<bool> PopulateNewCardInfo() {
            try {

                Debug.Initialise();
                Debug.WriteLine("System is now populating new card info");

                CardPage cardPage;
                using (HttpClient client = new HttpClient()) {

                    Debug.WriteLine(" - Get first card page");
                    var result = await client.GetAsync("https://api.scryfall.com/cards");
                    string value = await result.Content.ReadAsStringAsync();
                    cardPage = JsonConvert.DeserializeObject<CardPage>(value);

                    Debug.WriteLine(" - Save first card page information locally");
                    SaveSetLocally(cardPage.Data);

                }

                int counter = 1;

                using (HttpClient client = new HttpClient()) {

                    while (cardPage.HasMore) {

                        Debug.WriteLine($" - Getting card page: {counter}");
                        var result = await client.GetAsync(cardPage.NextPage);
                        string value = await result.Content.ReadAsStringAsync();
                        cardPage = JsonConvert.DeserializeObject<CardPage>(value);

                        Debug.WriteLine($" - Save card page {counter} locally");
                        SaveSetLocally(cardPage.Data);
                        counter++;
                    }

                }

                Debug.DeInitialise();

                return true;

            } catch (Exception e) {

                Log.WriteError($"{e.StackTrace}\r\n{e.Message}",
                    true, "An error has occured!\r\nPlease check the error log file for details.");

            }
            return false;
        }

        private static void SaveSetLocally(List<Card> cards) {
            try {

                foreach (Card card in cards) {
                    string temp = JsonConvert.SerializeObject(card, Formatting.Indented);
                    FileInfo file = new FileInfo($"{Directory.GetCurrentDirectory()}/bin/cardinfo/{card.set}/");
                    file.Directory.Create();

                    // Replace invalid characters
                    string cardName = card.name.Replace('\\', ' ');
                    cardName = cardName.Replace('/', ' ');
                    cardName = cardName.Replace(':', ' ');
                    cardName = cardName.Replace('*', ' ');
                    cardName = cardName.Replace('?', ' ');
                    cardName = cardName.Replace('"', ' ');
                    cardName = cardName.Replace('<', ' ');
                    cardName = cardName.Replace('>', ' ');
                    cardName = cardName.Replace('|', ' ');

                    int count = 0;
                    string dir = $"{Directory.GetCurrentDirectory()}/bin/cardinfo/{card.set}/{cardName}.json";
                    while (File.Exists(dir)) {
                        count++;
                        dir = $"{Directory.GetCurrentDirectory()}/bin/cardinfo/{card.set}/{cardName}{count}.json";
                    }

                    File.WriteAllText(dir, temp);
                    Debug.WriteLine($"Saved JSON to: {dir}");
                }

            } catch (Exception e) {

                Log.WriteError($"{e.StackTrace}\r\n{e.Message}",
                    true, "An error has occured!\r\nPlease check the error log file for details.");

            }
        }

        /// <summary>
        /// Load all CardInfo objects from the JSON file previously created with PopulateNewCardInfo()
        /// </summary>
        /// <returns>Whether the task was successful.</returns>
        private static bool LoadLocalCardInfo() {
            try {

                string[] directories = Directory.GetDirectories($"{Directory.GetCurrentDirectory()}/bin/cardinfo/");
                List<string> cardDirectories = new List<string>();
                for (int i = 0; i < directories.Length; i++) {
                    DirectoryInfo d = new DirectoryInfo(directories[i]);
                    foreach (var file in d.GetFiles("*.json")) {
                        cardDirectories.Add(file.FullName);
                    }
                }

                foreach (string dir in cardDirectories) {
                    Card card = JsonConvert.DeserializeObject<Card>(File.ReadAllText(dir));
                    AllCards.Add(card);
                }

                return true;

            } catch (Exception e) {


                Log.WriteError($"{e.StackTrace}\r\n{e.Message}",
                    true, "An error has occured!\r\nPlease check the error log file for details.");

            }
            return false;
        }
    }
}
