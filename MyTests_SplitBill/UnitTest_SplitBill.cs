using NUnit.Framework;
using System;

[TestFixture]
public class SplitAmountTests
{
    [Test]
    public void SplitEquallyAmongThreePeople()
    {
        // Arrange
        decimal amount = 150;
        int numberOfPeople = 3;
        decimal expectedSplit = 50;

        // Act
        decimal actualSplit = SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.AreEqual(expectedSplit, actualSplit);
    }

    [Test]
    public void UnequalSplitAmongFivePeople()
    {
        // Arrange
        decimal amount = 200;
        int numberOfPeople = 5;
        decimal expectedSplit = 40;

        // Act
        decimal actualSplit = SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.AreEqual(expectedSplit, actualSplit);
    }

    [Test]
    public void SplitAmongOnePerson()
    {
        // Arrange
        decimal amount = 100;
        int numberOfPeople = 1;
        decimal expectedSplit = 100;

        // Act
        decimal actualSplit = SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.AreEqual(expectedSplit, actualSplit);
    }

    public decimal SplitAmount(decimal amount, int numberOfPeople)
    {
        if (numberOfPeople <= 0)
        {
            throw new ArgumentException("Number of people must be greater than zero.");
        }

        return amount / numberOfPeople;
    }
}
