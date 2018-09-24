using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic;
using NClap.Metadata;

namespace MinesweeperConsole
{
    class OpenCommand : Command
    {
        
        private PlayBoard board;
        ConsoleOutputService service = new ConsoleOutputService();

        [PositionalArgument(ArgumentFlags.Required, Position = 0, Description = "Open X")]
        public int X { get; set; }

        [PositionalArgument(ArgumentFlags.Required, Position = 1, Description = "Open Y")]
        public int Y { get; set; }

        public OpenCommand()
        {
            GameSingleton singleton = GameSingleton.Instance;
            board = singleton.Board;
        }

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            board.OpenCell(X, Y);

            var status = board.Status;

            ServiceLocator.ConsoleTitleUpdater.TitleValue = status.ToString();


            service.UpdateConsole();

            return Task.FromResult(CommandResult.Success);
        }
    }
}
