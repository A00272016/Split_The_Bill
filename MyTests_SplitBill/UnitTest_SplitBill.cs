using System;
using Xunit;
using MyLibrary_SplitBill;

namespace MyTests_SplitBill
{
    public class SplitterTests
    {
        [Fact]
        public void SplitAmount_Returns_CorrectAmount()
        {
            // Arrange
            var splitter = new Splitter();
            decimal amount = 100;
            int numberOfPeople = 4;

            // Act
            var result = splitter.SplitAmount(amount, numberOfPeople);

            // Assert
            Assert.Equal(25, result);
        }

        [Fact]
        public void SplitAmount_Throws_Exception_WhenNumberOfPeopleIsZero()
        {
            // Arrange
            var splitter = new Splitter();
            decimal amount = 100;
            int numberOfPeople = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => splitter.SplitAmount(amount, numberOfPeople));
        }
    }
}
