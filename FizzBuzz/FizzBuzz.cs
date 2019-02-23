using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzzGenerator
    {
        public static void GenerateFizzBuzz()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + CalculateFizzBuzz(i));
            }
        }

        public static string CalculateFizzBuzz(int i)
        {
            if ((i % 3 == 0) && (i % 5 == 0)) return ("FizzBuzz");
            else if (i % 3 == 0) return "Fizz";
            else if (i % 5 == 0) return "Buzz";
            else return "";
        }
    }
}
