using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NClap.Metadata;

namespace MinesweeperConsole
{


    class OpenCommand : Command
    {
        GameSingelton singelton = GameSingelton.Instance;
        ConsoleOutputService service = new ConsoleOutputService();


        [PositionalArgument(ArgumentFlags.Required, Position = 0, Description = "Open X")]
        public int X { get; set; }

        [PositionalArgument(ArgumentFlags.Required, Position = 1, Description = "Open Y")]
        public int Y { get; set; }

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            singelton.Cells[X, Y].Open();
            service.UpdateConsole();

            return Task.FromResult(CommandResult.Success);
        }
    }
}
