namespace BlackJack.model
{
    interface IRulesVisitor
    {
        void VisitAmericanSoft17Rules(rules.AmericanSoft17RulesFactory a_americanRules);
        void VisitAmericanBasicHitRules(rules.AmericanBasicRulesFactory a_americanRules);
        void VisitEuropeanSoft17Rules(rules.EuropeanSoft17RulesFactory a_europeanRules);
        void VisitEuropeanBasicHitRules(rules.EuropeanBasicRulesFactory a_europeanRules);
    }
}