class ReverseWordClass{
    public static string ReverseWords(string text){
      string[] inputWords = text.Split(" ");

        for (int i = 0; i < inputWords.Length; i++)
        {
            inputWords[i] = ReverseOneWord(inputWords[i]);
        }
        return string.Join(" ", inputWords).Trim();
    }

        public static string ReverseOneWord(string word){
 char[] charArr = word.ToCharArray();
 Array.Reverse(charArr);

             return new string(charArr);
        }


}