using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();

        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        int userNum = int.Parse(input);

        while (userNum != 0)
        {
            userNumbers.Add(userNum);
            Console.Write("Enter a number: ");
            input = Console.ReadLine();

            userNum = int.Parse(input);
        }
        if (userNum == 0)
        {
            int sum = 0;
            foreach (int number in userNumbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");
            
            float average = ((float)sum) / userNumbers.Count;
            Console.WriteLine($"The average is: {average}");

            int largestNum = userNumbers[0];

            foreach (int number in userNumbers)
            {
                if (number > largestNum)
                {
                    largestNum = number;
                }
            }
            Console.WriteLine($"The largest number is: {largestNum}"); 
        }
    }
}