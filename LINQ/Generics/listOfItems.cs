using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class listOfItems
    {
        private List<string> ItemsList = new List<string>();

        public void AddItem(string item)
        {
            ItemsList.Add(item);
        }

        public void RemoveItem(string item)
        {
            ItemsList.Remove(item);
        }
        public void Display()
        {
            Console.WriteLine("List of Strings");
            foreach (var item in ItemsList)
            {
                Console.WriteLine(item);
            }
        }   
    }
}
