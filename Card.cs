using System;
using System.ComponentModel.Design.Serialization;

namespace NewCardGame
{
    class Card
    {
        public int Number { get; }
        public string Suit { get; }
        public string Name { get; }

        public Card(int number, string suit)
        {
            Number = number;
            Suit = suit;
            string name = NameMod() + " of " + Suit;
            Name = name;


        }

        public string NameMod()
        {
            switch (Number)
            {
                case 11:
                    return HigherCards.HCards.Ace.ToString();
                case 12:
                    return HigherCards.HCards.Jack.ToString(); ;
                case 13:
                    return HigherCards.HCards.Queen.ToString(); ;
                case 14:
                    return HigherCards.HCards.King.ToString(); ;

            }

            return Number.ToString();
        }
    }

}