using System;
using System.Collections.Generic;
using System.Linq;

//1:27

namespace Task06_Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialSongs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Queue<string> songs = new Queue<string>(initialSongs);

            while (songs.Any())
            {
                string[] nextComand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray(); 

                switch (nextComand[0].ToUpper())
                {
                    case "PLAY":
                        songs.Dequeue();
                        break;

                    case "ADD":
                        string songTitle = string.Empty;
                        for (int i = 1; i <= nextComand.Length - 2; i++)
                        {
                            songTitle = songTitle + nextComand[i] + " ";
                        }
                        songTitle += nextComand[nextComand.Length - 1];
                        
                        if(songs.Contains(songTitle))
                        {
                            Console.WriteLine($"{songTitle} is already contained!"); 
                        }
                        else
                        {
                            songs.Enqueue(songTitle); 
                        }
                        break;

                    case "SHOW":
                        if(songs.Any())
                        {
                            Console.WriteLine(string.Join(", ", songs));
                        }
                        break;
                    
                    default:
                        break;
                }
            }
            
            Console.WriteLine("No more songs!");
        }
    }
}
