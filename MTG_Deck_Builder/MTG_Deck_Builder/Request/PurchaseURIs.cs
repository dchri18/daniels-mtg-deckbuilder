using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Deck_Builder.Request {
    class PurchaseURIs {

        public Uri tcgplayer { get; private set; }
        public Uri cardmarket { get; private set; }
        public Uri cardhoarder { get; private set; }

        public PurchaseURIs(Uri tcgplayer, Uri cardmarket, Uri cardhoarder) {
            this.tcgplayer = tcgplayer;
            this.cardmarket = cardmarket;
            this.cardhoarder = cardhoarder;
        }
    }
}
