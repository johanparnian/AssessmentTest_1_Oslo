using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using NUnit.Framework;
using Task2_ConsoleApp;
namespace Task2_NUnitTest
{
    public class XtraTestsTask2
    {
        [Test]
        public void Test_GodCat()
        {
            Hamster jojo = new("Jojo", true, HamsterSpecies.Campbell);
            GodCat Lucifer = new();
            
            bool jojoAlive = true;
            Lucifer.EatHAmster(jojo);
            if (jojo == null)
                jojoAlive = false;

            Assert.IsFalse(jojoAlive);
        }
    }
}
