using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace CardGame
{
    class Card
    {
        public int Numbers { get; set; }
        public string Suits { get; set; }
        public string Name { get; set; }
        public Card CardInHand { get; set; }

    }
    class Deck
    {
        public List<Card> DeckOfCards { get; set; }
        public List<Card> CardInHands { get; set; }

        public Deck()
        {
            List<Card> deckOfCards_ = new List<Card>();
            int[] numbers = new int[13]
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            string[] suits = new string[4] { "Espada", "Ouro", "Copas", "Paus" };
            foreach (int number in numbers)
            {
                foreach (string suit in suits)
                {
                    deckOfCards_.Add(new Card { Numbers = number, Suits = suit, Name = number + " de " + suit });
                }
            }

            DeckOfCards = deckOfCards_;
        }

        public void CardsInHand()
        {
            List<Card> cardInHands_ = new List<Card>();
            int count = 0;
            foreach (Card card in DeckOfCards)
            {
                while (count < 6)
                {
                    cardInHands_.Add(new Card {CardInHand = card});
                    count++;
                }
            }

            CardInHands = cardInHands_;
        }
        public void ShowDeck()
        {
            Console.WriteLine("Deck of cards is: ");
            foreach (Card card in DeckOfCards)
            {
                Console.Write(card.Name + "\n");
            }

        }
        public void ShowHand()
        {
            Console.WriteLine("Your cards in Hands are: ");
            Deck cardDeck = new Deck();
            foreach (Card card in CardInHands)
            {
                Console.Write(card.CardInHand + "\n");
            }

        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.ShowDeck();
            deck.ShowHand();
        }
    }
}

