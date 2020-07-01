using System;
using Ranking = Gaming.Ranking;

namespace testProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Ranking ranking = new Ranking();

            ranking.GenerateRanking(100);

            ranking.ShowRanking();

            ranking.BestPlayer();
        }
    }
}