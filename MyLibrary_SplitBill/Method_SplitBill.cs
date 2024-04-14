using System;

namespace MyLibrary_SplitBill;
{
    public class Splitter
    {
        public decimal SplitAmount(decimal amount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
            {
                throw new ArgumentException("Number of people must be greater than zero.");
            }
            
            return amount / numberOfPeople;
        }
    }
}
