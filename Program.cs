using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>();
            games.Add("Mortal Combat");
            games.Add("Eternal Warriors");
            games.Add("Mario Brothers");
            games.Add("Sonic");
            games.Add("Zelda");


            var order = games.OrderBy(x => x.Length);
            foreach( var game in order)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Where practice");
            Console.WriteLine(" ");

            var TwoWords = games.Where(x => x.Contains(" "));
            foreach (var game in TwoWords)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Average practice");
            Console.WriteLine(" ");

            var avWordCount = games.Average(x => x.Length);
            
                Console.WriteLine(avWordCount);
            Console.WriteLine(" ");
            Console.WriteLine("Take & Append practice");
            Console.WriteLine(" ");

            var gamesUpdate = games.Take(3).Append("Rampage");
            foreach (var game in gamesUpdate)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine(" ");
            Console.WriteLine("OrderBy practice");
            Console.WriteLine(" ");

            var gamesOrder = games.OrderBy(x => x.Length);
            foreach(var game in gamesOrder)
            {
                Console.WriteLine(game);
            }
        }
        
    }
}
