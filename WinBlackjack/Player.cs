using System.Collections.Generic;

namespace WinBlackjack
{
    public class Player
    {
        public Player()
        {
            Hand = new List<Card>();
            IsDealer = false;
        }

        public List<Card> Hand { get; private set; }
        public bool IsDealer { get; set; }
    }
}