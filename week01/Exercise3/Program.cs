using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator= new Random();
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            int magic= randomGenerator.Next(1, 101);
            Console.WriteLine(magic);

            int guess = 0;
            int guessCount = 0;

            while (guess != magic)
            {
            Console.Write("What is your guess? ");
            guess= int.Parse(Console.ReadLine());
            guessCount = guessCount + 1;
            

            if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            
            }
            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thank You  for playing. Bye!");
        

    }
}