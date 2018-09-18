using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperConsole
{
    static class ServiceLocator
    {
        public static ConsoleOutputService ConsoleOutputService { get; } = new ConsoleOutputService();
        public static ConsoleTitleUpdater ConsoleTitleUpdater { get; } = new ConsoleTitleUpdater();
    }
}
