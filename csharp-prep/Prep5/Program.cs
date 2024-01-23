using System;

class Program
{
    static void Main(string[] args)
    {
        DisplaySpecialMessage();
        static void DisplaySpecialMessage() {
            Console.WriteLine("Welcome to the Program!");
        }

        string yourName = inputName();
        static string inputName() {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        int yourNumber = inputNumber();
        static int inputNumber() {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        int numberSquared = squareNumber(yourNumber);
        static int squareNumber(int number) {
            int square = number * number;
            return square;
        }
        
        DisplayEverything(yourName, numberSquared);
        static void DisplayEverything(string name, int square) {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}