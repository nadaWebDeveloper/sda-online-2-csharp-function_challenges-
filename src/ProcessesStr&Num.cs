// Challenge 1: String and Number Processor
class ProcessesStrNum
{
    public static string StringNumberProcessor()
    {
        try
        {
            string textString = "";
            double sumNumber = 0;
            string inputs;


             Console.WriteLine("\tEnter any Number And Any String To Processing:");
            inputs = Console.ReadLine() ?? "";

            string[] sentence = inputs.Split(" ");

            foreach (string input in sentence)
            {
                if (double.TryParse(input, out double number))
                {
                    sumNumber += number;
                }
                else
                {
                    textString += input + " ";
                }

            }
            return $"{textString.Trim()}   {sumNumber}";
            
        }
        catch (Exception error)
        {
            return $"{error.Message}";

        }
        
    }

}