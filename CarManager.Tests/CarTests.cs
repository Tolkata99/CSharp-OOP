using CarManager;
using NUnit.Framework;
using System;


namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Tesla", "Model 3", 10, 100)]
        public void CarConstructorShouldSetAllDataCorrect(
            string make
            , string model
            , double fuelConsumption
            , double fuelCapacity)
        {
            //Arrange
            Car car = new Car(
                make: make
                , model: model
                , fuelConsumption: fuelConsumption
                , fuelCapacity: fuelCapacity);


            //Act
            string makee = car.Make;
            string modell = car.Model;
            double fuelConsumationn = car.FuelConsumption;
            double fuelCapacityy = car.FuelCapacity;
            double fuelAmmount = car.FuelAmount;



            //Assert
            Assert.AreEqual(makee, make);
            Assert.AreEqual(modell, model);
            Assert.AreEqual(fuelConsumationn, fuelConsumption);
            Assert.AreEqual(fuelCapacityy, fuelCapacity);
            Assert.AreEqual(fuelAmmount, 0);

        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void TestProppertyMakeShouldThrowExceptionWhenIsNull(
            string make)
        {

            Assert.Throws<ArgumentException>(() => new Car(make, "volvo", 10, 100));


        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void TestProppertyMModelShouldThrowExceptionWhenIsNull(
            string model)
        {

            Assert.Throws<ArgumentException>(() => new Car("VW", model, 10, 100));


        }

        [Test]
        [TestCase(0)]
        [TestCase(-4)]
        public void TestProppertyFuelConsumptionShouldThrowExceptionWhenIsNegativeOrZero(
            double fuelConsumption)
        {

            Assert.Throws<ArgumentException>(() => new Car("VW", "gols", fuelConsumption, 100));


        }

        [Test]
        [TestCase(0)]
        [TestCase(-4)]
        public void TestProppertyFuelCapacityShouldThrowExceptionWhenIsNegativeOrZero(
            double fuelCapacity)
        {

            Assert.Throws<ArgumentException>(() => new Car("VW", "gols", 10, fuelCapacity));


        }

        //TODO: Fuel Amount
       

        [Test]
        [TestCase(0)]
        [TestCase(-4)]
        public void TestMethodFuelToRefuelShouldThrowExceptionWhenIsNegativeOrZero(
            double fuelToRefuel)
        {
            Car car = new Car("VW", "gols", 10, 1000);

            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));


        }

        [Test]
        [TestCase(100,50,50)]
        [TestCase(250, 1000, 250)]
        public void RefuelShouldWorkAsExpected(
            double capacity,double fuel,double expectedResult)
        {
            //Arrange
            Car car = new Car("VW", "gols", 10, capacity);


            //Act
            car.Refuel(fuel);
            var actualResult = car.FuelAmount;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(10,50,505)]
       // [TestCase(501)]
        public void TestMethodDriveShouldThrowExceptionWhenIsNegativeOrZero(
            double fuelConsumtion, double refuel, double distance)
        {
            //Arrange
            Car car = new Car("VW", "gols", fuelConsumtion, 100);

            //Assert - Act
            car.Refuel(refuel);
            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));


        }

        public void DriveShouldReduceFuelBasedOnDrivenKM( )
        {
            //Arrange
            Car car = new Car("VW", "gols", 10, 100);
            car.Refuel(100);

            //Act
            car.Drive(50);

            //Assert
            var expectedValue = 95;
            var actualValue = car.FuelAmount;

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}