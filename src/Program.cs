using System;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            // Challenge 2: Object Swapper
            // Console.WriteLine("\nChallenge 2: Object Swapper");
            // int num1 = 25, num2 = 30;
            // int num 3 = 10, num4 = 30;
            // string str1 = "HelloWorld", str2 = "Programming";
            // string str3 = "Hi", str4 = "Programming";

            //SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            //SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            //SwapObjects(str1, str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            //SwapObjects(str3, str4); // Error: Length must be more than 5

            //SwapObjects(true, false); // Error: Upsupported data type
            //SwapObjects(ref num1, str1); // Error: Objects must be of same types

            // Console.WriteLine($"Numbers: {num1}, {num2}");
            // Console.WriteLine($"Strings: {str1}, {str2}");

            // Challenge 3: Guessing Game
            // Console.WriteLine("\nChallenge 3: Guessing Game");
            // Uncomment to test the GuessingGame method
            // GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`

            // Challenge 4: Simple Word Reversal
            // Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            // string sentence = "This is the original sentence!";
            // string reversed = ReverseWords(sentence);
            // Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"



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
            string inputObj , result2;
            Console.WriteLine("\t------------------Challenge 2------------------\n");
            Console.WriteLine("\t----------------Object Swapper----------------");
            Console.WriteLine($"\tEnter Two Number Or Two String To Swapper:");
            inputObj = Console.ReadLine() ?? "";
            string[] inputArray = inputObj.Split(" ");

            result2 = SwapObjectClass.SwapObjects(ref inputArray);
            Console.WriteLine($"{result2}");
            // Console.WriteLine("\t------------------Challenge 2------------------\n");




        }
    }
}
