using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class DisplayPlayerNames
    {
        public delegate int ScoreDelegate(PlayerStats stats);

        public string OnGameOver(PlayerStats[] allPlayerStats)
        {
            string PlayerNameMostKills = GetPlayerNameTopScore(allPlayerStats, stats => stats.kills);
            string PlayerNameMostFlagsCaptured = GetPlayerNameTopScore(allPlayerStats, stats => stats.flagsCaptured);

            return "score: " + PlayerNameMostKills + " " + PlayerNameMostFlagsCaptured;
        }

        //int ScoreByKillCount(PlayerStats stats) // this method is the same as calling lambda expression stats=>stats.kills
        //{
        //    return stats.kills;
        //}
        //int ScoreByFlagsCaptured(PlayerStats stats)
        //{
        //    return stats.flagsCaptured;
        //}

        public string GetPlayerNameTopScore(PlayerStats[] allPlayerStats,ScoreDelegate scoreCalculator)
        {
            string name = "";
            int bestScore = 0;

            foreach (PlayerStats stats in allPlayerStats)
            {
                int score = scoreCalculator(stats);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = stats.name;
                }
            }
            return name;
        }


        //string GetPlayerNameMostFlagsCaptured(PlayerStats[] allPlayerStats)
        //{
        //    string name = "";
        //    int bestScore = 0;

        //    foreach (PlayerStats stats in allPlayerStats)
        //    {
        //        int score = stats.flagsCaptured;
        //        if (score> bestScore)
        //        {
        //            bestScore = score;
        //            name = stats.name;
        //        }
        //    }
        //    return name;
        //}

        //string GetPlayerNameMostKills(PlayerStats[] allPlayerStats)
        //{
        //    string name = "";
        //    int bestScore = 0;

        //    foreach (PlayerStats stats in allPlayerStats)
        //    {
        //        int score = stats.kills;
        //        if (score > bestScore)
        //        {
        //            bestScore = score;
        //            name = stats.name;
        //        }
        //    }
        //    return name;
        //}
    }
}
