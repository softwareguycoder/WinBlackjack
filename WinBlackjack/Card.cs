using System;

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

        public override string ToString()
        {
            var result = GetValueName();

            result += GetSuitName();

            return result;
        }

        private string GetSuitName()
        {
            var result = string.Empty;

            switch (Suit)
            {
                case Suit.Spades:
                    result = "Spades";
                    break;

                case Suit.Hearts:
                    result = "Hearts";
                    break;

                case Suit.Clubs:
                    result = "Clubs";
                    break;

                case Suit.Diamonds:
                    result = "Diamonds";
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        private string GetValueName()
        {
            var result = string.Empty;

            switch (Value)
            {
                case Value.AceHi:
                case Value.AceLo:
                    result = "Ace of ";
                    break;

                case Value.Two:
                    result = "Two of ";
                    break;

                case Value.Three:
                    result = "Three of ";
                    break;

                case Value.Four:
                    result = "Four of ";
                    break;

                case Value.Five:
                    result = "Five of ";
                    break;

                case Value.Six:
                    result = "Six of ";
                    break;

                case Value.Seven:
                    result = "Seven of ";
                    break;

                case Value.Eight:
                    result = "Eight of ";
                    break;

                case Value.Nine:
                    result = "Nine of ";
                    break;

                case Value.Ten:
                    result = "Ten of ";
                    break;

                case Value.Jack:
                    result = "Jack of ";
                    break;

                case Value.Queen:
                    result = "Queen of ";
                    break;

                case Value.King:
                    result = "King of ";
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }
    }
}