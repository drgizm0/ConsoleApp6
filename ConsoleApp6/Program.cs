// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        double[] scores = new double[5];

        // Putting the scores
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter score {i + 1}: ");
            scores[i] = double.Parse(Console.ReadLine());
        }

        // Computing the average score
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += scores[i];
        }
        double average = sum / 5;

        // Display average score
        Console.WriteLine($"Average score: {average:F2}");

        if (average >= 75)
        {
            Console.WriteLine("Passed (Sana all)");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }
}
