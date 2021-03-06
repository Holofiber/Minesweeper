using System;
using NClap.Repl;
using Console = Colorful.Console;

namespace MinesweeperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSingleton singleton = GameSingleton.Instance;
            singleton.RecreateBoard(5, 5, 1);

            ServiceLocator.ConsoleOutputService.UpdateConsole();

            ServiceLocator.ConsoleTitleUpdater.Start();

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
