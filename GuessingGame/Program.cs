﻿using System;

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
                number = random.Next(min, max + 1);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
