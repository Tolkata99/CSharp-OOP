using NUnit.Framework;  
using System.Linq;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldBeInitializeWith16Element()
        {   
            //Arange
            int[] numbers = Enumerable.Range(1, 16).ToArray();

            Database database = new Database(numbers);

            //Act
            var expectedResult = 16;
            var acctualResult = database.Count;



            //Assert

            Assert.AreEqual(expectedResult, acctualResult);
        }

        [Test]
        public void AddOperationShouldAddElementNextFeeCell()
        {
            //Arange
            int[] numbers = Enumerable.Range(1, 10).ToArray();
            Database database = new Database(numbers);
            database.Add(6);

            //Act

            var expectedResult = 6;
            var allElement = database.Fetch();


            //Assert

            Assert.AreEqual(expectedResult, allElement[10]);
        }

        [Test]
        public void IfThereAre16ElementsTryAddThrowException()
        {
            //Arange
            int[] numbers = Enumerable.Range(1, 16).ToArray();

            Database database = new Database(numbers);

            //Act - Assert

            Assert.Throws<InvalidOperationException>(() => database.Add(1));
        }

        [Test]
        public void RemoveOperationRemovingLastIndex()
        {
            //Arange
            int[] numbers = Enumerable.Range(1, 16).ToArray();

            Database database = new Database(numbers);
            database.Remove();
            //Act
            var expectedResult = 15;
            var acctualResult = database.Count;



            //Assert

            Assert.AreEqual(expectedResult, acctualResult);
        }

        [Test]
        public void IfTryRemovingElementsOfEmptyArrayShouldThrowsException()
        {
            //Arange            
            Database database = new Database();

            //Act - Assert

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FechMethodShoulfReturnOnlyAray()
        {
            //Arange
            int[] numbers = Enumerable.Range(1, 16).ToArray();
            Database database = new Database(numbers);

            //Act

            var expectedlResult = database.Fetch();
            int[] acctualResult = Enumerable.Range(1, 16).ToArray(); ;


            //Assert

            Assert.AreEqual(expectedlResult, acctualResult);
        }



    }
}