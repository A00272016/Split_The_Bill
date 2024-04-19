using System.Collections;
using MyLibrary_SplitBill;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
            // Arrange
            decimal amount = 150;
            int numberOfPeople = 3;
            decimal expectedSplit = 50;

            // Act
            Method_SplitBill splitter = new Method_SplitBill();
            decimal actualSplit = splitter.SplitAmount(amount, numberOfPeople);

            // Assert
            Assert.AreEqual(expectedSplit, actualSplit);
    }
    [TestMethod]
     public void UnequalSplitAmongFivePeople()
        {
            decimal amount = 200;
            int numberOfPeople = 5;
            decimal expectedSplit = 40;
            Method_SplitBill splitter = new Method_SplitBill();
            decimal actualSplit = splitter.SplitAmount(amount, numberOfPeople);
            Assert.AreEqual(expectedSplit, actualSplit);
        }

        [TestMethod]
        public void SplitAmongOnePerson()
        {
            decimal amount = 100;
            int numberOfPeople = 1;
            decimal expectedSplit = 100;
            Method_SplitBill splitter = new Method_SplitBill();
            decimal actualSplit = splitter.SplitAmount(amount, numberOfPeople);
            Assert.AreEqual(expectedSplit, actualSplit);
        }   
        //Test Cases For 3 Method :-
        [TestMethod]
        public void CalculateTipPerPerson_WithValidInput_ReturnsCorrectTipPerPerson()
        {
            decimal totalBill = 100;
            int numberOfPatrons = 4;
            float tipPercentage = 15;
            decimal tipPerPerson = CalculateTipPerPerson(totalBill, numberOfPatrons, tipPercentage);
            Assert.AreEqual(3.75m, tipPerPerson);
        }

        [TestMethod]
        public void CalculateTipPerPerson_WithZeroNumberOfPatrons_ThrowsArgumentException()
        {
            decimal totalBill = 100;
            int numberOfPatrons = 0;
            float tipPercentage = 15;
            Assert.ThrowsException<ArgumentException>(() => CalculateTipPerPerson(totalBill, numberOfPatrons, tipPercentage));
        }

        [TestMethod]
        public void CalculateTipPerPerson_WithNegativeTipPercentage_ThrowsArgumentException()
        {
            decimal totalBill = 100;
            int numberOfPatrons = 4;
            float tipPercentage = -10;
            Assert.ThrowsException<ArgumentException>(() => CalculateTipPerPerson(totalBill, numberOfPatrons, tipPercentage));
        }

        public decimal CalculateTipPerPerson(decimal totalBill, int numberOfPatrons, float tipPercentage)
        {
            if (numberOfPatrons <= 0)
            {
                throw new ArgumentException("Number of patrons must be greater than zero.");
            }

            decimal tipAmount = totalBill * (decimal)(tipPercentage / 100);
            return tipAmount / numberOfPatrons;
        }
}
