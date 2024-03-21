class GuessingGameClass
{
    public static void GuessingGame()
    {
        try
        {
            Random random = new Random();
            double randomNumber = random.Next(1, 101);
            double guess;
            Console.WriteLine("I've picked a number between 1 and 100. Try to guess it, 'Quit' to Exit program");

            do
            {
                Console.Write($"Enter your Guess: ");
                string input = Console.ReadLine() ?? "";

                 if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Exit Program");
                    break;
                }

                if (!double.TryParse(input, out guess))
                {
                    Console.WriteLine($"Invalid Input, enter number between 1 and 100");
                    continue;
                }

                if (guess > randomNumber)
                {
                    Console.WriteLine($"Try again , Too Low!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine($"Try again , Too High!");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number '{randomNumber}'!");

                }


            } while (guess != randomNumber);
        }
        catch (Exception error)
        {
            Console.WriteLine($"Error: {error.Message}");

        }


    }
}