using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tydzien_4_praca_domowa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj liczbę całkowitą, lub zakończ wprowadzając 't'");
                var fizzBuzz = new FizzBuzz();
                var resultToDisplay = fizzBuzz.CheckNumber(GetUserIntInput());
                Console.WriteLine(resultToDisplay);
            }
        }

        private static int GetUserIntInput()
        {
            while (true)
            {
                var shouldExit = Console.ReadLine();
                if(shouldExit.ToUpper() == "T")
                {
                    Environment.Exit(0);
                }
                if(!int.TryParse(shouldExit, out int result)){
                    Console.WriteLine("Błędne wprowadzenie, wprowadź liczbę całkowitą!");
                    continue;
                }
                return result;
            }
        }
    }
}
