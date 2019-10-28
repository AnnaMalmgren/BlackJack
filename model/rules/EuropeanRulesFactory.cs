using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class EuropeanRulesFactory : IAbstractRulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy();
        }

        public IGetWinnerStrategy GetWinnerRule()
        {
            return new DealerWinsOnEqualStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new InternationalNewGameStrategy();
        }
    }
}
