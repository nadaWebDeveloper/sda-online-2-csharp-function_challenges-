// Challenge 1: String and Number Processor
class ProcessesStrNum
{
    public static string StringNumberProcessor(string[] inputs)
    {
        try
        {
            string textString = "";
            double sumNumber = 0;

            foreach (string input in inputs)
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
            return $"Text '{textString.Trim()}'; Sum Of Number '{sumNumber}'";
        }
        catch (Exception error)
        {
            return $"{error.Message}";

        }
    }

}