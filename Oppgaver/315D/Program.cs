namespace _315D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv en setning: ");
            var sentence = Console.ReadLine() ?? "";
            var statsObject = GetStatsFromSentence(sentence);
            Console.WriteLine("Setningen du skrev har {0} ord, det lengste ordet har {1} bokstaver.", statsObject.WordCount, statsObject.WordLength);
            Console.WriteLine("Ordet med flest vokaler er {0}, det har {1} vokaler.", statsObject.MostVowels, statsObject.VowelCount);
        }
        internal class SentenceStats
        {
            public int WordCount;
            public int WordLength;
            public int VowelCount;
            public string MostVowels = "";
        };

        private static SentenceStats GetStatsFromSentence(string sentence)
        {
            SentenceStats stats = new SentenceStats();
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
    }
}
