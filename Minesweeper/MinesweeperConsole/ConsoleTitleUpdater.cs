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

        public void Start()
        {
            stopwatch.Start();

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(1000);

                    Console.Title = stopwatch.Elapsed.Seconds.ToString();
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
