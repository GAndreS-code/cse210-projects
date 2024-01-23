using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0) {
            Console.WriteLine("Please enter a number (type 0 to calculate): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0) {
                numbers.Add(userNumber);
            }
        }
        // computing the sum of the numbers
        int sum = 0;
        foreach (int number in numbers) {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        // computing the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // find the maximum value
        int max = numbers[0];

        foreach (int number in numbers) {
            if (number > max) {
                max = number;
            }
        }

            Console.WriteLine($"The maximum value is: {max}");
    }
    }