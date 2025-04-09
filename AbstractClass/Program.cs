

using AbstractClass;

namespace Polymorphism
{
    class Program
    {
        static void PrintInterface()
        {
            Console.WriteLine("1. Credit Card");
            Console.WriteLine("2.  Upi payment");
        }
        static void Main(string[] args)
        {

            PrintInterface();

            Console.WriteLine("Select a method: ");
            int selection = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Transaction amount in euro: ");
            double amount = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    CreditCardPayment creditTrans = new CreditCardPayment();
                    Console.WriteLine("Credit card tarnsfer initiated...");
                    creditTrans.ProcessPayment(amount);
                    break;

                case 2:
                    UpiPayment upiTrasn = new UpiPayment();
                    Console.WriteLine("Upi tarnsfer initiated...");
                    upiTrasn.ProcessPayment(amount);
                    break;

                default:
                    Console.WriteLine("invalid selection");
                    break;
                    
            }





        }
    }
}

