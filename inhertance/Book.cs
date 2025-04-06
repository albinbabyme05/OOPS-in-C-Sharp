using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance
{
    abstract class Book
    {
        //property
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }


        public Book(string title, string author, double price, string description)
        {
            Title = title;
            Author = author;
            Price = price;
            Description = description;
        }

        public virtual void DisplaInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author "+Author);
            Console.WriteLine("Price "+Price);
        }

        // Abstract method
        /* Abstract method declartion only permitted in abstract classes*/
        public abstract void PrintDescription();
        
    }
}
