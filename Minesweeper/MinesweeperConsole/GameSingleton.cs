using BusinessLogic;

namespace MinesweeperConsole
{
    public class GameSingleton
    {
        private static GameSingleton instance;
        

        public PlayBoard Board { get; private set; }
       

        private GameSingleton()
        {
        }

        public static GameSingleton Instance => instance ?? (instance = new GameSingleton());

        public void RecreateBoard(int width, int height, int mineCount)
        {
            Board = new PlayBoard(width, height, mineCount);
        }
    }
}