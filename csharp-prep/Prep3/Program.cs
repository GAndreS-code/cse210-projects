using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber) {
            Console.Write( "Guess the number. ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess) {
                Console.WriteLine("Nope! Try a higher number.");
            } 
            else if (magicNumber < guess) {
                Console.WriteLine("Wrong! Give me a lower number.");
            }
            else {
                Console.WriteLine("You got it!");
            }

        }
    }
}