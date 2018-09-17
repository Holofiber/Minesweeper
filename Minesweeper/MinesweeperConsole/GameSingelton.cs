using BusinessLogic;

namespace MinesweeperConsole
{
    public class GameSingelton
    {
        private static GameSingelton instance;
        

        public PlayBoard Board { get; private set; }
        public Cell[,] Cells { get; private set; }

        private GameSingelton()
        {
        }

        public static GameSingelton Instance => instance ?? (instance = new GameSingelton());

        public void RecreateBoard(int width, int height, int mineCount)
        {
            Board = new PlayBoard(width, height, mineCount);
            Cells = Board.GetCellValues();
        }
    }
}