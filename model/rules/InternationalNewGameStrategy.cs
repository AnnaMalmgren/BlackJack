using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class InternationalNewGameStrategy : INewGameStrategy
    {

        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            Card c;

            c = a_deck.GetCard();
            a_player.DealCard(c, true);

            c = a_deck.GetCard();
            a_dealer.DealCard(c, true);

            c = a_deck.GetCard();
            a_player.DealCard(c, true);

            return true;
        }
    }
}
