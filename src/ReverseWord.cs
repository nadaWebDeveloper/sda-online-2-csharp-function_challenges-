class ReverseWordClass
{
    public static string ReverseWords()
    {
        try
        {
            string inputWord;

            Console.WriteLine($"\tEnter sentence to Reverse each word in sentence:");
            inputWord = Console.ReadLine() ?? "";
            string[] inputWords = inputWord.Split(" ");

            for (int i = 0; i < inputWords.Length; i++)
            {
                inputWords[i] = ReverseOneWord(inputWords[i]);
            }

            return string.Join(" ", inputWords).Trim();
        }
        catch (Exception error)
        {
            return $"Error: {error.Message}";
        }
    }

    public static string ReverseOneWord(string word)
    {
        try
        {
            char[] charArr = word.ToCharArray();
            Array.Reverse(charArr);

            return new string(charArr);
        }
        catch (Exception error)
        {
            return $"Error: {error.Message}";
        }
    }


}