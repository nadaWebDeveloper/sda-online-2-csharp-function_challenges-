// Challenge 1: String and Number Processor
class ProcessesStrNum
{
    public static void StringNumberProcessor()
    {
        try
        {
            string textString = "";
            double sumNumber = 0;
            string inputs;

            Console.WriteLine("\tEnter any Number And Any String To Processing:");
            inputs = Console.ReadLine() ?? "";

            string[] sentence = inputs.Split(" ");

            List<string> strings = new List<string>();
            List<double> numbers = new List<double>();

            foreach (string input in sentence)
            {
                if (double.TryParse(input, out double number))
                {
                    numbers.Add(number);
                }
                else
                {
                    strings.Add(input);
                }
            }

            Console.Write("\nNumbers: [ ");
            foreach (double num in numbers)
            {
                Console.Write($"{num}, ");
                sumNumber += num;
            }
            
            Console.Write("]");
            Console.WriteLine();

            Console.Write("Strings: [ ");
            foreach (string str in strings)
            {
                Console.Write($"{str}, ");
                textString += str + " ";
            }
            Console.Write("]");

            Console.WriteLine($"\nThe Result: {textString.Trim()}  {sumNumber}");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Error: {error.Message}");

        }

    }

}