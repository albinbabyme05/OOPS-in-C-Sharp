using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public class Discount
    {
        // fixed amount discounted from total price
        public double PercentageDiscount(int quandity, double price)
        {
            if (quandity > 5)
            {
                Console.WriteLine("==============PercentageDiscount=================");
                double result = quandity * price * (1 - 0.85);
                Console.WriteLine($"Original price {quandity * price}");
                Console.WriteLine($"Discounted price{result}");
                return result;
            }
            return quandity * price;
        }

        //pay for only half the items
        public double ByoneGetOne(int quandity, double price)
        {
            Console.WriteLine("==============ByoneGetOne=================");
            double itempayfor = quandity / 2 + quandity % 2;
            
            Console.WriteLine($"Original price {quandity * price}");
            double result = price * itempayfor;
            Console.WriteLine($"Discounted price{result}");

            Console.WriteLine("You are eligble to take one more dress");
            return result;
        }

        // fixed amount substrcated from final amount
        public double FlatDiscount(int quandity, double price)
        {

            Console.WriteLine("==============FlatDiscount=================");
            double result = (price * quandity) - 15;
            Console.WriteLine($"Original price {quandity * price}");
            Console.WriteLine($"Discounted price{result}");
            return result;
        }
    }
}
