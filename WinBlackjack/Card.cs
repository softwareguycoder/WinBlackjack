namespace WinBlackjack
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public static bool IsFace(Card card)
        {
            return card.Value == Value.Jack || card.Value == Value.Queen || card.Value == Value.King;
        }
    }
}