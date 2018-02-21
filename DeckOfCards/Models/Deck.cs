// A Hello World! program in C#.
using System;
namespace DeckOfCards.Models
{
    class Deck 
    {
        private string _id;
        
        public Deck(string id) 
        {
            _id = id;
        }
        
        public string ID { get {return _id;} }
    }
}