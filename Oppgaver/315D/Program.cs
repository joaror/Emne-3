namespace _315D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv en setning: ");
            var sentence = Console.ReadLine() ?? "";
            ProgramHelpers.PrintProgreessBar(10);
            var statsObject = ProgramHelpers.GetStatsFromSentence(sentence);
            Console.WriteLine("Setningen du skrev har {0} ord, det lengste ordet har {1} bokstaver.", statsObject.WordCount, statsObject.WordLength);
            Console.WriteLine("Ordet med flest vokaler er {0}, det har {1} vokaler.", statsObject.MostVowels, statsObject.VowelCount);
            ProgramHelpers.PrintColoredBar(statsObject.WordCount, (ConsoleColor)ProgramHelpers.GetRandomInt(1, 14), "Antall ord");
            ProgramHelpers.PrintColoredBar(statsObject.WordLength, (ConsoleColor)ProgramHelpers.GetRandomInt(1, 14), "Antall bokstaver i det lengste ordet");
            ProgramHelpers.PrintColoredBar(statsObject.VowelCount, (ConsoleColor)ProgramHelpers.GetRandomInt(1, 14), "Antall vokaler i ordet med flest vokaler");
        }
    }
}
