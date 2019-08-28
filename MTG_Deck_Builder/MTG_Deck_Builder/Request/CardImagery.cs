using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MTG_Deck_Builder.Request {
    class CardImagery {

        public Uri small { get; private set; }
        public Uri normal { get; private set; }
        public Uri large { get; private set; }
        public Uri png { get; private set; }
        public Uri art_crop { get; private set; }
        public Uri border_crop { get; private set; }

        public CardImagery(Uri small, Uri normal, Uri large, Uri png, Uri art_crop, Uri border_crop) {
            this.small = small;
            this.normal = normal;
            this.large = large;
            this.png = png;
            this.art_crop = art_crop;
            this.border_crop = border_crop;
        }
    }
}
