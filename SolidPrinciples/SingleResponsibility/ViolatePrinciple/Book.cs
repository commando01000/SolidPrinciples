using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.ViolatePrinciple
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PublishYear { get; set; } // year

        public Book(string title, string author, string description, double price, string publishYear)
        {
            Title = title;
            Author = author;
            Description = description;
            Price = price;
            PublishYear = publishYear;
        }
    }
}
