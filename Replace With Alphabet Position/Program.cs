namespace Replace_With_Alphabet_Position
{
    internal class Program
    {
        public static string AlphabetPosition(string text)
        {
            List<char> alphabet = new List<char>();

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add(i);
            }

            return string.Join(' ', text.ToLower().Where(char.IsLetter).Select(c => alphabet.IndexOf(c) + 1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetPosition("\"The sunset sets at twelve o' clock.\""));
        }
    }
}