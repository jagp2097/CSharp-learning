using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        // The DataType attribute specifies the type of the data (Date)
        // With this attribute:
            // The user is not required to enter time information in the date field.
            // Only the date is displayed, not time information.
        [DataType(DataType.Date)] 
        public DateTime ReleasedDate { get; set; }
        public String Genre { get; set; }
        public decimal Price { get; set; }
    }
}