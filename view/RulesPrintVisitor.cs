using System;

namespace BlackJack.view
{
    class RulesPrintVisitor : model.IRulesVisitor
    {
        public void VisitAmericanSoft17Rules(model.rules.AmericanSoft17RulesFactory a_americanRules)
        {
            Console.WriteLine("Rules in use are: American rules, with soft 17. The dealer wins on equal score");
        }
        public void VisitAmericanBasicHitRules(model.rules.AmericanBasicRulesFactory a_americanRules)
        {
            Console.WriteLine("Rules in use are: American rules. No soft 17. The player wins on equal score.");
        }
        public void VisitEuropeanSoft17Rules(model.rules.EuropeanSoft17RulesFactory a_europeanRules)
        {
            Console.WriteLine("Rules in use are: European rules, with soft 17. The dealer wins on equal score.");
        }
        public void VisitEuropeanBasicHitRules(model.rules.EuropeanBasicRulesFactory a_europeanRules)
        {
            Console.WriteLine("Rules in use are: European rules. No soft 17. The player wins on equal score.");
        }

    }

}