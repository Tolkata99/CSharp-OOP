using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShouldLosesLealthWhenAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(100, 100);

        //Act
        dummy.TakeAttack(10);
        var expectedResult = 90;
        var actualResult = dummy.Health;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void DeadDummyShouldThrowsException()
    {
        //Arrange
        Dummy dummy = new Dummy(0,0);

        //Act - Assert

        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(55));

       
    }

    [Test]
    public void DeadDummyShouldCanGiveXP()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);

        //Act
        var expectedResult = 100;
        var actualResult = dummy.GiveExperience();

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void AliveDummyshouldCanotGiveXP()
    {
        //Arrange
        Dummy dummy = new Dummy(100,100);

        //Act - Assert
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

    }
}
