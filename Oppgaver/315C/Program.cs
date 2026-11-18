using System.Text;

namespace _315C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hvilket ord vil du snu? ");
            var theWord = Console.ReadLine() ?? "";

            //WordTurn(theWord);
            WordTurnStringBuilder(theWord);



            static void WordTurn(string theParameter)
            {
                string newStr = "";
                for (int i = theParameter.Length; i > 0; i--)
                {
                    newStr += theParameter[i - 1];
                }
                Console.WriteLine("\n" + newStr);
            }

            static void WordTurnStringBuilder(string theParameter)
            {
                var builder = new StringBuilder();

                if (theParameter.Length > 0)
                {
                    foreach (var c in theParameter)
                    {
                        builder.Insert(0, c);
                    }
                    Console.WriteLine("\n" + builder);
                }
            }
        }
    }
}



//Lag en funksjon som tar en tekst som parameter og som returnerer teksten snudd i motsatt rekkefølge. For eksempel skal 'Terje' bli til 'ejreT.