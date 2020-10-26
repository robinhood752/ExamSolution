using System;
using System.Collections.Generic;
using System.Linq;

namespace WordGuessingGame
{
    public class Round
    {
        private int guesses = 0;
        private readonly List<char> word;
        private readonly ISet<char> wordWatcher;

        public Round(IGenerator generator)
        {
            var val = generator
                .Generate()
                .ToLower()
                .ToCharArray();
            
            word = val.ToList();
            wordWatcher = val.ToHashSet();
        }

        public int Play()
        {
            while(wordWatcher.Count > 0)
            {
                Print();

                Console.WriteLine("Please guess next letter");
                var letter = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if(char.IsLetter(letter))
                {
                    if(wordWatcher.Contains(letter))
                    {
                        wordWatcher.Remove(letter);
                    }
                }

                guesses++;
            }

            return guesses;
        }

        private void Print()
        {
            word.ForEach(letter =>
            {
                if (wordWatcher.Contains(letter))
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write(letter);
                }
            });

            Console.WriteLine();
        }
    }
}
