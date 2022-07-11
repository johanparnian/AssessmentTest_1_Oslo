using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ConsoleApp
{
    public class GodCat
    {
        public Hamster EatHAmster(Hamster hamster)
        {
            Console.WriteLine($"Godcat has eaten {hamster.Name}, the tasty mouse now is gone for good!");
            hamster = null;
            //GC.Collect();

            return hamster;
        }
    }
}
