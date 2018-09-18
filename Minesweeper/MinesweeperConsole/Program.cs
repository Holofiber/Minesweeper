using System;
using NClap.Repl;
using Console = Colorful.Console;

namespace MinesweeperConsole
{
    class Program
    {
        static ConsoleOutputService consoleOutputService = new ConsoleOutputService();
        static ConsoleTitleUpdater titleUpdater = new ConsoleTitleUpdater();

        static void Main(string[] args)
        {
            Console.Title = DateTime.Now.ToLongTimeString();

            GameSingleton singleton = GameSingleton.Instance;
            singleton.RecreateBoard(10, 10, 10);

            consoleOutputService.UpdateConsole();

            titleUpdater.Start();

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
