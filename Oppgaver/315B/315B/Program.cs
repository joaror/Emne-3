namespace _315B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "stein", "saks", "papir" };
            string[] gameWords = { "steinsaks", "sakspapir", "papirstein" };

            string ComputerPicks()
            {
                var randomIndex = new Random().Next(0, 3);
                return items[randomIndex];
            }

            string HumanInput()
            {
                string strInput;
                Boolean notString = true;
                do
                {
                    Console.Write("Stein, Saks eller Papir : ");
                    strInput = Console.ReadLine() ?? "";
                    if (items.Contains(strInput)) notString = false;
                }
                while (notString);

                return strInput;
            }

            while (true)
            {
                var computerChoice = ComputerPicks();
                var humanChoice = HumanInput();
                Console.WriteLine("\n" + humanChoice + " VS " + computerChoice + "\n");
                if (humanChoice == computerChoice)
                {
                    Console.WriteLine("Uavgjort\n");
                }
                else if (gameWords.Contains(humanChoice + computerChoice))
                {
                    Console.WriteLine("Du vant\n");
                }
                else
                {
                    Console.WriteLine("Du tapte\n");
                }
                Console.WriteLine("En gang til? (Y/n)");
                string answer = Console.ReadLine() ?? "";
                if (String.Equals(answer, "Y", StringComparison.OrdinalIgnoreCase) || String.Equals(answer, ""))
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
