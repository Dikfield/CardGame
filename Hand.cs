using System.Collections.Generic;
using System.Linq;

namespace NewCardGame
{
    class Hand
    {
        public List<Card> CardsInHand { get;}
        public List<Card> RestOfDeck { get;}
        public Hand()
        {
            CardsInHand = new List<Card>();
            RestOfDeck = new List<Card>();
            var deck = new Deck();
            for (int i = 0; i < 5; i++)
            {
                var topCard = deck.DeckOfCards[0];
                CardsInHand.Add(topCard);
                deck.DeckOfCards.RemoveAt(0);
            }

            RestOfDeck = deck.DeckOfCards;

        }
    }
}