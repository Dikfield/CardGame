using System;
using System.Collections.Generic;
using System.Linq;

namespace NewCardGame
{
    class Deck
    {
        private int[] _numbers = new int[13] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        private string[] _suits = new string[4] { "Diamonds", "Clubs", "Hearts", "Spades" };
        public List<Card> DeckOfCards { get; set; }
        public Deck()
        {
            DeckOfCards = new List<Card>();

            foreach (string suit in _suits)
            {
                foreach (int number in _numbers)
                {
                    var card = new Card(number, suit);
                    DeckOfCards.Add(new Card(number, suit));
                }
            }

            Shuffle();

        }
        public void Shuffle()
        {
            var rnd = new Random();
            DeckOfCards = DeckOfCards.OrderBy(item => rnd.Next(DateTime.Now.Day)).ToList();
        }


    }
}