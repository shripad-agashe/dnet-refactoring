using System;

namespace refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer("Shripad Agashe");
           Movie regularMovie = new Movie("Pink Panther", Movie.REGULAR);
           Movie newMovie = new Movie("Rainmaker", Movie.NEW_RELEASE);
           Movie childrensMovie = new Movie("Frozen", Movie.REGULAR);
           Rental regularRental = new Rental(regularMovie,3);
           Rental newMovieRental = new Rental(newMovie,3);
           Rental childrenMovieRental = new Rental(childrensMovie,3);
           
           customer.addRental(regularRental);
           customer.addRental(newMovieRental);
           customer.addRental(childrenMovieRental);

           Console.Out.WriteLine(customer.statement());
           customer.statement();
        }
    }
}