using System;

namespace H3D_GuessGame
{
    class GuessGame
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);
            int guess;
            int guesses = 0;

            Console.Write("What number am I thinking of? ");
            guess = Convert.ToInt32(Console.ReadLine());
            guesses++;


            while (guess != number)
            {
                Console.WriteLine("Sorry, that's incorrect. Try again.");
                if (guess < number)
                {
                    Console.WriteLine("Too low.");
                }
                else 
                {
                    Console.WriteLine("Too high.");
                }
                guess = Convert.ToInt32(Console.ReadLine());
                guesses++;
            }

            Console.WriteLine($"Congratulations! It took you {guesses} tries!");
        }
    }
}
