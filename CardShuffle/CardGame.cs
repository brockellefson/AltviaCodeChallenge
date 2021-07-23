using CardShuffle.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardShuffle
{
    public class CardGame
    {
        public List<Card> Deck { get; set; }
        public Random Random { get; }

        /// <summary>
        /// Card game..... currently only requirement is to shuffle
        /// </summary>
        /// <param name="deck"></param>
        public CardGame(List<Card> deck)
        {
            Deck = deck;
            Random = new Random();
        }

        /// <summary>
        /// Shuffles deck
        /// </summary>
        /// <param name="deck">deck of cards in game</param>
        public void Shuffle()
        {
            Deck = Deck.OrderBy(x => Random.Next()).ToList();
        }

        /// <summary>
        /// Determines if card is a face card 
        /// </summary>
        /// <returns>correct nomenclature of card</returns>
        public string DetermineCardValue(Card card)
        {
            switch (card.Value)
            {
                case 1: return "Ace";
                case 11: return "Jack";
                case 12: return "Queen";
                case 13: return "King";
                default: return card.Value.ToString();
            }
        }

        /// <summary>
        /// Prints suit and value of each card in the decks current order
        /// </summary>
        public void PrintDeck()
        {
            Console.WriteLine("\nCurrent Deck Order:");
            foreach (var card in Deck)
            {        
                var value = DetermineCardValue(card);
                Console.WriteLine($"Suit: {card.Suit}, Value: {value}");
            }
        }
    }
}
