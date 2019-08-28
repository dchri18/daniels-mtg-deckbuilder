using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Deck_Builder.Request {
    class RelatedCardObjects {
        public string id { get; private set; }
        public string component { get; private set; }
        public string name { get; private set; }
        public string type_line { get; private set; }
        public Uri uri { get; private set; }

        public RelatedCardObjects(string id, string component, string name, string type_line, Uri uri) {
            this.id = id;
            this.component = component;
            this.name = name;
            this.type_line = type_line;
            this.uri = uri;
        }
    }
}
