using System;
using System.Collections.Generic;

namespace Gaming
{
    class Ranking
    {
        public List<Player> ranks = new List<Player>();
        public string bestPlayerName;
        public int bestPlayerScore;

        public void GenerateRanking(int numberOfPlayers)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                var newPlayer = new Player { Name = $"Player_{i}", Score = new Random().Next(0, 3000) };
                ranks.Add(newPlayer);
                Console.WriteLine(newPlayer.playerInfo);
            }
        }
        public void ShowRanking()
        {
            for (int i = 0; i < this.ranks.Count; i++)
            {
                Console.WriteLine(this.ranks[i].Name);
                Console.WriteLine(this.ranks[i].Score);
            }
        }
        public void BestPlayer()
        {
            for (int i = 0; i < this.ranks.Count; i++)
            {
                if (i == 0)
                {
                    this.bestPlayerScore = this.ranks[i].Score;
                    this.bestPlayerName = this.ranks[i].Name;
                }
                else if (i == this.ranks.Count - 1)
                {
                    Console.WriteLine($"And the best player is {this.bestPlayerName} with a score of {this.bestPlayerScore}");
                }

                if (this.ranks[i].Score > this.bestPlayerScore)
                {
                    this.bestPlayerName = this.ranks[i].Name;
                    this.bestPlayerScore = this.ranks[i].Score;
                }
            }
        }
    }
}
