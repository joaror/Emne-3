namespace _315B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] gameWords = [
                [ "steinsaks", "sakspapir", "papirstein" ],
                [ "stein", "saks", "papir" ],
                [ "y", "n" ]
            ];

            string ComputerPicks()
            {
                var randomIndex = new Random().Next(0, 3);
                return gameWords[1][randomIndex];
            }

            Boolean KeepGaming()
            {
                while (true)
                {
                    Console.WriteLine("En gang til? (Y/n)");
                    string answer = Console.ReadLine() ?? "";

                    if (String.Equals(answer, "Y", StringComparison.OrdinalIgnoreCase) || String.Equals(answer, ""))
                    {
                        Console.Clear();
                        break;
                    }
                    else if (String.Equals(answer, "n", StringComparison.OrdinalIgnoreCase))
                        Environment.Exit(0);
                }

                return true;
            }

            string HumanInput()
            {
                string strInput;
                Boolean notString = true;
                do
                {
                    Console.Write("Stein, Saks eller Papir : ");
                    strInput = Console.ReadLine() ?? "";
                    if (gameWords[1].Contains(strInput)) notString = false;
                }
                while (notString);

                return strInput;
            }

            do
            {
                var computerChoice = ComputerPicks();
                var humanChoice = HumanInput();
                Console.WriteLine("\n{0} VS {1}\n", humanChoice, computerChoice);
                if (humanChoice == computerChoice)
                {
                    Console.WriteLine("Uavgjort\n");
                }
                else if (gameWords[0].Contains(humanChoice + computerChoice))
                {
                    Console.WriteLine("Du vant\n");
                }
                else
                {
                    Console.WriteLine("Du tapte\n");
                }

            }
            while (KeepGaming());
        }
    }
}
