namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] options = { "ROCK", "PAPER", "SCISSORS" };
            int score = 0;
            int computerScore = 0;

            Console.WriteLine("Rock, Paper, Scissors!");
            Console.WriteLine("Best 2 out of 3!");

            for (int i = 0; i < 3; i++)
            {
                begin:
                string computerChoice = options[rnd.Next(0, 3)];

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine().ToUpper();

                if (choice == computerChoice)
                {
                    Console.WriteLine($"Tie! You both chose {choice}!");
                    goto begin;
                }
                else if (choice == "ROCK" && computerChoice == "PAPER")
                {
                    Console.WriteLine("You: ROCK; Computer: PAPER");
                    Console.WriteLine("Paper Covers Rock! Computer Wins This Round!");
                    computerScore++;
                }
                else if (choice == "ROCK" && computerChoice == "SCISSORS")
                {
                    Console.WriteLine("You: ROCK; Computer: SCISSORS");
                    Console.WriteLine("Rock Smashes Scissors! You Win This Round!");
                    score++;
                }
                else if (choice == "PAPER" && computerChoice == "ROCK")
                {
                    Console.WriteLine("You: PAPER; Computer: ROCK");
                    Console.WriteLine("Paper Covers Rock! You Win This Round!");
                    score++;
                }
                else if (choice == "PAPER" && computerChoice == "SCISSORS")
                {
                    Console.WriteLine("You: PAPER; Computer: SCISSORS");
                    Console.WriteLine("Scissors Cuts Paper! Computer Wins This Round!");
                    computerScore++;
                }
                else if (choice == "SCISSORS" && computerChoice == "ROCK")
                {
                    Console.WriteLine("You: SCISSORS; Computer: ROCK");
                    Console.WriteLine("Rock Smashes Scissors! Computer Wins This Round!");
                    computerScore++;
                }
                else if (choice == "SCISSORS" && computerChoice == "PAPER")
                {
                    Console.WriteLine("You: SCISSORS; Computer: PAPER");
                    Console.WriteLine("Scissors Cuts Paper! You Win This Round!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Invalid Choice!");
                }
            }

            if (score == 3)
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }
        }
    }
}