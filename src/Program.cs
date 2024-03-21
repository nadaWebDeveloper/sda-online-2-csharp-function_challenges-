using System;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
           // Challenge 1: String and Number Processor
            string inputs, result;
            Console.WriteLine("\t------------------Challenge 1------------------\n");
            Console.WriteLine("\t----------Processor String and Number----------");
            Console.WriteLine("\tEnter any Number And Any String To Processing:");
            inputs = Console.ReadLine() ?? "";

            string[] sentence = inputs.Split(" ");
            result = ProcessesStrNum.StringNumberProcessor(sentence);
            Console.WriteLine($"\n\tResult is : {result}");

            // Challenge 2: Object Swapper
            string inputObj, result2;
            Console.WriteLine("\n\n\n\t------------------Challenge 2------------------\n");
            Console.WriteLine("\t----------------Object Swapper----------------");
            Console.WriteLine($"\tEnter Two Number Or Two String To Swapper:");
            inputObj = Console.ReadLine() ?? "";
            string[] inputArray = inputObj.Split(" ");

            result2 = SwapObjectClass.SwapObjects(ref inputArray);
            Console.WriteLine($"{result2}");

            // Challenge 3: Guessing Game
            Console.WriteLine("\n\n\n\t------------------Challenge 3------------------\n");
            Console.WriteLine("\t-----------------Guessing Game-----------------\n");
            GuessingGameClass.GuessingGame();

            // Challenge 4: Simple Word Reversal
            string inputWord, result4;
            Console.WriteLine("\n\n\n\t------------------Challenge 4------------------\n");
            Console.WriteLine("\t-----------------Reverse Words-----------------\n");
            Console.WriteLine($"\tEnter sentence to Reverse each word in sentence:");
            inputWord = Console.ReadLine() ?? "";
            result4 = ReverseWordClass.ReverseWords(inputWord);
            Console.WriteLine($"\tReverse Words: '{result4}'");

        }
    }
}
