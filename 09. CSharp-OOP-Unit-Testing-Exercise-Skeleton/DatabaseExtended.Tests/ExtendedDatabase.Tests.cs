using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RemoveMethodIsEmptyThrowException()
        {
            //Arrange


            ExtendedDatabase extendedDatabase = new ExtendedDatabase();


            //Act-Assert

            Assert.Throws<InvalidOperationException>(()
                => extendedDatabase.Remove());
        }

        [Test]
        public void TestConstructor()
        {
            //Arange
            Person Person = new Person(12222, "Anatoli");

            ExtendedDatabase extendedDatabase = new ExtendedDatabase();


            extendedDatabase.Add(Person);

            //Act
            var expectedResult = Person;
            var acctualResultId = extendedDatabase.FindById(12222);
            var acctualResultUsername = extendedDatabase.FindByUsername("Anatoli");





            //Assert

            Assert.AreEqual(expectedResult, acctualResultId);
            Assert.AreEqual(expectedResult, acctualResultUsername);

        }


        [Test]
        public void IfTehereAreUsersWithThisUsernameThrowException()
        {
            //Arrange
            Person Person = new Person(12222, "Anatoli");

            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(Person);

            //Act-Assert

            Assert.Throws<InvalidOperationException>(()
                => extendedDatabase.Add(Person));
        }

        [Test]
        public void IfTehereAreUsersWithThisIDThrowException()
        {
            //Arrange
            Person Person = new Person(5, "Anatoli");

            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(Person);

            //Act-Assert

            Assert.Throws<InvalidOperationException>(()
                => extendedDatabase.Add(Person));
        }


        [Test]
        public void IfNoHaveUserWithThisUsernameThrowException()
        {
            //Arrange
            Person Person = new Person(5, "Anatoli");

            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(Person);

            //Act-Assert

            Assert.Throws<InvalidOperationException>(()
                => extendedDatabase.FindByUsername("kolio"));
        }

        [Test]
        public void IfUsernameIsNullThrowException()
        {
            //Arrange
            Person Person = new Person(5, "Anatoli");

            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(Person);

            //Act-Assert

            Assert.Throws<ArgumentNullException>(()
                => extendedDatabase.FindByUsername(null));
        }

        [Test]
        public void IfNoUserPresentThisidThrowException()
        {
            //Arrange
            Person Person = new Person(45, "Anatoli");

            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(Person);

            //Act-Assert

            Assert.Throws<InvalidOperationException>(()
                => extendedDatabase.FindById(5));
        }

        [Test]
        public void IfFoundNegativeIDThrowException()
        {
            //Arrange
            Person person = new Person(78, "Anatoli");

            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(person);

            //Act-Assert

            Assert.Throws<ArgumentOutOfRangeException>(()
                => extendedDatabase.FindById(-7));
        }

        [Test]
        public void TestCount()
        {
            //Arrange
            Person Person = new Person(78, "Anatoli");
            Person Person1 = new Person(7558, "Anwwwwatoli");
            Person Person2 = new Person(785, "Anwwatoli");


            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(Person);
            extendedDatabase.Add(Person1);
            extendedDatabase.Add(Person2);

            var expectedResult = 3;
            var acctualResult = extendedDatabase.Count;
            //Act-Assert

            Assert.AreEqual(expectedResult, acctualResult);
        }
    }
}