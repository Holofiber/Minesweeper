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
        GameSingelton singelton = GameSingelton.Instance(0, 0, 0);


        [PositionalArgument(ArgumentFlags.Required, Position = 0, Description = "Open X")]
        public int X { get; set; }

        [PositionalArgument(ArgumentFlags.Required, Position = 1, Description = "Open Y")]
        public int Y { get; set; }

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            singelton.Cells[X, Y].Open();
            
            return Task.FromResult(CommandResult.Success);
        }
    }

    class SetFlagCommand : Command
    {
        private GameSingelton singelton = GameSingelton.Instance(0, 0, 0);

        [PositionalArgument(ArgumentFlags.Required, Position = 0, Description = "SetFlag X")]
        public int X { get; set; }

        [PositionalArgument(ArgumentFlags.Required, Position = 1, Description = "SetFlag Y")]
        public int Y { get; set; }

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            singelton.Cells[X, Y].SetFlag();

            return Task.FromResult(CommandResult.Success);
        }
    }

    class RemoveFlagCommand : Command
    {
        private GameSingelton singelton = GameSingelton.Instance(0, 0, 0);

        [PositionalArgument(ArgumentFlags.Required, Position = 0, Description = "RemoveFlag X")]
        public int X { get; set; }

        [PositionalArgument(ArgumentFlags.Required, Position = 1, Description = "RemoveFlag Y")]
        public int Y { get; set; }

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            singelton.Cells[X, Y].RemoveFlag();

            return Task.FromResult(CommandResult.Success);
        }
    }

    class OpenAllCommand : Command
    {
        private GameSingelton singelton = GameSingelton.Instance(0, 0, 0);

        public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            foreach (var cell in singelton.Cells)
            {
                cell.Open();
            }

            return Task.FromResult(CommandResult.Success);
        }
    }

    enum MyCommand
    {
        [Command(typeof(OpenCommand), Description = "Open X Y")] Open,

        [Command(typeof(SetFlagCommand), Description = "SetFlag X Y")] SetFlag,

        [Command(typeof(RemoveFlagCommand), Description = "RemoveFlag X Y")] RemoveFlag,

        [Command(typeof(OpenAllCommand), Description = "Open all cells")] OpenAll,

    }

}
