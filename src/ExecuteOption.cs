class ExecuteOptionClass{
   public static void ExecuteOption(int optionIndex)
    {

        switch (optionIndex)
        {
            case 0:
                //Challenge 1: String and Number Processor
                Console.CursorVisible = true;
                string result;
                Console.WriteLine("\t------------------Challenge 1------------------\n");
                Console.WriteLine("\t----------Processor String and Number----------");
                result = ProcessesStrNum.StringNumberProcessor();
                Console.WriteLine($"\n\tResult is : {result}");
                Console.ReadKey(true);

                break;
            case 1:
                // Challenge 2: Object Swapper
                Console.CursorVisible = true;

                Console.WriteLine("\n\n\n\t------------------Challenge 2------------------\n");
                Console.WriteLine("\t----------------Object Swapper----------------");

                SwapObjectClass.SwapObjects();
                Console.ReadKey(true);

                break;
            case 2:
                // Challenge 3: Guessing Game
                Console.CursorVisible = true;

                Console.WriteLine("\n\n\n\t------------------Challenge 3------------------\n");
                Console.WriteLine("\t-----------------Guessing Game-----------------\n");
                GuessingGameClass.GuessingGame();
                Console.ReadKey(true);

                break;
            case 3:
                // Challenge 4: Simple Word Reversal
                Console.CursorVisible = true;

                string result4;
                Console.WriteLine("\n\n\n\t------------------Challenge 4------------------\n");
                Console.WriteLine("\t-----------------Reverse Words-----------------\n");

                result4 = ReverseWordClass.ReverseWords();
                Console.WriteLine($"\tReverse Words: '{result4}'");
                Console.ReadKey(true);

                break;
            default:
                // Do nothing for Exit option
                break;
        }
    }
}