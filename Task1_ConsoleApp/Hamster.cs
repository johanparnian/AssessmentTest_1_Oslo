using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ConsoleApp
{
    public class Hamster
    {
        public string Name { get; set; }
        public bool IsPet { get; set; }
        public HamsterSpecies HamsterSpecies { get; set; }

        public Hamster (string name, bool isPet, HamsterSpecies hamsterSpecies)
        {
            Name = name;
            IsPet = isPet;
            HamsterSpecies = hamsterSpecies;
        }

        public string GetHamsterDescription()
        {
            return $"{Name} is a {(IsPet ? "pet" : "wild")} {HamsterSpecies} hamster.";
        }

        
    }
}
