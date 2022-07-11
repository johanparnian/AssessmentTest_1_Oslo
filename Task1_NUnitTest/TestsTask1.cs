using NUnit.Framework;
using Task1_ConsoleApp;

namespace Task1_NUnitTest
{
	public class TestsTask1
	{
		[Test]
		public void Test_AddThree()
		{
			int result = MathAndFormatting.AddThree(5);
			Assert.AreEqual(8, result);
		}

		[TestCase(0, 3)]   // 0 + 3 = 3
		[TestCase(5, 8)]   // 5 + 3 = 8
		[TestCase(10, 13)] // 10 + 3 = 13
		public void TestCase_AddThree(int number, int expected)
		{
			int result = MathAndFormatting.AddThree(number);
			Assert.AreEqual(expected, result);
		}

        [TestCase(0, 12)] // 4 * 3 = 12
        [TestCase(1, 15)] // 5 * 3 = 15
        [TestCase(5, 27)] // 9 * 3 = 27
        public void TestCase_AddFourAndThenMultiplyByThree(int number, int expected)
        {
            int result = MathAndFormatting.AddFourAndThenMultiplyByThree(number);
            Assert.AreEqual(expected, result);
        }


        [TestCase(-5555, "-5555 is a negative number")]
        [TestCase(-1, "-1 is a negative number")]
        [TestCase(92, "Add 8 to 92 and you get 100")]
        [TestCase(95, "Add 5 to 95 and you get 100")]
        [TestCase(100, "Add 0 to 100 and you get 100")]
        [TestCase(101, "101 is greater than 100")]
        [TestCase(4444, "4444 is greater than 100")]
        public void TestCase_TellRelationToTheNumber100(int number, string expected)
        {
            string result = MathAndFormatting.TellRelationToTheNumber100(number);
            Assert.AreEqual(expected, result);
        }

        //		[TestCase("Nemo", true, HamsterSpecies.Roborovski, "Nemo is a pet Roborovski hamster.")]
        //		[TestCase("Kernel", false, HamsterSpecies.Syrian, "Kernel is a wild Syrian hamster.")]
        //		public void TestCase_GetHamsterDescription(string name, bool isPet, HamsterSpecies hamsterSpecies, string expected)
        //		{
        //			Hamster hamster = new(name, isPet, hamsterSpecies);
        //			string result = hamster.GetHamsterDescription();

        //			Assert.AreEqual(expected, result);
        //		}
    }
}