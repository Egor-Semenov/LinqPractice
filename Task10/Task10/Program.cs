using System;
using System.Collections.Generic;
using System.Linq;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new List<Player>
            {
                new Player { Name = "Alex", Team = "Arsenal", Score = 10 },
                new Player { Name = "Egor", Team = "Barselona", Score = 20 },
                new Player { Name = "Luke", Team = "Arsenal", Score = 60 },
                new Player { Name = "Lucy", Team = "Liverpul", Score = 40 },
                new Player { Name = "Tod", Team = "Barselona", Score = 25 }
            };

            var bestPlayers = FindBest(players);

            foreach (var player in bestPlayers)
            {
                Console.WriteLine($"{player.Team} - {player.Score}");
            }
        }

        //<summary>
        //Each player belongs to a team and have a score. 
        //Find best player's score in each team
        //</summary>
        static Player[] FindBest(List<Player> players)
        {
            var bestPlayers = from player in players
                              group player by player.Team into playerGroup
                              select new Player
                              {
                                  Team = playerGroup.Key,
                                  Score = playerGroup.Max(player => player.Score)
                              };

            return bestPlayers.ToArray();
        }
    }
}

class Player
{
    public string Name { get; set; }
    public string Team { get; set; }
    public int Score { get; set; }
}
