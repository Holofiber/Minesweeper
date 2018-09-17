using System.Threading;
using System.Threading.Tasks;
using NClap.Metadata;

namespace MinesweeperConsole
{

    class RemoveFlagCommand : Command
    {
        ConsoleOutputService service = new ConsoleOutputService();
        private GameSingelton singelton = GameSingelton.Instance;

        [PositionalArgument(ArgumentFlags.Required, Position = 0, Description = "RemoveFlag X")]
        public int X { get; set; }

        [PositionalArgument(ArgumentFlags.Required, Position = 1, Description = "RemoveFlag Y")]
        public int Y { get; set; }

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            singelton.Cells[X, Y].RemoveFlag();
            service.UpdateConsole();

            return Task.FromResult(CommandResult.Success);
        }
    }
}