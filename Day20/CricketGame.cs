using System;

class Cricket
{
    public int[] runs = { 0, 1, 2, 3, 4, 6 };
    Random random = new Random();
    public void Play()
    {
        int team1Score = 0;
        for (int i = 0; i < 6; i++)
        {
            team1Score += runs[random.Next(runs.Length)];
        }
        Console.WriteLine("Team 1 scored: " + team1Score);

        int team2Score = 0;
        for (int i = 0; i < 6; i++)
        {
            team2Score += runs[random.Next(runs.Length)];
        }
        Console.WriteLine("Team 2 scored: " + team2Score);

        if (team1Score > team2Score)
        {
            Console.WriteLine("Team 1 wins!");
        }
        else if (team2Score > team1Score)
        {
            Console.WriteLine("Team 2 wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}
class Program
{
    static void Main()
    {
        Cricket game = new Cricket();
        game.Play();
    }
}
