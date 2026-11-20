namespace _315D
{
    internal static class ProgramHelpers
    {
        public static int GetRandomInt(int lower, int upper)
        {
            var random = new Random();
            return random.Next(lower, upper);
        }

        public static SentenceStats GetStatsFromSentence(string sentence)
        {
            SentenceStats stats = new();
            var vowels = "aeiouyæøå";
            string[] wordList = sentence.Split(" ");

            foreach (var word in wordList)
            {
                stats.WordCount++;
                if (word.Length > stats.WordLength) stats.WordLength = word.Length;
                int countingVowels = 0;
                foreach (char c in word)
                {
                    if (vowels.Contains(c)) countingVowels++;
                }
                if (countingVowels > stats.VowelCount)
                {
                    stats.VowelCount = countingVowels;
                    stats.MostVowels = word;
                }
            }
            return stats;
        }

        public static void PrintColoredBar(int barLength, ConsoleColor barColor, string description)
        {
            Console.BackgroundColor = barColor;
            var i = 0;
            var statBar = "";
            while (i < barLength)
            {
                statBar += " ";
                i++;
            }
            Console.Write("\n" + statBar);
            Console.ResetColor();
            Console.Write(" " + description + "\n");
        }
        public static void PrintProgreessBar(int length)
        {
            int i = 0;
            while (i < length)
            {
                Console.Write("#");
                Thread.Sleep(250);
                i++;
            }
            Console.WriteLine("");
        }

        public class SentenceStats
        {
            public int WordCount;
            public int WordLength;
            public int VowelCount;
            public string MostVowels = "";
        };
    }
}