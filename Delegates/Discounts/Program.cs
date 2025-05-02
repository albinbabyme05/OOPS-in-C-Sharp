using Discounts;

namespace Discounts
{
    class Program
    {
        public static void Main(string[] args)
        {
            Store s = new Store();
            Store s1 = new Store();
            Store s2 = new Store();
            Discount d = new Discount();
            s.discount = d.FlatDiscount;
            s1.discount = d.PercentageDiscount;
            s2.discount = d.ByoneGetOne;

            double res = s.discount(10, 48.99);
            Console.WriteLine($"customer 1 : {res}");
            double res1 = s1.discount(22, 48.99);
            Console.WriteLine($"customer 2 : {res1}");
            double res2 = s2.discount(4, 48.99);
            Console.WriteLine($"customer 3 : {res2}");

        }
    }
}
