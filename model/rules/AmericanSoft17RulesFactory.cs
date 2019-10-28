using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class AmericanSoft17RulesFactory : IAbstractRulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new Soft17HitStrategy();
        }

        public IGetWinnerStrategy GetWinnerRule()
        {
            return new DealerWinsOnEqualStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }

        public void Accept(IRulesVisitor a_visitor)
        {
            a_visitor.VisitAmericanSoft17Rules(this);
        }
    }
}
