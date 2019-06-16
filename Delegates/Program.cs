using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new PlayerStats[] {
                new PlayerStats
                {
                    name = "Gam3r",
                    kills = 10,
                    flagsCaptured = 4
                },
                new PlayerStats
                {
                    name = "Gamssss3r",
                    kills = 11,
                    flagsCaptured = 2
                },
                new PlayerStats
                {
                    name = "Gssssamssss3r",
                    kills = 1,
                    flagsCaptured = 10
                }
            };

            var klaasa = new DisplayPlayerNames();

            Console.WriteLine(klaasa.OnGameOver(players));

        }
    }
}
