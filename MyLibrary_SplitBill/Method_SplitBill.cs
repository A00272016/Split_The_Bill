//A002672016
//Milan Pandya
using System;
using System.Collections.Generic;

namespace MyLibrary_SplitBill
{
    public class Method_SplitBill
    {
        // Method to split an amount by the number of people
        public decimal SplitAmount(decimal amount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
            {
                throw new ArgumentException("Number of people must be greater than zero.");
            }

            return amount / numberOfPeople;
        }
        // Method to calculate tip amounts based on meal costs and tip percentage
        public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
           
            var tipAmounts = new Dictionary<string, decimal>();

            foreach (var kvp in mealCosts)
            {
                decimal tipAmount = kvp.Value * (decimal)(tipPercentage / 100);
                tipAmounts.Add(kvp.Key, tipAmount);
            }

            return tipAmounts;
        }

        // Method to calculate tip per person based on total bill, number of patrons, and tip percentage
        public decimal CalculateTipPerPerson(decimal totalBill, int numberOfPatrons, float tipPercentage)
        {
            if(tipPercentage<0){
                throw new ArgumentException("Tip percentage can be either 0 or positive");
            }
            else if (numberOfPatrons <= 0)
            {
                throw new ArgumentException("Number of patrons must be greater than zero.");
            }
            else{
                decimal tipAmount = totalBill * (decimal)(tipPercentage / 100);
                return tipAmount / numberOfPatrons;
            }
        }
    }
}
