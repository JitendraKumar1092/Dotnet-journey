


namespace TheRankFinder //DO NOT change the namespace name
{


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students");
        int numStudents = int.Parse(Console.ReadLine());
        int[,] stdMarks = new int[numStudents, 5];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Enter marks for Student {i + 1}");
            for (int j = 0; j < 5; j++)
            {
                stdMarks[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[] ranks = FindStudentsRank(stdMarks);

        for (int i = 0; i < ranks.Length; i++)
        {
            Console.WriteLine($"Rank of student {i + 1} is {ranks[i]}");
        }
    }

    public static int[] FindStudentsRank(int[,] stdMarks)
    {
        int numStudents = stdMarks.GetLength(0);
        int[] totalMarks = new int[numStudents];
        int[] ranks = new int[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                totalMarks[i] += stdMarks[i, j];
            }
        }

   
        for (int i = 0; i < numStudents; i++)
        {
            int rank = 1;
            for (int j = 0; j < numStudents; j++)
            {
                if (totalMarks[j] > totalMarks[i])
                {
                    rank++;
                }
            }
            ranks[i] = rank;
        }

        return ranks;
    }
}
}