using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    
    {   //intro- so it doesn't repeat the instructions in the loop
        Console.WriteLine("Welcome to List Them Numbers");
        Console.WriteLine("Please type each number by pressing enter, then it will be added, mean found, also finding the max and minimal number.");

        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            
            Console.WriteLine("When you are done by making your list. Please type: 0");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //When it is not 0 add the number to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //Add the sum from the list the user created.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Your total is: {sum}");

        float mean = ((float)sum) / numbers.Count;
        Console.WriteLine($"The mean is: {mean}");

        int max = numbers[0];
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is: {max}");

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The minimal number is: {min}");
        numbers.Sort();
        Console.WriteLine("Number List:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}