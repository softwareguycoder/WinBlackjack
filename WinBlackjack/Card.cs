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
            return $"{GetValueName()} of {GetSuitName()}";
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
                    result = "Ace";
                    break;

                case Value.Two:
                    result = "Two";
                    break;

                case Value.Three:
                    result = "Three";
                    break;

                case Value.Four:
                    result = "Four";
                    break;

                case Value.Five:
                    result = "Five";
                    break;

                case Value.Six:
                    result = "Six";
                    break;

                case Value.Seven:
                    result = "Seven";
                    break;

                case Value.Eight:
                    result = "Eight";
                    break;

                case Value.Nine:
                    result = "Nine";
                    break;

                case Value.Ten:
                    result = "Ten";
                    break;

                case Value.Jack:
                    result = "Jack";
                    break;

                case Value.Queen:
                    result = "Queen";
                    break;

                case Value.King:
                    result = "King";
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }
    }
}