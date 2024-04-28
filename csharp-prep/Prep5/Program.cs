using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int favNumSq = SquareNumber(favNumber);
        DisplayResults(userName, favNumSq);

        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
            
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumberStr = Console.ReadLine();
            int userNumber = int.Parse(userNumberStr);
            return userNumber;
            
        }

        static int SquareNumber(int numToSquare)
        {
            int squaredNumber = numToSquare * numToSquare;
            return squaredNumber;
            
        }

        static void DisplayResults(string name, int num)
        {   
            Console.WriteLine($"{name}, the square of your favorite number is {num}. ");
        }
    }
}