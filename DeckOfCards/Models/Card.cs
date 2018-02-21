using System;
namespace DeckOfCards.Models
{
    class Card 
    {
        private string _rank;
        private string _suit;
        public Card (string rank, string suit)
        {
            _rank = rank;
            _suit = suit;
        }
        public string Rank { get {return _rank;} }
        public string Suit { get {return _suit;} }

    }
}