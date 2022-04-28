using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private int attack = 5;
    private int durability = 6;
    private Axe axe;
    private Dummy dummy;


    [SetUp]
    public void SetUp()
    {
        axe = new Axe(attack, durability);
        dummy = new Dummy(5, 6);
    }




    [Test]
    public void When_AxeAttackAndDurabilityProvided_ShouldBeSetCorrectly()
    {
        Assert.AreEqual(axe.AttackPoints, attack);
        Assert.AreEqual(axe.DurabilityPoints, durability);
    }


    [Test]
    public void When_AxeAttacks_ShouldLoseDurabilityPoints()
    {
        axe.Attack(dummy);

        Assert.AreEqual(durability - 1,axe.DurabilityPoints);
    }
    [Test]
    public void When_AxeAttackWithDurabilityPointsZero_ShouldThrowException()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            dummy = new Dummy(5000, 5000);
            for (int i = 0; i < 7; i++)
            {
                axe.Attack(dummy);
            }

        });
    }
}