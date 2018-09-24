using System.Threading;
using System.Threading.Tasks;
using NClap.Metadata;

namespace MinesweeperConsole
{
    class OpenAllCommand : Command
    {
        private GameSingleton singleton = GameSingleton.Instance;
        ConsoleOutputService service = new ConsoleOutputService();

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            singleton.Board.OpenAllCell();

            service.UpdateConsole();

            return Task.FromResult(CommandResult.Success);
        }
    }
}