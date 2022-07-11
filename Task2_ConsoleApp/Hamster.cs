using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ConsoleApp
{
    public class Hamster
    {
        public string Name { get; private set; }
        public bool IsPet { get; set; }
        public HamsterSpecies HamsterSpecies { get; private set; }
        public List<string> FoodList { get; set; } = new();
        public Burrow Burrow { get; set; }


        public Hamster(string name, bool isPet, HamsterSpecies hamsterSpecies)
        {
            Name = name;
            IsPet = isPet;
            HamsterSpecies = hamsterSpecies;
        }

        public Hamster(string name, Burrow burrow = null, bool isPet = false, HamsterSpecies hamsterSpecies = HamsterSpecies.WinterWhite, List<string> foodList = null)
        {
            Name = name;
            IsPet = isPet;
            HamsterSpecies = hamsterSpecies;
            FoodList = foodList;
            if (FoodList == null)
            {
                FoodList = new();
                FoodList.Add("insects");
            }
            Burrow = burrow;

        }

        public string GetHamsterDescription()
        {

            if (FoodList.Count > 0)
            {//ville kanskje gjort denne linjen kortere med en "if Else" til.
                return $"{Name} is a {(IsPet ? "pet" : "wild")} {HamsterSpecies} hamster. {Name} likes {FoodList.Count} {(FoodList.Count == 1 ? "type" : "types")} of food.";
            }
            else
                return $"{Name} is a {(IsPet ? "pet" : "wild")} {HamsterSpecies} hamster. {Name} doesn't like any food.";

        }

        public string GetBurrowDescription()
        {
            
            if(Burrow != null)
            {
                string longiCommaSeperated = Burrow.Longitude.ToString(CultureInfo.GetCultureInfo("no-NO"));
                string latiCommaSeperated = Burrow.Latitude.ToString(CultureInfo.GetCultureInfo("no-NO"));

                return $"{Name} has a burrow at longitude {longiCommaSeperated} and latitude {latiCommaSeperated}.";
            }
            else
            return $"{Name} doesn't have a burrow.";




        }

    }
}
