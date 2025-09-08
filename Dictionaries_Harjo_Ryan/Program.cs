using System;
using System.Collections.Generic;
using System.Collections;


namespace Dictionaries_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary with int key and string value
            var topGames = new Dictionary<int, string>();

            // Add top 10 favorite games
            topGames[1] = "Assassin's Creed 3";
            topGames[2] = "God of War (2018)";
            topGames[3] = "Red Dead Redemption";
            topGames[4] = "Batman: Arkham City";
            topGames[5] = "Marvel's Spider-Man: Miles Morales";
            topGames[6] = "GoldenEye 007";
            topGames[7] = "Super Mario Bros. 3";
            topGames[8] = "Need for Speed: Underground 2";
            topGames[9] = "Def Jam: Fight for NY";
            topGames[10] = "Grand Theft Auto V";

            // Loop through topGames and print key/value pairs
            foreach (var kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Check if key 1 exists and print favorite game
            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}");
            }

            // TryGetValue for key 11
            string result;
            if (topGames.TryGetValue(11, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position.");
            }

            // Switch the dictionary entry at key 5 with a new game, check key exists first
            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Ghost of Tsushima"; // New game I enjoy playing
            }

            // Print the new value at key 5
            Console.WriteLine($"New game at key 5: {topGames[5]}");

            // Create a new Hashtable and set it equal to topGames
            Hashtable hashtable = new Hashtable(topGames);

            // Create a string called favGame
            string favGame = hashtable[1] as string;

            // Print favGame to console
            // Print the favorite game retrieved from the hashtable using key 1
            Console.WriteLine($"Favorite game from Hashtable: {favGame}");

            // Create another hashtable with collection-initializer syntax
            Hashtable capitals = new Hashtable()
        {
            { "California", "Sacramento" },
            { "Texas", "Austin" },
            { "New York", "Albany" },
            { "Florida", "Tallahassee" }
        };

            // Loop through capitals and print key/value pairs
            foreach (DictionaryEntry entry in capitals)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            // Clear all elements in capitals
            capitals.Clear();
        }
    }
  
    
}
