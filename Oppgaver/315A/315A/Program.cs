namespace _315A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(); ;
            var number = random.Next(1, 10);
            var attempts = 0;

            while (true)
            {
                Console.WriteLine("Guess a number between 1 and 10:");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int guess))
                {
                    attempts++;
                    if (guess < number)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You've guessed the number!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            Console.WriteLine($"The random number is: {number}");
            Console.WriteLine($"Number of attempts: {attempts}");

        }
    }
}
