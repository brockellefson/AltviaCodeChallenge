using CardShuffle.Models;
using System;
using System.Collections.Generic;

namespace CardShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Altvia!");

            //generate standard deck of cards for example
            var deck = GenerateDeck();
            var cardGame = new CardGame(deck);

            //print deck before shuffle
            cardGame.PrintDeck();
            cardGame.Shuffle();

            //print deck after shuffle
            cardGame.PrintDeck();

            Console.WriteLine("\nPress 'Escape' to close window\n~~~~Stay Spicy~~~~");

            //do not close console until 'esc' button is pressed
            do { while (!Console.KeyAvailable) { }}
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Generates a deck of cards
        /// </summary>
        /// <returns>52 cards, 13 of each suit</returns>
        static public List<Card> GenerateDeck()
        {
            var deck = new List<Card>();

            //for each suit, generate 13 cards
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    var card = new Card(suit, i);
                    deck.Add(card);
                }
            }

            return deck;
        }
    }
}
