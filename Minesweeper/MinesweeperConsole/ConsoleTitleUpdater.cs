using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperConsole
{
    public class ConsoleTitleUpdater
    {
        private Stopwatch stopwatch = new Stopwatch();

        public string TitleValue { get; set; } = "Good Luck";

        public void Start()
        {
            stopwatch.Start();

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(1000);

                    string title = stopwatch.Elapsed.Seconds.ToString();
                    Console.Title = $"[{title}] {TitleValue}";
                }
            });
        }

        private async void Action()
        {

        }

        public void Stop()
        {

        }
    }
}
