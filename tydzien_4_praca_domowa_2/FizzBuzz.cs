using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tydzien_4_praca_domowa_2
{
    class FizzBuzz
    {
        public string CheckNumber(int numberToTest)
        {
            if (numberToTest % 3 == 0 && numberToTest % 5 == 0) 
            {
                return "FizzBuzz";
            }
            else if (numberToTest % 5 == 0)
            {
                return "Buzz";
            }
            else if (numberToTest % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return numberToTest.ToString();
            }
        }
    }
}
