using System.Collections.Generic;
using System.Linq;
using System;

namespace BlackJack.model.rules
{
    class Soft17HitStrategy : IHitStrategy
    {
        private const int g_hitLimit = 17;
        private const int g_getLowAce = 10;

        public bool DoHit(model.Player a_dealer) 
        {
            List<Card> hand = a_dealer.GetHand().ToList();
            int nrAces = CountAces(hand);
            int score = a_dealer.GetSumCardValues();

            if (IsSoft17(score, nrAces))
            {
                return true;
            }
            return a_dealer.CalcScore() < g_hitLimit;
        }

        private int CountAces(List<Card> hand)
        {
            int nrOfAces = hand
                            .Where(card => card.GetValue() == Card.Value.Ace)
                            .Select(card => card)
                            .Count();
            return nrOfAces;
        }

        private bool IsSoft17(int score, int nrAces) {
            if (nrAces > 0)
            {
                for (int i = 1; i < nrAces; i++)
                {
                    score -= g_getLowAce;
                }

                return score == g_hitLimit;
            }
            return false;
        }
    }
}
