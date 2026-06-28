namespace VowelsChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiou";

            Console.WriteLine("please enter a string...");
            string input = Console.ReadLine().ToLower();

            bool hasVowels = false;

            foreach (var item in input)
            {
                if (vowels.Contains(item))
                {
                    hasVowels = true;
                    break;
                }
            }

            if (!hasVowels) throw new Exception("string doesn't contain any vowels");

            Console.WriteLine("string contain vowels");
        }
    }
}
