using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;

            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                // generate random number between 1 and 100. The +1 number is exclusive.s
                number = random.Next(min, max + 1);

                while(guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }

            
        }
    }
}
