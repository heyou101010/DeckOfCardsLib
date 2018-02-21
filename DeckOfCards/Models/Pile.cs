using System.Collections.Generic;

namespace DeckOfCards.Models
{
    class Pile 
    {
        private List<Card> _cards;
        
        public Pile (List<Card> cards)
        {
            _cards = cards;
        }
        
        public readonly List<Card> Cards{ get {return _cards;} }
    }
}