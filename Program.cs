using System;
using System.Collections.Generic;

namespace NewCardGame
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            var hand = new Hand();

            Console.WriteLine("\nDeck of cards \n");
            foreach (var card in deck.DeckOfCards)
            {
                Console.WriteLine(card.Name);
            }
            Console.WriteLine("\nHands \n");
            foreach (var card in hand.CardsInHand)
            {
                Console.WriteLine(card.Name);
            }

            Console.WriteLine("\nRest of cards \n");
            foreach (var card in hand.RestOfDeck)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
