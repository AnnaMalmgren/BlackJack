using System.Collections.Generic;
using System.Linq;

namespace BlackJack.model.rules
{
    class Soft17HitStrategy : IHitStrategy
    {
        private const int g_hitLimit = 17;
        public bool DoHit(model.Player a_dealer) 
        {
            List<Card> hand = a_dealer.GetHand().ToList();
            
            if (a_dealer.GetSumCardValues() == g_hitLimit)
            {
                return this.DoesHandContainAce(hand);
            }

            return a_dealer.CalcScore() < g_hitLimit;
        }

        private bool DoesHandContainAce(List<Card> hand)
        {
            return hand.Exists(card => card.GetValue() == Card.Value.Ace);
        }
    }
}
