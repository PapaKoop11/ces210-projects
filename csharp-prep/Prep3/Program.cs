using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        int i = 0;
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 99);

    //    Console.WriteLine(magicNum);

            while (magicNum != guess)
            {
                Console.Write("Try to guess the Magic Number. ");
                string getReGuess = Console.ReadLine();
                guess = int.Parse(getReGuess);

                i++;

                if (guess < magicNum)
                {
                    Console.WriteLine("Guess Higher");
                }
                else if (guess > magicNum)
                {
                    Console.WriteLine("Guess Lower");
                }
                else if (guess == magicNum)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"You guessed it in 1 try! Did you cheat?");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in {i} tries!");
                    }
                }
            }  
        Console.Write("Would you like to play again? If so, type yes ");
        playAgain = Console.ReadLine();       
        }       
    }
}