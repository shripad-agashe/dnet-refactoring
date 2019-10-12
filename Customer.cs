using System;
using System.Collections;
using System.Collections.Generic;

namespace refactoring
{
    public class Customer
    {
        private String name;
        private List<Rental> rentalList = new List<Rental>();

        public Customer(String name)
        {
            this.name = name;
        }

        public void addRental(Rental arg)
        {
            rentalList.Add(arg);
        }

        public String getName()
        {
            return name;
        }

        public String statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            String result = "Rental Record for " + getName() + "\n";
            foreach (var each in rentalList)
            {
                double thisAmount = 0;

                // determine amounts for each line
                thisAmount += each.getRentalAmount();

                // add frequent renter points
                frequentRenterPoints++;
                // add bonus for a two day new release rental
                frequentRenterPoints = each.getFrequentRenterPoints(frequentRenterPoints);

                // show figures for this rental
                result += each.printRentalString(thisAmount);
                totalAmount += thisAmount;
            }

            // add footer lines
            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints
                                    + " frequent renter points";
            return result;
        }
    }
}