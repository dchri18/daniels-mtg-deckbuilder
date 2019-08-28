using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Deck_Builder.Request {
    class Card {

        // Core Card Fields
        public int? arena_id { get; private set; }
        public string id { get; private set; }
        public string lang { get; private set; }
        public int? mtgo_id { get; private set; }
        public int? mtgo_foil_id { get; private set; }
        public int?[] multiverse_ids { get; private set; }
        public int? tcgplayer_id { get; private set; }
        public string oracle_id { get; private set; }
        public Uri prints_search_uri { get; private set; }
        public Uri rulings_uri { get; private set; }
        public Uri scryfall_uri { get; private set; }
        public Uri uri; // Variable instead of parameter due to a bug or something.

        // Gameplay Fields
        public List<RelatedCardObjects> all_parts { get; private set; }
        public List<CardFace> card_faces { get; private set; }
        public decimal cmc { get; private set; }
        public string[] colors { get; private set; }
        public string[] color_identity { get; private set; }
        public string[] color_indicator { get; private set; }
        public int? edhrec_rank { get; private set; }
        public bool foil { get; private set; }
        public string hand_modifier { get; private set; }
        public string layout { get; private set; }
        public Legalities legalities { get; private set; }
        public string life_modifier { get; private set; }
        public string loyalty { get; private set; }
        public string mana_cost { get; private set; }
        public string name; // Variable instead of parameter due to a bug or something.
        public bool nonfoil { get; private set; }
        public string oracle_text { get; private set; }
        public bool oversized { get; private set; }
        public string power { get; private set; }
        public bool reserved { get; private set; }
        public string toughness { get; private set; }
        public string type_line { get; private set; }

        // Print Fields
        public string artist { get; private set; }
        public bool booster { get; private set; }
        public string border_color { get; private set; }
        public string card_back_id { get; private set; }
        public string collector_number { get; private set; }
        public bool digital { get; private set; }
        public string flavor_text { get; private set; }
        public string frame_effect { get; private set; }
        public string frame { get; private set; }
        public bool full_art { get; private set; }
        public string[] games { get; private set; }
        public bool highres_image { get; private set; }
        public string illustration_id { get; private set; }
        public CardImagery image_uris { get; private set; }
        public Prices prices { get; private set; }
        public string printed_name { get; private set; }
        public string printed_text { get; private set; }
        public string printed_type_line { get; private set; }
        public bool promo { get; private set; }
        public string[] promo_types { get; private set; }
        public PurchaseURIs purchase_uris { get; private set; }
        public string rarity { get; private set; }
        public RelatedURIs related_uris { get; private set; }
        public string released_at { get; private set; }
        public bool reprint { get; private set; }
        public Uri scryfall_set_uri { get; private set; }
        public string set_name { get; private set; }
        public Uri set_search_uri { get; private set; }
        public string set_type { get; private set; }
        public Uri set_uri { get; private set; }
        public string set { get; private set; }
        public bool story_spotlight { get; private set; }
        public bool textless { get; private set; }
        public bool variation { get; private set; }
        public string variation_of { get; private set; }
        public string watermark { get; private set; }

        public Card(bool promo, string[] promo_types, PurchaseURIs purchase_uris, string rarity, RelatedURIs related_uris, 
            string released_at, bool reprint, Uri scryfall_set_uri, string set_name, Uri set_search_uri, string set_type, 
            Uri set_uri, string set, bool story_spotlight, bool textless, bool variation, Prices prices, string frame, 
            bool full_art, string[] games, bool highres_image, string card_back_id, string collector_number, bool digital, 
            string border_color, bool booster, string type_line, bool reserved, Legalities legalities, bool oversized, 
            bool nonfoil, string name, string layout, bool foil, int? edhrec_rank, string[] color_identity, decimal cmc, 
            int? arena_id, string id, string lang, int? mtgo_id, int? mtgo_foil_id, int?[] multiverse_ids, int? tcgplayer_id, 
            string oracle_id, Uri prints_search_uri, Uri rulings_uri, Uri scryfall_uri, Uri uri, List<RelatedCardObjects> all_parts = null, 
            List<CardFace> card_faces = null, string[] colors = null, string[] color_indicator = null, string hand_modifier = null, 
            string life_modifier = null, string loyalty = null, string mana_cost = null, string oracle_text = null, string power = null, 
            string toughness = null, string artist = null, string flavor_text = null, string frame_effect = null, string illustration_id = null, 
            CardImagery image_uris = null, string printed_name = null, string printed_text = null, string printed_type_line = null, 
            string variation_of = null, string watermark = null) {
            this.arena_id = arena_id;
            this.id = id;
            this.lang = lang;
            this.mtgo_id = mtgo_id;
            this.mtgo_foil_id = mtgo_foil_id;
            this.multiverse_ids = multiverse_ids;
            this.tcgplayer_id = tcgplayer_id;
            this.oracle_id = oracle_id;
            this.prints_search_uri = prints_search_uri;
            this.rulings_uri = rulings_uri;
            this.scryfall_uri = scryfall_uri;
            this.uri = uri;
            this.all_parts = all_parts;
            this.card_faces = card_faces;
            this.cmc = cmc;
            this.colors = colors;
            this.color_identity = color_identity;
            this.color_indicator = color_indicator;
            this.edhrec_rank = edhrec_rank;
            this.foil = foil;
            this.hand_modifier = hand_modifier;
            this.layout = layout;
            this.legalities = legalities;
            this.life_modifier = life_modifier;
            this.loyalty = loyalty;
            this.mana_cost = mana_cost;
            this.name = name;
            this.nonfoil = nonfoil;
            this.oracle_text = oracle_text;
            this.oversized = oversized;
            this.power = power;
            this.reserved = reserved;
            this.toughness = toughness;
            this.type_line = type_line;
            this.artist = artist;
            this.booster = booster;
            this.border_color = border_color;
            this.card_back_id = card_back_id;
            this.collector_number = collector_number;
            this.digital = digital;
            this.flavor_text = flavor_text;
            this.frame_effect = frame_effect;
            this.frame = frame;
            this.full_art = full_art;
            this.games = games;
            this.highres_image = highres_image;
            this.illustration_id = illustration_id;
            this.image_uris = image_uris;
            this.prices = prices;
            this.printed_name = printed_name;
            this.printed_text = printed_text;
            this.printed_type_line = printed_type_line;
            this.promo = promo;
            this.promo_types = promo_types;
            this.purchase_uris = purchase_uris;
            this.rarity = rarity;
            this.related_uris = related_uris;
            this.released_at = released_at;
            this.reprint = reprint;
            this.scryfall_set_uri = scryfall_set_uri;
            this.set_name = set_name;
            this.set_search_uri = set_search_uri;
            this.set_type = set_type;
            this.set_uri = set_uri;
            this.set = set;
            this.story_spotlight = story_spotlight;
            this.textless = textless;
            this.variation = variation;
            this.variation_of = variation_of;
            this.watermark = watermark;
        }
    }
}
