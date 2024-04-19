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
    }
