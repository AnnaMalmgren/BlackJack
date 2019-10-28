namespace BlackJack.model.rules
{
    class EuropeanBasicRulesFactory : IAbstractRulesFactory
    {
       public IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy();
        }

        public IGetWinnerStrategy GetWinnerRule()
        {
            return new PlayerWinsOnEqualStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new InternationalNewGameStrategy();
        }

        public void Accept(IRulesVisitor a_visitor)
        {
            a_visitor.VisitEuropeanBasicHitRules(this);
        }
    }
}
