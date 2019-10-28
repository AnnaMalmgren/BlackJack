
namespace BlackJack.controller
{
    class PlayGame : model.IGetCardObserver
    {
        private model.Game m_game;

        private view.IView m_view;

        private int g_sleepTime = 700;

        public PlayGame(model.Game a_game, view.IView a_view)
        {
            m_game = a_game;
            m_view = a_view;
            m_game.AddSubscribers(this);
        }
        public bool Play()
        {
            ShowGameView();
            
            if (m_game.IsGameOver())
            {
                m_view.DisplayGameOver(m_game.IsDealerWinner());
            }

            view.Event input = m_view.GetInput();

            if (input == view.Event.PlayGame)
            {
                m_game.NewGame();
            }
            else if (input == view.Event.Hit)
            {
                m_game.Hit();
            }
            else if (input == view.Event.Stand)
            {
                m_game.Stand();
            }

            return input != view.Event.Quit;
        }

        private void ShowGameView() 
        {
            m_view.DisplayWelcomeMessage();
            m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
            m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());
        }

        public void CardDealt()
        {
            System.Threading.Thread.Sleep(g_sleepTime);
            ShowGameView();
        }

    }
}
