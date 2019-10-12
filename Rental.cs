using System;

namespace refactoring
{
    public class Rental
    {
        Movie movie;

        private int daysRented;

        public Rental(Movie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        public Movie getMovie()
        {
            return movie;
        }

        public double getRentalAmount()
        {
            double thisAmount = 0;
            double daysRented1 = daysRented;
            switch (getMovie().getPriceCode())
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    if (daysRented > 2)
                        thisAmount += (daysRented1 - 2) * 1.5;
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += daysRented1 * 3;
                    break;
                case Movie.CHILDRENS:
                    thisAmount += 1.5;
                    if (daysRented1 > 3)
                        thisAmount += (daysRented1 - 3) * 1.5;
                    break;
            }

            return thisAmount;
        }

        public int getFrequentRenterPoints(int frequentRenterPoints)
        {
            if ((getMovie().getPriceCode() == Movie.NEW_RELEASE)
                && this.daysRented > 1)
                frequentRenterPoints++;
            return frequentRenterPoints;
        }

        public String printRentalString(double thisAmount)
        {
            return "\t" + getMovie().getTitle() + "\t"
                   + thisAmount + "\n";
        }
    }
}