using System.Collections.Generic;
using System.Linq;

namespace BlackJack.model
{
    class Player
    {
        private List<Card> m_hand = new List<Card>();
        private List<IGetCardObserver> m_subscribers = new List<IGetCardObserver>();

        public void DealCard(Card a_card, bool a_showCard = true)
        {
            a_card.Show(a_showCard);
            m_hand.Add(a_card);
            NotifySubscribers();
        }

        public IEnumerable<Card> GetHand()
        {
            return m_hand.Cast<Card>();
        }

        public void ClearHand()
        {
            m_hand.Clear();
        }

        public void ShowHand()
        {
            foreach (Card c in GetHand())
            {
                c.Show(true);
            }
        }

        public int CalcScore()
        {
            int score = GetSumCardValues();

            if (score > 21)
            {
                foreach (Card c in GetHand())
                {
                    if (c.GetValue() == Card.Value.Ace && score > 21)
                    {
                        score -= 10;
                    }
                }
            }

            return score;
        }

        public int GetSumCardValues()
        {
            int[] cardScores = new int[(int)model.Card.Value.Count]
                {2, 3, 4, 5, 6, 7, 8, 9, 10, 10 ,10 ,10, 11};
            int score = 0;

            foreach(Card c in GetHand()) {
                if (c.GetValue() != Card.Value.Hidden)
                {
                    score += cardScores[(int)c.GetValue()];
                }
            }

            return score;
        }

        public void NotifySubscribers()
        {
            m_subscribers.ForEach(subscriber => subscriber.CardDealt());
        }

        public void AddSubscriber(IGetCardObserver a_subscriber)
        {
            m_subscribers.Add(a_subscriber);
        }
    }
}
