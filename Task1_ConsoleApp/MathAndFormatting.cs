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

        public static void TellRelationToTheNumber100(int number)
        {
            const int Hundred = 100;
            string numberAsString = number.ToString();
            Console.WriteLine(number);


        }

    }


}
