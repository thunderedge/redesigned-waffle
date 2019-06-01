using System;
using System.Diagnostics;
using System.Threading;

namespace U0BA10
{
    class Test
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            string[] hearts = new string[13];
            for (int i = 0; i< 13; i++)
            {
                hearts[i] = myDeck.cards[i].GetCardName();
            }
        }
    }

    // Create a class named Card. 
    // The class should have two fields, suit (string) and value (int)
    // The constructor should take in a suit (string) and a value (int) and assign them to each of the fields
    // There should be one method called GetCardName that returns a string, the name of the card,
    // for example, Ace of Hearts, 2 of Hearts, ..., Jack of Hearts, Queen of Hearts, King of Hearts
    class Card
    {
        public string suit;
        public int value;

        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public string GetCardName()
        {
            string cardName;

            if(this.value == 1)
            {
                cardName = "Ace of " + this.suit;
                
            }
            else if (this.value == 10)
            {
                cardName = "Ace of " + this.suit;
            }
            else if (this.value == 11)
            {
                cardName = "Ace of " + this.suit;
            }
            else if (this.value == 12)
            {
                cardName = "Ace of " + this.suit;
            }
            else if (this.value == 13)
            {
                cardName = "Ace of " + this.suit;
            }
            else
            {
                cardName = this.value + "of " + this.suit;
            }

            return cardName;
        }
    }

    // Create a class named Deck. 
    // The class should have one field, cards, which is an array of type Card
    // The constructor should not take in any values but it set the size of cards to 52
    // It should then fill the array with 13 Hearts with values 1 to 13, 13 Diamonds with values 1 to 13
    // 13 Spades with values 1 to 13, 13 Clubs with values 1 to 13

    class Deck
    {
        public Card[] cards;
        public Deck()
        {
           cards = new Card[52];

        }

    }


}
