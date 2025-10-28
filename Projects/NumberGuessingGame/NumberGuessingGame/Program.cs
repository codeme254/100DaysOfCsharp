namespace NumberGuessingGame
{
    internal class Program
    {
        static string Level = "";
        static int SecretNumber;
        static int NumberOfTrials;
        static void Main()
        {
            // Start by selecting game level
            SelectLevel();
            // Generate a secret number according to level
            GenerateSecretNumber();
            // Set number of trials according to level
            SetNumberOfTrials();
            // Play game
            PlayGame();
        }

        static void LevelPrompt()
        {
            Console.WriteLine("Please pick a level:");
            Console.WriteLine("H for hard");
            Console.WriteLine("M for medium");
            Console.WriteLine("E for easy");
            Console.Write("Type your choice: ");
        }

        static void SelectLevel()
        {
            do
            {
                LevelPrompt();
                Level = Console.ReadLine();
                Console.WriteLine($"You have selected: {Level}");
            }
            while (Level != "h" && Level != "m" && Level != "e");
        }

        static void GenerateSecretNumber()
        {
            Random r = new();
            if (Level == "h") SecretNumber = r.Next(1, 1000);
            else if (Level == "m") SecretNumber = r.Next(1, 500);
            // Default to easy level
            else SecretNumber = r.Next(1, 100);
        }

        static void SetNumberOfTrials()
        {
            if (Level == "h") NumberOfTrials = 5;
            else if (Level == "m") NumberOfTrials = 8;
            // default to easy level
            else NumberOfTrials = 10;
        }

        static void PlayGame()
        {
            Console.WriteLine("\n\nA secret number has been generated!");
            Console.WriteLine($"Guess the number in {NumberOfTrials} tries. Good luck!");
            while (NumberOfTrials > 0)
            {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == SecretNumber)
                {
                    Console.WriteLine("You win.");
                    Console.WriteLine($"Your final score is {NumberOfTrials * 10}%");
                    return;
                }
                NumberOfTrials--;
                if (NumberOfTrials == 0)
                {
                    Console.WriteLine($"You lose.");
                    Console.WriteLine($"The secret number was {SecretNumber}");
                    return;
                }
                if (guess < SecretNumber)
                {
                    Console.WriteLine($"{guess} is too low");
                }
                else if (guess > SecretNumber)
                {
                    Console.WriteLine($"{guess} is too high");
                }
            }
        }
    }
}
