using BusinessLogic;

namespace MinesweeperConsole
{
    public class GameSingelton
    {
        private static GameSingelton instance;
        private static int _width;
        private static int _hight;
        private static int _mines;

        public PlayBoard Board { get; private set; }
        public Cell[,] Cells { get; private set; }

        private GameSingelton()
        {
            RecreateBoard();
        }

        public static GameSingelton Instance(int width, int height, int mineCount)
        {
            if (instance == null)
            {
                
                _width = width;
                _hight = height;
                _mines = mineCount;
                instance = new GameSingelton();
            }

            return instance;
        }

        public void RecreateBoard()
        {
            Board = new PlayBoard(_width, _hight, _mines);
            Cells = Board.GetCellValues();
        }

    }
}
