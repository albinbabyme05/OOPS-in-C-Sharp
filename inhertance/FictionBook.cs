using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance
{
    internal class FictionBook : Book
    {

        //property
        
        public string Genre { get; set; }

        public FictionBook(string title, string author, double price, string genre, string description)
            :base(title, author, price, description)
        {
            Genre = genre;
        }

        public override void DisplaInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Genre: " + Genre);
        }

        public override void PrintDescription()
        {
            Console.WriteLine("FictionBook description: " +Description);
        }
    }
}
