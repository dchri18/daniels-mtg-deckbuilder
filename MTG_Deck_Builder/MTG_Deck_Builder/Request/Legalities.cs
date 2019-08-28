using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Deck_Builder.Request {
    class Legalities {

        public string standard { get; private set; }
        public string future { get; private set; }
        public string modern { get; private set; }
        public string legacy { get; private set; }
        public string pauper { get; private set; }
        public string vintage { get; private set; }
        public string penny { get; private set; }
        public string commander { get; private set; }
        public string brawl { get; private set; }
        public string duel { get; private set; }
        public string oldschool { get; private set; }

        public Legalities(string standard, string future, string modern, string legacy, string pauper, string vintage, 
            string penny, string commander, string brawl, string duel, string oldschool) {
            this.standard = standard;
            this.future = future;
            this.modern = modern;
            this.legacy = legacy;
            this.pauper = pauper;
            this.vintage = vintage;
            this.penny = penny;
            this.commander = commander;
            this.brawl = brawl;
            this.duel = duel;
            this.oldschool = oldschool;
        }
    }
}
