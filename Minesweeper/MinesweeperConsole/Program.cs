using NClap.Repl;
using Console = Colorful.Console;

namespace MinesweeperConsole
{
    class Program
    {
        static ConsoleOutputService consoleOutputService = new ConsoleOutputService();

        static void Main(string[] args)
        {
            GameSingelton singelton = GameSingelton.Instance;
            singelton.RecreateBoard(10, 10, 10);

            consoleOutputService.UpdateConsole();

            GameLoop();

            Console.ReadKey();
        }

        private static void GameLoop()
        {
            var loop = new Loop(typeof(MyCommand));
            loop.Execute();
        }

    }
}
