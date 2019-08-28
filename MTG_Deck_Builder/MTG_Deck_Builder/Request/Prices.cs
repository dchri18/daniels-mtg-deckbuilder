using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Deck_Builder.Request {
    class Prices {

        public string usd { get; private set; }
        public string usd_foil { get; private set; }
        public string eur { get; private set; }
        public string tix { get; private set; }

        public Prices(string usd, string usd_foil, string eur, string tix) {
            this.usd = usd;
            this.usd_foil = usd_foil;
            this.eur = eur;
            this.tix = tix;
        }

    }
}
