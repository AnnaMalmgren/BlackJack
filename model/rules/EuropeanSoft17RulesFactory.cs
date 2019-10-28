namespace BlackJack.model.rules
{
    class EuropeanSoft17RulesFactory : IAbstractRulesFactory
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
            return new InternationalNewGameStrategy();
        }

        public void Accept(IRulesVisitor a_visitor)
        {
            a_visitor.VisitEuropeanSoft17Rules(this);
        }
    }
}
