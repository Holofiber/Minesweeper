using NClap.Metadata;

namespace MinesweeperConsole
{
    enum MyCommand
    {
        [Command(typeof(OpenCommand), Description = "Open X Y")] Open,

        [Command(typeof(SetFlagCommand), Description = "SetFlag X Y")] SetFlag,

        [Command(typeof(RemoveFlagCommand), Description = "RemoveFlag X Y")] RemoveFlag,

        [Command(typeof(OpenAllCommand), Description = "Open all cells")] OpenAll,

    }
}