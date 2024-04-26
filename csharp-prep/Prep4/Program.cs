using System;
using System.Globalization;

class Program
{    
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        float listSum = 0;    
        int numAdded = -1;
        int numLargest = 0;
        int numSmallestPositive = 999;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (numAdded != 0)
            {
                Console.Write("Enter number: ");
                string numEntered = Console.ReadLine();
                numAdded = int.Parse(numEntered);
                if (numAdded != 0) {
                    numList.Add(numAdded);
                    if (numAdded > numLargest) 
                    {
                        numLargest = numAdded;
                    }
                    if (numAdded <= numSmallestPositive && numAdded > 0)
                    {
                        numSmallestPositive = numAdded;
                    }
                }            
                
            }    
        Console.WriteLine($"Number of items in list is {numList.Count}");
        foreach (int num in numList)
        {
            listSum += num;
        }
        Console.WriteLine($"The sum is {listSum}.");
        Console.WriteLine($"The average is: {listSum / numList.Count}");
        Console.WriteLine($"The largest number is {numLargest}.");
        Console.WriteLine($"The smallest positive number is {numSmallestPositive}.");
        numList.Sort();
        foreach(int newNum in numList)
        {
            Console.WriteLine(newNum);
        }
        
    }
}