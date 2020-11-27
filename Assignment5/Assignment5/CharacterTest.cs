using System;
using System.Collections.Generic;
using System.Text;
using NuGet.Frameworks;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    public class CharacterTest
    {
        // Our test character
        private Character testCharacter;

        [SetUp]
        public void SetUp()
        {
            testCharacter = new Character("JohnnyTest", RaceCategory.Human, 300);
        }

        [TearDown]
        public void CleanUp()
        {
            testCharacter = null;
        }

        [TestCase(100)]
        public void TakeDamageReduceCorrectAmountHealth(int finalHealth)
        {
            int damage = 200;
            testCharacter.TakeDamage(damage);

            // Check if the testCharacter health is equal to 100 after taking 200 hitpoints damage
            Assert.AreEqual(testCharacter.mHealth, finalHealth);
        }

        [TestCase(400)]
        public void TakeDamageSetAlivetoFalse(int damage)
        {
            testCharacter.TakeDamage(damage);

            // Check if the testCharacter isAlive bool is set to false after taking 400 hitpoints damage
            Assert.IsFalse(testCharacter.isAlive);
        }

        [TestCase(500)]
        public void RestoreHealthRestoreCorrectAmountHealth(int heal)
        {
            int recoveredHealth = 200;
            testCharacter.RestoreHealth(recoveredHealth);

            // Check if the testCharacter's health is equal to 500 after recovering 200 healpoints
            Assert.AreEqual(testCharacter.mHealth, heal);
        }

        [Test]
        public void RestoreHealthSetAlivetoTrue()
        {
            // Check if the testCharacter isAlive bool is set to true when his health is above 0
            Assert.IsTrue(testCharacter.isAlive);
        }

    }
}
