using System.Threading;
using System.Threading.Tasks;
using NClap.Metadata;

namespace MinesweeperConsole
{
    class OpenAllCommand : Command
    {
        private GameSingelton singelton = GameSingelton.Instance;
        ConsoleOutputService service = new ConsoleOutputService();

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            foreach (var cell in singelton.Cells)
            {
                cell.Open();
            }

            service.UpdateConsole();

            return Task.FromResult(CommandResult.Success);
        }
    }
}