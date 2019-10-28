using System;
using System.Collections.Generic;

namespace BlackJack.view
{
    class SimpleView : IView
    {
        private RulesPrintVisitor m_rulePrintVisitor;

        private model.rules.IAbstractRulesFactory m_rules;

        public SimpleView(model.rules.IAbstractRulesFactory a_rules)
        {
            m_rulePrintVisitor = new RulesPrintVisitor();
            m_rules = a_rules;
        }

        public void DisplayWelcomeMessage()
        {
            System.Console.Clear();
            System.Console.WriteLine("Hello Black Jack World");
            System.Console.WriteLine("----------------------");
            m_rules.Accept(m_rulePrintVisitor);
            System.Console.WriteLine("-----------------------------------------------------------");
            System.Console.WriteLine("Type 'p' to Play, 'h' to Hit, 's' to Stand or 'q' to Quit\n");
        }

        public Event GetInput()
        {
            switch (System.Console.ReadKey().KeyChar)
            {
                case 'p': 
                return Event.PlayGame;
                case 'h': 
                return Event.Hit;
                case 's': 
                return Event.Stand;
                case 'q': 
                return Event.Quit;
                default: 
                return Event.None;
            }
        }

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());
        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Player", a_hand, a_score);
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Dealer", a_hand, a_score);
        }

        private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine("{0} Has: ", a_name);
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }
            System.Console.WriteLine("Score: {0}", a_score);
            System.Console.WriteLine("");
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write("GameOver: ");
            if (a_dealerIsWinner)
            {
                System.Console.WriteLine("Dealer Won!");
            }
            else
            {
                System.Console.WriteLine("You Won!");
            }
            
        }
    }
}
