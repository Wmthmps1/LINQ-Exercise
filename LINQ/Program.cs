using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        public static IEnumerable<string> SortGames(IEnumerable<string> games)
        {
            var sortedGameList = games.OrderBy(game => game.Length);
            return sortedGameList;
        }


        static void Main(string[] args)
        {
            var games = new List<string> {"Sonic", "Pokemon", "Call of Duty", "Minecraft", "FIFA"};
            var newGameList = SortGames(games);

            foreach (var game in newGameList)
            {
                Console.WriteLine(game);
            }
        }
    }
}

/*
    Create a list of video game names...
    Order the list of games by length of the game name.
    Use the lambda expression in this exercise as well.
    use Method Syntax for this exercise

 */