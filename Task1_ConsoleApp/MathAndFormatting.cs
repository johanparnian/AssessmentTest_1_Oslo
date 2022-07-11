using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ConsoleApp
{
    public static class MathAndFormatting
    {
        public static int AddThree(int number)
        {
            const int PlusThree = 3;
            int sum = PlusThree + number;
            return sum;
        }

        public static int AddFourAndThenMultiplyByThree(int number)
        {
            const int PlusFour = 4;
            const int TimesThree = 3;
            
            
            int sum = (PlusFour + number)*TimesThree;
            return sum;
        }

        public static string PossiblyUppercaseAndDecorateText(string text, bool toUppercase, bool decorate)

        {
            if (toUppercase)
            {
                text = text.ToUpper();
            }

            if (decorate)
            {
                text = $"-:{text}:-";
            }

            return text;
        }

        public static string TellRelationToTheNumber100(int number)
        {
            const int Hundred = 100;

            if (number >= 0 && number <= 100)
            {
                int rest = Hundred - number;
                return $"Add {rest} to {number} and you get 100";
            }

            else if (number < 0)
            {
                return $"{number} is a negative number";
            }

            else
                return $"{number} is greater than 100";
        }

        public static string GetHamsterDescription(string name, bool isPet, HamsterSpecies hamsterSpecies)
        {
            return "";
        }
    }
}
