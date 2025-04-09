using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class UpiPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Done!!!✅ ");
            Console.WriteLine($"Tranferred {amount} euro via Gpay Upi");
        }
    }
}
