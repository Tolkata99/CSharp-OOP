
using NUnit.Framework;
using System;
using Database;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database1 dataBase;

        [SetUp]
        public void Setup()
        {
            this.dataBase = new Database1();
        }

        [Test]
        public void Add_ThrowException_WhenMaxCapasity()
        {


            for (int i = 0; i < 16; i++)
            {
                dataBase.Add(i);
            }


            Assert.Throws<InvalidOperationException>(() => dataBase.Add(17));
        }

        [Test]
        public void Add_IncreasesCount_WhenAddIsValidOpreration()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                dataBase.Add(i);
            }

            Assert.That(dataBase.Count, Is.EqualTo(n));
        }

        [Test]
        public void Add_ElementToArray()
        {

            int added = 85859;
            dataBase.Add(added);

            int[] elements = dataBase.Fetch();

            Assert.IsTrue(elements.Contains(added));
        }

        [Test]
        public void Remove_ElementsException_WhenDataBaseIsNull()
        {

            Assert.Throws<InvalidOperationException>(() => dataBase.Remove());
        }

        [Test]
        public void Remove_Decreases_DataBaseCount()
        {
            dataBase.Add(58);
            dataBase.Add(58);
            dataBase.Add(58);
            dataBase.Add(58);

            dataBase.Remove();

            Assert.That(dataBase.Count, Is.EqualTo(3));
        }

        [Test]
        public void Remove_Decreases_DataBase()
        {
            dataBase.Add(58);
            dataBase.Add(58);
            dataBase.Add(58);
            dataBase.Add(58);

            dataBase.Remove();
            int[] elements = dataBase.Fetch();

            Assert.IsFalse(elements.Contains(4));


        }

        [Test]
        public void Fetch_ReturnsDatabaseCopyInsteadOfReffernce()
        {
            dataBase.Add(456);
            dataBase.Add(789);

            int[] firstCopy = dataBase.Fetch();

            dataBase.Remove();

            int[] secondsCopy = dataBase.Fetch();

            Assert.That(firstCopy, Is.Not.EqualTo(secondsCopy));
        }

        [Test]
        public void Count_ReturnZero_WhenDataBaseEmpty()
        {
            Assert.AreEqual(this.dataBase.Count, 0);
        }

        [Test]
        public void Ctor_ThrowException_WhenDatbaseExceeded()
        {
            
            Assert.Throws<InvalidOperationException>(() => 
            this.dataBase = new Database.Database1(1,2,3,4,5,6,7,8,9,10,12,13,14,15,16,17));
        }

        [Test]
        public void Ctor_added_ElementsToDataBase()
        {
            int[] array = new int[] { 1, 2, 3 };
            Assert.That(this.dataBase.Count, Is.EqualTo(array.Length));
            Assert.That(this.dataBase.Fetch(), Is.EquivalentTo(array));
        }
    }
}