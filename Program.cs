

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            model.rules.IAbstractRulesFactory rules = new model.rules.AmericanSoft17RulesFactory();
            model.Game g = new model.Game(rules);
            view.IView v = new view.SimpleView(rules); // new view.SwedishView();
            controller.PlayGame ctrl = new controller.PlayGame(g, v);

            while (ctrl.Play());
        }
    }
}
