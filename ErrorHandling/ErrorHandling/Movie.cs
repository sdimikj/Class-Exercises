using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie (string title, Genre genre, int rating, double ticketprice)
        {

            Title = title;
            Genre = genre;

            try
            {
                if(rating < 0 || rating >= 5)

                {

                    throw new Exception("The rating range is between 1 and 5");
                }

                Console.WriteLine("Congratulations");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }

            Rating = rating;

           
            TicketPrice = ticketprice;
           

        }



    }
}
