using System;

class Game
{
    private string[] choices = { "Stone", "Paper", "Scissor" };
    private Random random = new Random();
    private int playerScore = 0;
    private int computerScore = 0;

    public void Play()
    {
        Console.WriteLine("Enter your choice (Stone, Paper, Scissor): ");
        string userChoice = Console.ReadLine();
        userChoice = char.ToUpper(userChoice[0]) + userChoice.Substring(1).ToLower(); 

        if (!Array.Exists(choices, choice => choice == userChoice))
        {
            Console.WriteLine("Invalid choice. Please enter Stone, Paper, or Scissor.");
            return;
        }

        string computerChoice = choices[random.Next(choices.Length)];
        Console.WriteLine("Computer choice: " + computerChoice);
        string result = DetermineWinner(userChoice, computerChoice);

        Console.WriteLine(result);
        PrintScore();
    }

    private string DetermineWinner(string userChoice, string computerChoice)
    {
        if (userChoice == computerChoice)
        {
            return "It's a tie";
        }
        else if ((userChoice == "Stone" && computerChoice == "Scissor") ||
                 (userChoice == "Paper" && computerChoice == "Stone") ||
                 (userChoice == "Scissor" && computerChoice == "Paper"))
        {
            playerScore++;
            return "You won";
        }
        else
        {
            computerScore++;
            return "Computer wins";
        }
    }

    private void PrintScore()
    {
        Console.WriteLine($"Player Score: {playerScore}");
        Console.WriteLine($"Computer Score: {computerScore}");
    }

    class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.Play();
        }
    }

}
