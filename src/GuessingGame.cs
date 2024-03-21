class GuessingGameClass
{
    public static void GuessingGame()
    {
        try
        {
            Random random = new Random();
            double randomNumber = random.Next(1, 101);
            double guess;
            bool hintDisplayed = false;
            Console.WriteLine("I've picked a number between 1 and 100.\nTry to guess it, 'Quit' to Exit program\nMore Hint Write 'Hint\n'");

            do
            {
                Console.Write($"Enter your Guess: ");
                string input = Console.ReadLine() ?? " ";

                if (input.ToLower().Trim() == "quit")
                {
                    Console.WriteLine($"Exit Program & The Number: '{randomNumber}'");
                    break;
                }

                if (!double.TryParse(input.Trim(), out guess))
                {
                    if (input.ToLower().Trim() == "hint")
                    {
                        double roundedNumber = Math.Round(randomNumber / 10) * 10;
                        if (randomNumber > roundedNumber)
                        {
                            Console.WriteLine($"\t---- Hint! ----\nThe Number between: '{roundedNumber}' and '{roundedNumber + 10}'\n\t---- Hint! ----{randomNumber}");
                            continue;
                        }
                        Console.WriteLine($"\t---- Hint! ----\nThe Number between: '{roundedNumber - 10}' and '{roundedNumber}'\n\t---- Hint! ----{randomNumber}");
                        continue;

                    }
                    Console.WriteLine($"Invalid Input, Enter Number");
                    continue;
                }


                if (guess > 100 || guess < 1)
                {
                    Console.WriteLine($"Invalid Range Input, Number between 1 and 100");
                    continue;
                }



                if (guess > randomNumber)
                {
                    Console.WriteLine("Try again , Too Low!");
                    if (!hintDisplayed && 50 > randomNumber)
                    {
                        Console.WriteLine($"Hint: it is less than 50!");
                        hintDisplayed = true;
                    }
                    if (!hintDisplayed && 50 < randomNumber)
                    {
                        Console.WriteLine($"Hint:! it is more than 50! ");
                        hintDisplayed = true;
                    }
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Try again , Too High!");
                    if (!hintDisplayed && 50 > randomNumber)
                    {
                        Console.WriteLine($"Hint:! it is less than 50! ");
                        hintDisplayed = true;
                    }
                    if (!hintDisplayed && 50 < randomNumber)
                    {
                        Console.WriteLine($"Hint:! it is more than 50! ");
                        hintDisplayed = true;
                    }
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