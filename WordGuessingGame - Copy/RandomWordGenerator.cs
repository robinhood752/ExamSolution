using System;
using CodenameGenerator.WordRepos;

namespace WordGuessingGame
{
    public class RandomWordGenerator : IGenerator
    {
        private static readonly NounsRepository words = new NounsRepository();
        private static readonly int size = words.Get().Length;

        public string Generate() 
        {
            return words.Get()[new Random().Next(size)];
        }
    }
}
