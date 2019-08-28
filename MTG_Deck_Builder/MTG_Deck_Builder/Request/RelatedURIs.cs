using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Deck_Builder.Request {
    class RelatedURIs {

        public Uri tcgplayer_decks { get; private set; }
        public Uri edhrec { get; private set; }
        public Uri mtgtop8 { get; private set; }

        public RelatedURIs(Uri tcgplayer_decks, Uri edhrec, Uri mtgtop8) {
            this.tcgplayer_decks = tcgplayer_decks;
            this.edhrec = edhrec;
            this.mtgtop8 = mtgtop8;
        }
    }
}
