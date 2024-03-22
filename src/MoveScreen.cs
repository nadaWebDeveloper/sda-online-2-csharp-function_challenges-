class MoveScreenClass
{
    public static void ArrowKey()
    {
        Console.CursorVisible = false;

        string[] menuOptions = { "Challenge 1", "Challenge 2", "Challenge 3", "Challenge 4", "Exit" };
        int selectedIndex = 0;

        DisplayMenu(menuOptions, selectedIndex);


        bool exitRequested = false;
        while (!exitRequested)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = Math.Max(0, selectedIndex - 1);
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex = Math.Min(menuOptions.Length - 1, selectedIndex + 1);
                    break;
                case ConsoleKey.Enter:
                    if (selectedIndex == menuOptions.Length - 1)
                        exitRequested = true;
                    else
                        ExecuteOptionClass.ExecuteOption(selectedIndex);
                        
                    break;
            }

            DisplayMenu(menuOptions, selectedIndex);
        }
    }

    static void DisplayMenu(string[] options, int selectedIndex)
    {
        Console.Clear();
        Console.WriteLine("Choose an option:");

        for (int i = 0; i < options.Length; i++)
        {
            if (i == selectedIndex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
            }
            else
            {
                Console.Write("  ");
            }
            Console.WriteLine(options[i]);
            Console.ResetColor();
        }
    }

}