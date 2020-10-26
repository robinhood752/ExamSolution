using System;

namespace WordGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int guesses = 
                    new Round(new RandomWordGenerator()).Play();

                Console.Clear();
                Console.WriteLine($"You guessed after {guesses} guesses");
                Console.ReadLine();
            }
        }
    }
}
