namespace CardShuffle.Models
{
    public class Card
    {
        public Card(Suit suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit { get; set; }
        public int Value { get; set; }
    }
}
