using NClap.Repl;
using Console = Colorful.Console;

namespace MinesweeperConsole
{
    class Program
    {
        static ConsoleOutputService consoleOutputService = new ConsoleOutputService();

        static void Main(string[] args)
        {
            GameSingleton singleton = GameSingleton.Instance;
            singleton.RecreateBoard(3, 5, 10);

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
