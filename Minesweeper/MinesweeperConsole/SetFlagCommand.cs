using System.Threading;
using System.Threading.Tasks;
using NClap.Metadata;

namespace MinesweeperConsole
{
    class SetFlagCommand : Command
    {
        ConsoleOutputService service = new ConsoleOutputService();
        private GameSingelton singelton = GameSingelton.Instance;

        [PositionalArgument(ArgumentFlags.Required, Position = 0, Description = "SetFlag X")]
        public int X { get; set; }

        [PositionalArgument(ArgumentFlags.Required, Position = 1, Description = "SetFlag Y")]
        public int Y { get; set; }

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            singelton.Cells[X, Y].SetFlag();

            service.UpdateConsole();

            return Task.FromResult(CommandResult.Success);
        }
    }
}