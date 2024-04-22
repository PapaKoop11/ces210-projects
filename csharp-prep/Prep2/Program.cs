using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string getVariable = Console.ReadLine();
        int grade = int.Parse(getVariable);

        string letterGrade = "";
        string addOn = "";

        if (grade >= 90) 
        {            
            letterGrade = "A";
        }
        else if (grade >= 80) 
        {            
            letterGrade = "B";
        }
        else if (grade >= 70) 
        {            
            letterGrade = "C";
        }
        else if (grade >= 60) 
        {            
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade < 93 && grade >= 60)
        {
            if (grade%10 >= 7)
            {
                addOn = "+";
            }
            else if (grade%10 < 3)
            {
                addOn = "-";
            }            
        }

        Console.WriteLine($"Your grade is {letterGrade + addOn}.");
        if (grade >= 70)
        {
            Console.WriteLine("Congrtulations! You passed this course.");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
        
    }
}