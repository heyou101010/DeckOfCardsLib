using System;
using System.Net;
using System.Text;
using DeckOfCards.Models;

namespace DeckOfCards.Client
{
    class APIUtils 
    {
        const BaseURL = "https://deckofcardsapi.com/api";
        
        public static Deck GetNewDeck(string url) 
        {
            var req = (HttpWebRequest) WebRequest.Create(BaseURL + "/deck/new/shuffle");
            
            using (HttpWebResponse resp = req.GetResponse()) {
                using (StreamReader respStream = new StreamReader(resp.getResponseStream(), Encoding.UTF8)
                {
                    var respJSON = resp.
                }
            }


            Console.WriteLine(req.GetResponse().)
            return new Deck("Hello World!");
        }
    }
}