using System;
using System.Collections.Generic;
using System.Text;

namespace deck_of_card_enum
{
    class Kartu
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }

        public Kartu (Values val, Suits su)
        {
            this.Value = val;
            this.Suit = su;
        }

        public string Name
        {
            get { return $"{this.Value} of {this.Suit}"; }
        }
    }
}
