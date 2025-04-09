using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Payment
    {
        //abstract method
        public abstract void ProcessPayment(double amount);

        //non-abstract method
        public void PrintDetails(double amount)
        {
            Console.WriteLine($"Transaction amount: {amount}");
            Console.WriteLine($"Transaction date: {DateTime.Now}");
        }
    }
}
