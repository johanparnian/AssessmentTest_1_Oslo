using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_NUnitTest
{
    public class XtraTestsTask2
    {
        [Test]
        public void Test_APetHamsterWhoDoesNotLikeFood()
        {
            Hamster hamster = new("Maximilian", true, HamsterSpecies.Campbell);
            string result = hamster.GetHamsterDescription();

            Assert.AreEqual("Maximilian is a pet Campbell hamster. Maximilian doesn't like any food.", result);
        }
    }
}
