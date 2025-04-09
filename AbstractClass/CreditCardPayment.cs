using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class CreditCardPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Done!!!✅ ");
            Console.WriteLine($"Transferred {amount} via CrediCard");
        }
    }
}
