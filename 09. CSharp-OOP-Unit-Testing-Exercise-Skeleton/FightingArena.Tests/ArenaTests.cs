
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class ArenaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConstructorWetherAcceptsListofWarrior()
        {
            var war1 = new Warrior("Stoyan", 10, 50);
            var war2 = new Warrior("Riva", 10, 50);
            var war3FAIL = new Warrior("Riva", 10, 50);

            Arena arena = new Arena();
            arena.Enroll(war1);
            arena.Enroll(war2);
           
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(war3FAIL));
            Assert.AreEqual(arena.Count, 2);
        }
        [Test]
        [TestCase(null,null)]
        [TestCase("Stoyan", "Kolio")]

        public void TestFightWithNullNameShouldThrowException(string name1,string name2)
        {
            var war1 = new Warrior("Stoyan", 10, 50);
            var war2 = new Warrior("Kolio", 10, 50);
            
            Arena arena = new Arena();
            arena.Enroll(war1);
            arena.Enroll(war2);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(name1, name2));

            
        }
    }
}
