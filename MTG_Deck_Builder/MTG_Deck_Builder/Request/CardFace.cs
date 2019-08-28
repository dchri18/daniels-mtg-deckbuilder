using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Deck_Builder.Request {
    class CardFace {

        public string artist { get; private set; }
        public string[] color_indicator { get; private set; }
        public string[] colors { get; private set; }
        public string flavor_text { get; private set; }
        public string illustration_id { get; private set; }
        public CardImagery image_uris { get; private set; }
        public string loyalty { get; private set; }
        public string mana_cost { get; private set; }
        public string name { get; private set; }
        public string oracle_text { get; private set; }
        public string power { get; private set; }
        public string printed_name { get; private set; }
        public string printed_text { get; private set; }
        public string printed_type_line { get; private set; }
        public string toughness { get; private set; }
        public string type_line { get; private set; }
        public string watermark { get; private set; }

        public CardFace(string mana_cost, string name, string type_line, string artist = null, string[] color_indicator = null, string[] colors = null, string flavor_text = null, 
            string illustration_id = null, CardImagery image_uris = null, 
            string loyalty = null, string oracle_text = null, string power = null, string printed_name = null, string printed_text = null, 
            string printed_type_line = null, string toughness = null, string watermark = null) {
            this.artist = artist;
            this.color_indicator = color_indicator;
            this.colors = colors;
            this.flavor_text = flavor_text;
            this.illustration_id = illustration_id;
            this.image_uris = image_uris;
            this.loyalty = loyalty;
            this.mana_cost = mana_cost;
            this.name = name;
            this.oracle_text = oracle_text;
            this.power = power;
            this.printed_name = printed_name;
            this.printed_text = printed_text;
            this.printed_type_line = printed_type_line;
            this.toughness = toughness;
            this.type_line = type_line;
            this.watermark = watermark;
        }
    }
}
