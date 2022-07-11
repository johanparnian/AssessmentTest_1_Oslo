using System.Collections.Generic;
using NUnit.Framework;
using Task2_ConsoleApp;

namespace Task2_NUnitTest
{
    public class TestsTask2
    {
        [Test]
        public void Test_APetHamsterWhoDoesNotLikeFood()
        {
            Hamster hamster = new("Maximilian", true, HamsterSpecies.Campbell);
            string result = hamster.GetHamsterDescription();

            Assert.AreEqual("Maximilian is a pet Campbell hamster. Maximilian doesn't like any food.", result);
        }

        [Test]
        public void Test_APetHamsterWhoLikesThreeTypesOfFood()
        {
            Hamster hamster = new("Dexter", true, HamsterSpecies.Syrian);
            hamster.FoodList = new List<string> { "seeds", "fruits", "insects" };
            string result = hamster.GetHamsterDescription();

            Assert.AreEqual("Dexter is a pet Syrian hamster. Dexter likes 3 types of food.", result);
        }

        [Test]
        public void Test_APetHamsterWhoLikesTwoTypesOfFood()
        {
            Hamster hamster = new("Chiquita", true, HamsterSpecies.Roborovski);
            hamster.FoodList = new List<string> { "fruits", "insects" };
            string result = hamster.GetHamsterDescription();
            Assert.AreEqual("Chiquita is a pet Roborovski hamster. Chiquita likes 2 types of food.", result);
        }

        [Test]
        public void Test_AWildHamsterWhoLikesOneTypeOfFood()
        {
            Hamster hamster = new("Goldilocks", false, HamsterSpecies.WinterWhite);
            hamster.FoodList = new List<string> { "insects" };
            string result = hamster.GetHamsterDescription();

            // Info to students: note that we expect the word "type" instead of "types".
            Assert.AreEqual("Goldilocks is a wild WinterWhite hamster. Goldilocks likes 1 type of food.", result);
        }

        // Create a new constructor in the Hamster class so the following test will pass.
        // The new constructor should give some default data for the hamster: WinterWhite species, is not a pet, insects in FoodList.
        [Test]
        public void Test_AHamsterCreatedWithAlternativeConstructor()
        {
            Burrow burrow = new(10.77, 20.55);
            Hamster hamster = new("Jojo", burrow);

            // Info to students: Depending on your computer's language/localization, you might get problems with decimal numbers.
            //					 If you get '.' instead of ',' as decimal separator, look into this way of writing ToString: 
            //                   your-variablename-here.ToString(CultureInfo.GetCultureInfo("no-NO"))
            //					 The setup above should force ',' as the decimal separator. (Google the topic if it doesn't work.)
            string burrowPosition = hamster.GetBurrowDescription();
            Assert.AreEqual("Jojo has a burrow at longitude 10,77 and latitude 20,55.", burrowPosition);

            Assert.IsFalse(hamster.IsPet);
            Assert.AreEqual("Jojo is a wild WinterWhite hamster. Jojo likes 1 type of food.", hamster.GetHamsterDescription());
            Assert.AreEqual(1, hamster.FoodList.Count);
            Assert.AreEqual("insects", hamster.FoodList[0]);

            // Now Jojo don't have a burrow anymore. :-(
            hamster.Burrow = null;

            Assert.AreEqual("Jojo doesn't have a burrow.", hamster.GetBurrowDescription());
        }
    }
}
