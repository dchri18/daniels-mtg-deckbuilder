using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Deck_Builder.Request {
    class CardPage {

        public int TotalCards { get; private set; }
        public bool HasMore { get; private set; }
        public Uri NextPage { get; private set; }
        public List<Card> Data { get; private set; }

        public CardPage(int total_cards, bool has_more, List<Card> data, Uri next_page = null) {
            TotalCards = total_cards;
            HasMore = has_more;
            NextPage = next_page;
            Data = data;
        }
    }
}
