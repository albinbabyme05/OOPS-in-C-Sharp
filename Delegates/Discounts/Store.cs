using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public delegate double DiscountHandler(int q, double p);
    public class Store
    {
        public DiscountHandler discount;
        public double CalculateFinalPrice(int quandity, double price)
        {
            return discount(quandity, price);
        }
    }
}
