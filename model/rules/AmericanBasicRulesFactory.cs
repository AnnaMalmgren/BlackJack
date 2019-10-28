namespace BlackJack.model.rules
{
    class AmericanBasicRulesFactory : IAbstractRulesFactory
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
            return new AmericanNewGameStrategy();
        }

        public void Accept(IRulesVisitor a_visitor)
        {
            a_visitor.VisitAmericanBasicHitRules(this);
        }
    }
}
