using System;

namespace BlackJack.view
{
    class SwedishRulesPrintVisitor : model.IRulesVisitor
    {
        public void VisitAmericanSoft17Rules(model.rules.AmericanSoft17RulesFactory a_americanRules)
        {
            Console.WriteLine("Regler: Amerikanska regler, med 'soft 17'. Given vinner vid lika poäng");
        }
        public void VisitAmericanBasicHitRules(model.rules.AmericanBasicRulesFactory a_americanRules)
        {
            Console.WriteLine("Regler: Amerikanska regler. Utan 'soft 17'. Spelaren vinner vid lika poäng.");
        }
        public void VisitEuropeanSoft17Rules(model.rules.EuropeanSoft17RulesFactory a_europeanRules)
        {
            Console.WriteLine("Regler: Europeiska regler, med 'soft 17'. Given vinner vid lika poäng.");
        }
        public void VisitEuropeanBasicHitRules(model.rules.EuropeanBasicRulesFactory a_europeanRules)
        {
            Console.WriteLine("Regler: Europeiska regler. Utan 'soft 17'. Spelaren vinner vid lika poäng.");
        }

    }

}