
namespace BlackJack.model.rules
{
    interface IAbstractRulesFactory
    {
        INewGameStrategy GetNewGameRule();
        IHitStrategy GetHitRule();
        IGetWinnerStrategy GetWinnerRule();

    }
}