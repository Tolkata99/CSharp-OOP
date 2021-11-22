using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    [Test]
    [TestCase(100,100,100,100,99)]
    //[TestCase(5,5,5,5,4)]
    public void WeaponShouldLossesDurabilityAfterAttack(
          int health
        , int exp
        , int attack
        , int durability
        , int expectedResult)
    {
        //Arrange
        Dummy dummy = new Dummy(health, exp);
        Axe axe = new Axe(attack, durability);


        //Act
        axe.Attack(dummy);

        //Assert
        
        var actualResult = axe.DurabilityPoints;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestCase(100,100,100,0)]
    public void AttackingWithBrokenWeaponShouldThrowException(
          int health
        , int exp
        , int attack
        , int durability)
    {
        //Arrange
        Axe axe = new Axe(attack, durability);
        Dummy dummy = new Dummy(health, exp);

        //Act - Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));

      
    }


}