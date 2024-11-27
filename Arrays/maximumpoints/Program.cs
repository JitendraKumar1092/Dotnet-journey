namespace JaggedArray //DO NOT change the namespace name
{
    using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students");
        int numStudents = int.Parse(Console.ReadLine());
        int[][] points = new int[numStudents][];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Enter the number of competitions attended by student {i + 1}");
            int numCompetitions = int.Parse(Console.ReadLine());
            points[i] = new int[numCompetitions];

            Console.WriteLine($"Enter the student {i + 1} points");
            for (int j = 0; j < numCompetitions; j++)
            {
                points[i][j] = int.Parse(Console.ReadLine());
            }
        }

        string result = FindWhoGotMaximumPoints(points);
        Console.WriteLine(result);
    }

    public static string FindWhoGotMaximumPoints(int[][] points)
    {
        int numStudents = points.Length;
        int maxPoints = 0;
        int studentIndex = 0;

        for (int i = 0; i < numStudents; i++)
        {
            int totalPoints = 0;
            for (int j = 0; j < points[i].Length; j++)
            {
                totalPoints += points[i][j];
            }

            if (totalPoints > maxPoints)
            {
                maxPoints = totalPoints;
                studentIndex = i;
            }
        }

        return $"Student {studentIndex + 1} got maximum points";
    }
}
}
